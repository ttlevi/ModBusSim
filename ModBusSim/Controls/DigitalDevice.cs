using EasyModBus;
using ModBusTest.EasyModBus;
using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Channels;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ModBusSim.Controls
{
    public partial class DigitalDevice : Device
    {
        private int d;

        public DigitalDevice()
        {
            InitializeComponent();

            d = DeviceDpi / 96 * 5;
        }

        private void LoadCoils()
        {
            // Adding a new Server instance to the Cluster

            UnitID = int.Parse(nuUnitID.Text);
            ModbusServerCluster cluster = Room.Building.Cluster;
            cluster.Add(int.Parse(nuUnitID.Text));
            Room.Building.UnitIDsInUse.Add(UnitID);

            // Loading the visual elements (Led) for the necessary coils

            nuUnitID.Enabled = false;
            cboNrOfRegs.Enabled = false;
            btnConnect.Enabled = false;
            panel1.Controls.Clear();
            int nr = int.Parse(cboNrOfRegs.Text);

            for (int i = 0; i < nr; i++)
            {
                Led led = new Led();

                led.Width = Width / 5 - (d + d / 5);
                led.Height = panel1.Height / 5 - d;

                led.Top = (i / 5) * (led.Height+d);
                led.Left = d + (i % 5) * (led.Width+d);

                led.Address = i+1;

                panel1.Controls.Add(led);
            }

            // Finding the Device in the Cluster list of the Building and setting up the event listener, that changes the values of Leds

            int j = 0;
            foreach (ModbusServer unit in cluster.Servers) {
                if (unit.UnitIdentifier == UnitID) { break; }
                j++;
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

        // Buttons to connect and remove the device

        private void btnConnect_Click(object sender, EventArgs e)
        {
            LoadCoils();            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Room.RemoveDevice(this);
            Room.Building.Cluster.Remove(UnitID);
            Room.Building.UnitIDsInUse.Remove(UnitID);
        }
    }
}
