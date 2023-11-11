using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ModBusSim.Controls
{
    public partial class AnalogDevice : Device
    {
        public List<int> HoldingRegs { get; set; } = new List<int>();
        public AnalogDevice()
        {
            InitializeComponent();
        }

        private void LoadHoldingRegs()
        {

            //server.HoldingRegistersChanged += (s, e) =>
            //{
            //    foreach (Display disp in panel1.Controls)
            //    {
            //        if (disp.Address == s) { disp.SetValue(server.holdingRegisters[s]); };
            //    }
            //};

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

                HoldingRegs.Add(0);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            LoadHoldingRegs();
            btnConnect.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Room.RemoveDevice(this);
        }
    }
}
