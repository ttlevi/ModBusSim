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
        public DigitalDevice()
        {
            InitializeComponent();
        }

        private void LoadCoils()
        {
            UnitID = int.Parse(nuUnitID.Text);
            ModbusServerCluster cluster = Room.Building.Cluster;
            cluster.Add(int.Parse(nuUnitID.Text));
            Room.Building.UnitIDsInUse.Add(UnitID);

            nuUnitID.Enabled = false;
            cboNrOfRegs.Enabled = false;
            btnConnect.Enabled = false;
            panel1.Controls.Clear();
            int nr = int.Parse(cboNrOfRegs.Text);

            for (int i = 0; i < nr; i++)
            {
                Led led = new Led();
                led.Top = (i / 5) * 50;
                led.Left = 10 + (i % 5) * 95;
                led.Address = i+1;
                panel1.Controls.Add(led);
            }

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
