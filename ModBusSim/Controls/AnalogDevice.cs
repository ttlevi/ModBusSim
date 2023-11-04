using EasyModbus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModBusSim.Controls
{
    public partial class AnalogDevice : UserControl
    {
        ModbusServer server = new ModbusServer();
        public AnalogDevice()
        {
            InitializeComponent();
        }

        private void RefreshField()
        {
            ModbusServer newserver = new ModbusServer();
            newserver.Port = int.Parse(txtPort.Text);
            server = newserver;
            server.Listen();
            //catch (System.Net.Sockets.SocketException)
            //{
            //    MessageBox.Show("This port is already in use.","Error");
            //}

            server.HoldingRegistersChanged += (s, e) =>
            {
                foreach (Display disp in panel1.Controls)
                {
                    if (disp.Address == s) { disp.SetValue(server.holdingRegisters[s]); };
                }
            };

            panel1.Controls.Clear();

            int nr = int.Parse(cboNrOfRegs.Text);
            List<Display> displays = new List<Display>();
            for (int i = 1; i < nr + 1; i++)
            {
                Display disp = new Display();

                disp.Top = ((i - 1) / 5) * 30;
                disp.Left = 30 + ((i - 1) % 5) * 50;
                disp.Address = i;

                displays.Add(disp);
                panel1.Controls.Add(disp);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            RefreshField();
        }
    }
}
