using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ModBusSim.Controls
{
    public partial class DigitalDevice : Device
    {
        public List<bool> Coils { get; set; } = new List<bool>();

        private bool isconnected = false;
        public DigitalDevice()
        {
            InitializeComponent();
        }

        private void AddDevice()
        {
            //server.CoilsChanged += (s, e) =>
            //{
            //    foreach (Led led in panel1.Controls) {
            //        if (led.Text == s.ToString()) { led.Switch(server.coils[s]); };
            //    }
            //};

            panel1.Controls.Clear();
            int nr = int.Parse(cboNrOfRegs.Text);

            for (int i = 0; i < nr; i++)
            {
                Led led = new Led();
                led.Text = i.ToString();
                led.Top = (i / 5) * 30;
                led.Left = 10 + (i % 5) * 50;
                panel1.Controls.Add(led);

                Coils.Add(false);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!isconnected)
            {
                btnConnect.Text = "Disconnect";
                AddDevice();
            }
        }
    }
}
