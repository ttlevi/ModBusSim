using EasyModBus;
using ModBusTest.EasyModBus;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModBusSim.Controls
{

    // This is a class for ModBus Devices to show on screen and to communicate with the client through the cluster

    [Serializable]
    public partial class Device : UserControl
    {
        private int w;
        private int h;
        private int d;

        public Room Room { get; set; }
        public int MaxNrInARow { get; set; } = 5;

        private string deviceName;

        public string DeviceName
        {
            get { return deviceName; }
            set { deviceName = value; txtName.Text = value.ToString(); }
        }

        private int nrOfRegs;

        public int NrOfRegs
        {
            get { return nrOfRegs; }
            set { nrOfRegs = value; cboNrOfRegs.Text = value.ToString(); }
        }


        private bool isdigital;

        public bool IsDigital
        {
            get { isdigital = rbtnDigital.Checked; return isdigital; }
            set { isdigital = value; rbtnDigital.Checked = value; rbtnAnalog.Checked = !value; }
        }



        private int unitID;

        public int UnitID
        {
            get { return unitID; }
            set { unitID = value; nuUnitID.Text = value.ToString(); }
        }

        private int position;

        public int Position
        {
            get { return position; }
            set
            {
                position = value;

                w = Width;
                h = Height;
                d = DeviceDpi / 96 * 10;
                Left = d + (position % MaxNrInARow) * (w + d);
                Top = d + (position / MaxNrInARow) * (h + d);
                Width = w;
                Height = h;
            }
        }

        public Device()
        {
            InitializeComponent();
            
            txtName.Text = "ModBus Device";
            cboNrOfRegs.Text = "5";
        }

        public void LoadRegs(bool isdigital)
        {
            // Adding a new Server instance to the Cluster

            UnitID = int.Parse(nuUnitID.Text);
            //cluster = Room.Building.Cluster;

            Room.Building.Cluster.Add(UnitID);

            // Setting up properties

            NrOfRegs = int.Parse(cboNrOfRegs.Text);
            DeviceName = txtName.Text;

            // Finding the Device in the Cluster list of the Building

            int j = 0;
            foreach (ModbusServer unit in Room.Building.Cluster.Servers)
            {
                if (unit.UnitIdentifier == UnitID) { break; }
                j++;
            }

            // Loading the visual elements (Display) for the necessary holding registers

            if (!isdigital)
            {
                for (int i = 0; i < NrOfRegs; i++)
                {
                    Display disp = new Display();

                    disp.Width = (Width - 2 * d) / 5;
                    disp.Height = panelDevice.Height / 5 - d;

                    disp.Top = (i / 5) * (disp.Height + d);
                    disp.Left = d + (i % 5) * disp.Width;
                    disp.SetLabelsLayout();

                    disp.Address = i + 1;
                    disp.Value = 0;

                    panelDevice.Controls.Add(disp);
                }

                Room.Building.Cluster.Servers[j].HoldingRegistersChanged += (int register, int numberOfRegisters) =>
                {
                    int value = Room.Building.Cluster.Servers[j].holdingRegisters[register];
                    foreach (Display disp in panelDevice.Controls)
                    {
                        if (disp.Address == register) { disp.Value = value; };
                    }
                };
            }

            else
            {
                // Loading the visual elements (Led) for the necessary coils

                for (int i = 0; i < NrOfRegs; i++)
                {
                    Led led = new Led();

                    led.Width = Width / 5 - (d + d / 5);
                    led.Height = panelDevice.Height / 5 - d;

                    led.Top = (i / 5) * (led.Height + d);
                    led.Left = d + (i % 5) * (led.Width + d);

                    led.Address = i + 1;

                    panelDevice.Controls.Add(led);
                }

                Room.Building.Cluster.Servers[j].CoilsChanged += (int coil, int numberOfCoils) =>
                {
                    bool value = Room.Building.Cluster.Servers[j].coils[coil];
                    foreach (Led led in panelDevice.Controls)
                    {
                        if (led.Address == coil) { led.Value = value; };
                    }
                };

            }
        }

        private void EnableControls(bool value)
        {
            nuUnitID.Enabled = value;
            cboNrOfRegs.Enabled = value;
            txtName.Enabled = value;
            rbtnAnalog.Enabled = value;
            rbtnDigital.Enabled = value;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Room.RemoveDevice(this);
            Room.Building.Cluster.Remove(UnitID);
            Room.Building.UnitIDsInUse.Remove(UnitID);
            Room.Building.RefreshRoomDisplays(Room);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (btnConnect.Text == "Connect")
            {
                LoadRegs(IsDigital);
                btnConnect.Text = "Disconnect";
                EnableControls(false);
            }
            else
            {
                Room.Building.Cluster.Remove(UnitID);
                panelDevice.Controls.Clear();
                btnConnect.Text = "Connect";
                EnableControls(true);
            }
            
        }

        // Functions to copy/load necessary settings to/from Serializable settings class

        public DeviceSettings ToDeviceSetting()
        {
            return new DeviceSettings()
            {
                DeviceName = this.DeviceName,
                NrOfRegs = this.NrOfRegs,
                IsDigital = this.IsDigital,
                UnitID = this.UnitID,
                Position = this.Position
            };
        }

        public static Device FromDeviceSettings(DeviceSettings settings)
        {
            Device device= new Device();
            device.DeviceName = settings.DeviceName;
            device.Position = settings.Position;
            device.UnitID = settings.UnitID;
            device.IsDigital = settings.IsDigital;
            device.NrOfRegs = settings.NrOfRegs;
            return device;
        }

        private void rbtnDigital_CheckedChanged(object sender, EventArgs e)
        {
            if (Room != null)
            {
                Room.SaveRoom();
            }
        }
    }

    // Serializable settings class

    public class DeviceSettings
    {
        public string DeviceName { get; set; }
        public int NrOfRegs { get; set; }
        public bool IsDigital { get; set; }
        public int UnitID { get; set; }
        public int Position { get; set; }
    }
}
