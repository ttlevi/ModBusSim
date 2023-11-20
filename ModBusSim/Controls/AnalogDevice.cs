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

            //ide kell az rtu szerver

            txtUnitID.Enabled = false;
            cboNrOfRegs.Enabled = false;
            btnConnect.Enabled = false;
            panel1.Controls.Clear();
            int nr = int.Parse(cboNrOfRegs.Text);

            for (int i = 0; i < nr; i++)
            {
                Display disp = new Display();
                disp.Top = (i / 5) * 30;
                disp.Left = (i % 5) * 50;
                disp.Address = i;
                disp.Value = 0;
                panel1.Controls.Add(disp);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            LoadHoldingRegs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Room.RemoveDevice(this);
            Room.Building.Cluster.Remove(int.Parse(txtUnitID.Text));

            //ide jön a szerver dispose
        }
    }
}
