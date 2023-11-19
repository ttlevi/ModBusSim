﻿using FluentModbus;
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
        }

        private void btnStartStop_Click(object sender, EventArgs e)
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
            
            //set register address of client (master)
            int raddr = int.Parse(txtRegAddr.Text);
            int unitid = int.Parse(txtUnitID.Text);

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
                    client.WriteSingleCoil(unitid, raddr-1, rval);
                }
                catch (Exception)
                {
                    MessageBox.Show("Check if you misspelled something and try again!", "Error");
                }
            }

            if (cboRegType.Text == "Holding Register")
            {
                short rval = short.Parse(txtRegVal.Text);
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
    }
}
