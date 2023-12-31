﻿using EasyModBus;
using ModBusTest.EasyModBus;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ModBusSim.Controls
{
    public partial class AnalogDevice : Device
    {
        private int d;

        public AnalogDevice()
        {
            InitializeComponent();

            d = DeviceDpi / 96 * 5;
        }

        private void LoadHoldingRegs()
        {
            UnitID = int.Parse(nuUnitID.Text);
            ModbusServerCluster cluster = Room.Building.Cluster;
            cluster.Add(UnitID);
            Room.Building.UnitIDsInUse.Add(UnitID);

            nuUnitID.Enabled = false;
            cboNrOfRegs.Enabled = false;
            btnConnect.Enabled = false;
            panel1.Controls.Clear();
            int nr = int.Parse(cboNrOfRegs.Text);

            for (int i = 0; i < nr; i++)
            {
                Display disp = new Display();

                disp.Width = (Width - 2*d) / 5;
                disp.Height = panel1.Height / 5 - d;

                disp.Top = (i / 5) * (disp.Height + d);
                disp.Left = d + (i % 5) * disp.Width;
                disp.SetLabelsLayout();

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
                int value = cluster.Servers[j].holdingRegisters[register] / 256;
                foreach (Display disp in panel1.Controls)
                {
                    if (disp.Address == register) {disp.Value = value; };
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
            Room.Building.Cluster.Remove(UnitID);
            Room.Building.UnitIDsInUse.Remove(UnitID);
        }
    }
}
