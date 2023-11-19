using FluentModbus;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ModBusSim.Controls
{
    public partial class DigitalDevice : Device
    {
        public List<bool> Coils { get; set; } = new List<bool>();
        public ModbusTcpServer tcpServer;
        public ModbusRtuServer rtuServer;

        private bool isconnected = false;
        public DigitalDevice()
        {
            InitializeComponent();
        }

        private void LoadCoils()
        {
            rtuServer = new ModbusRtuServer(byte.Parse(txtID.Text));
            rtuServer.Start($"COM{txtID.Text}");
            rtuServer.CoilsChanged += (s, e) =>
            {
                Console.WriteLine(e.Coils);
                //foreach (Led led in panel1.Controls)
                //{
                //    if (led.Text == e.Coils[s].ToString()) { led.Switch(true); };
                //}
            };

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
            {;
                LoadCoils();
                btnConnect.Enabled = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Room.RemoveDevice(this);
            rtuServer.Dispose();
        }
    }
}
