using EasyModBus;
using ModBusTest.EasyModBus;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ModBusSim.Controls
{
    public partial class AnalogDevice : Device
    {
        public AnalogDevice()
        {
            InitializeComponent();
        }

        private void LoadHoldingRegs()
        {
            ModbusServerCluster cluster = Room.Building.Cluster;
            cluster.Add(int.Parse(nuUnitID.Text));
            UnitID = int.Parse(nuUnitID.Text);

            nuUnitID.Enabled = false;
            cboNrOfRegs.Enabled = false;
            btnConnect.Enabled = false;
            panel1.Controls.Clear();
            int nr = int.Parse(cboNrOfRegs.Text);

            for (int i = 0; i < nr; i++)
            {
                Display disp = new Display();
                disp.Top = (i / 5) * 30;
                disp.Left = (i % 5) * 50;
                disp.Address = i+1;
                disp.Value = 0;
                panel1.Controls.Add(disp);
            }

            int j = 0;
            foreach (ModbusServer unit in cluster.Servers)
            {
                if (unit.UnitIdentifier == UnitID) { break; }
                j++;
            }

            cluster.Servers[j].HoldingRegistersChanged += (int register, int numberOfRegisters) =>
            {
                int value = cluster.Servers[j].holdingRegisters[register];
                foreach (Display disp in panel1.Controls)
                {
                    if (disp.Address == register) {disp.SetValue(value); };
                }
            };
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            LoadHoldingRegs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Room.RemoveDevice(this);
            Room.Building.Cluster.Remove(int.Parse(nuUnitID.Text));
        }
    }
}
