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

namespace ModBusClient
{
    public partial class ModBusClient : Form
    {
        ModbusClient client;

        public ModBusClient()
        {
            InitializeComponent();
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (btnStartStop.Text == "Start")
            {
                btnStartStop.Text = "Stop";

                client = new ModbusClient();
                client.IPAddress = txtIPAddr.Text;
                client.Port =  int.Parse(txtPort.Text);
                client.Connect();
            }

            else
            {
                btnStartStop.Text = "Start";
                client = null;
            }
        }

        private void btnSetValue_Click(object sender, EventArgs e) {
            
            //set register address of client (master)
            int raddr = int.Parse(txtRegAddr.Text);

            if (cboRegType.Text == "Coil Output")
            {
                bool rval = false;
                if (txtRegVal.Text == "1" || txtRegVal.Text == "true")
                {
                    rval = true;
                }
                else if (txtRegVal.Text == "0" || txtRegVal.Text == "false")
                {
                    rval = false;
                }
                //else
                //{
                //    lblError.Text = "Érvénytelen érték!";
                //}
                client.WriteSingleCoil(raddr-1, rval);
            }

            if (cboRegType.Text == "Holding Register")
            {
                int rval = int.Parse(txtRegVal.Text);
                client.WriteSingleRegister(raddr-1, rval);
            }
        }
    }
}
