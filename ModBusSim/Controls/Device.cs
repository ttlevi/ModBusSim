using EasyModBus;
using ModBusTest.EasyModBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModBusSim.Controls
{

    // This class is an abstraction of the two kinds of devices, helps to set up the common parameters in one place.

    [Serializable]
    public partial class Device : UserControl
    {
        private int w;
        private int h;
        private int d;

        public Room Room { get; set; }
        public string DeviceName { get; set; } = "ModBus Device";
        public int NrOfRegs { get; set; } = 5;

        private bool isdigital;

        public bool IsDigital
        {
            get { isdigital = rbtnDigital.Checked; return isdigital; }
            set { isdigital = value; }
        }



        private int unitID;

        public int UnitID
        {
            get { return unitID; }
            set
            {
                unitID = value;
                foreach (Control o in Controls) { if (o is NumericUpDown) { o.Text = UnitID.ToString(); } }
            }
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
                Left = d + (position % 4) * (w + d);
                Top = d + (position / 4) * (h + d);
                Width = w;
                Height = h;
            }
        }

        public Device()
        {
            InitializeComponent();
            
            txtName.Text = DeviceName;
            cboNrOfRegs.Text = NrOfRegs.ToString();
        }

        private void LoadRegs(bool isdigital)
        {
            // Adding a new Server instance to the Cluster

            UnitID = int.Parse(nuUnitID.Text);
            ModbusServerCluster cluster = Room.Building.Cluster;
            cluster.Add(UnitID);
            Room.Building.UnitIDsInUse.Add(UnitID);
            Room.Devices.Add(this);

            nuUnitID.Enabled = false;
            cboNrOfRegs.Enabled = false;
            btnConnect.Enabled = false;
            txtName.Enabled = false;
            rbtnAnalog.Enabled = false;
            rbtnDigital.Enabled = false;

            // Setting up properties

            NrOfRegs = int.Parse(cboNrOfRegs.Text);
            DeviceName = txtName.Text;

            // Finding the Device in the Cluster list of the Building

            int j = 0;
            foreach (ModbusServer unit in cluster.Servers)
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
                    disp.Height = panel1.Height / 5 - d;

                    disp.Top = (i / 5) * (disp.Height + d);
                    disp.Left = d + (i % 5) * disp.Width;
                    disp.SetLabelsLayout();

                    disp.Address = i + 1;
                    disp.Value = 0;

                    panel1.Controls.Add(disp);
                }

                cluster.Servers[j].HoldingRegistersChanged += (int register, int numberOfRegisters) =>
                {
                    int value = cluster.Servers[j].holdingRegisters[register];
                    foreach (Display disp in panel1.Controls)
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
                    led.Height = panel1.Height / 5 - d;

                    led.Top = (i / 5) * (led.Height + d);
                    led.Left = d + (i % 5) * (led.Width + d);

                    led.Address = i + 1;

                    panel1.Controls.Add(led);
                }

                cluster.Servers[j].CoilsChanged += (int coil, int numberOfCoils) =>
                {
                    bool value = cluster.Servers[j].coils[coil];
                    foreach (Led led in panel1.Controls)
                    {
                        if (led.Address == coil) { led.Value = value; };
                    }
                };

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Room.RemoveDevice(this);
            Room.Building.Cluster.Remove(UnitID);
            Room.Building.UnitIDsInUse.Remove(UnitID);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            LoadRegs(IsDigital);
            Room.Building.RefreshRoomDisplays(Room);
        }
    }

    public class DeviceSettings
    {
        public string DeviceName { get; set; }
        public int NrOfRegs { get; set; }
        public string Type { get; set; }
        public int UnitID { get; set; }
    }
}
