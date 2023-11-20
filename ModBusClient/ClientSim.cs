using FluentModbus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModBusClient
{
    public partial class ModBusClient : Form
    {
        ModbusTcpClient client = new ModbusTcpClient();

        public ModBusClient()
        {
            InitializeComponent();
            RefreshClient();
            RefreshControls();
        }

        private void RefreshControls()
        {
            if (rbtnCoil.Checked) {chCoilVal.Visible = true; nuRegVal.Visible = false; }
            else { chCoilVal.Visible = false; nuRegVal.Visible = true; }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshClient();
        }

        private void RefreshClient()
        {
            try
            {
                client.Connect(new IPEndPoint(IPAddress.Parse(txtIPAddr.Text), int.Parse(txtPort.Text)));
            }
            catch (Exception)
            {
                MessageBox.Show("There's no ModBus server available on this port. Try another IP Address or Port Number.", "Error");
            }
        }

        private void btnSetValue_Click(object sender, EventArgs e) {

            int raddr = int.Parse(nuRegAddr.Text);
            int unitid = int.Parse(nuUnitID.Text);

            if (rbtnCoil.Checked)
            {
                bool rval = false;
                if (chCoilVal.Checked) { rval = true; }

                try
                {
                    client.WriteSingleCoil(unitid, raddr-1, rval);
                }
                catch (Exception)
                {
                    MessageBox.Show("Check if you misspelled something and try again!", "Error");
                }
            }

            if (rbtnHoldingReg.Checked)
            {
                short rval = short.Parse(nuRegVal.Text);
                try
                {
                    client.WriteSingleRegister(unitid, raddr - 1, rval);
                }
                catch (Exception)
                {
                    MessageBox.Show("Check if you misspelled something and try again!", "Error");
                }
            }
        }

        private void rbtnCoil_CheckedChanged(object sender, EventArgs e)
        {
            RefreshControls();
        }
    }
}
