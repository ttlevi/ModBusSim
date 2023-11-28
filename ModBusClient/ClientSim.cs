using EasyModbus;
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
    public partial class ModbusClientForm : Form
    {
        ModbusClient client = new ModbusClient();

        public ModbusClientForm()
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
                client.Connect(txtIPAddr.Text, int.Parse(txtPort.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("There's no ModBus server available on this port. Try another IP Address or Port Number.",
                    "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnSetValue_Click(object sender, EventArgs e) {

            try
            {
                client.UnitIdentifier = (byte)nuUnitID.Value;

                if (rbtnCoil.Checked)
                {
                    client.WriteSingleCoil((int)nuRegAddr.Value - 1, chCoilVal.Checked);
                }
                else
                {
                    client.WriteSingleRegister((int)nuRegAddr.Value - 1, (int)nuRegVal.Value);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("There's no device connected with the given UnitID, or it's connection is not yet established. Try again, or try a different UnitID.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbtnCoil_CheckedChanged(object sender, EventArgs e)
        {
            RefreshControls();
        }
    }
}
