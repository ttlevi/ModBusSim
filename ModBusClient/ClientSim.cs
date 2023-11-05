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
            RefreshClient();
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            RefreshClient();
        }

        private void RefreshClient()
        {
            client = new ModbusClient();
            client.IPAddress = txtIPAddr.Text;
            client.UnitIdentifier = byte.Parse(txtUnitID.Text);
            client.Port = int.Parse(txtPort.Text);

            try
            {
                client.Connect();
            }
            catch (Exception)
            {
                MessageBox.Show("There's no ModBus client connected to this port. Try another IP Address or Port Number.", "Error");
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
                try
                {
                    client.WriteSingleCoil(raddr-1, rval);
                }
                catch (Exception)
                {
                    MessageBox.Show("Check if you misspelled something and try again!", "Error");
                }
            }

            if (cboRegType.Text == "Holding Register")
            {
                int rval = int.Parse(txtRegVal.Text);
                try
                {
                    client.WriteSingleRegister(raddr - 1, rval);
                }
                catch (Exception)
                {
                    MessageBox.Show("Check if you misspelled something and try again!", "Error");
                }
            }
        }
    }
}
