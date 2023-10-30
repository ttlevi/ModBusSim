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

namespace ModBusSim
{
    public partial class ServerSim : Form
    {
        public ServerSim()
        {
            InitializeComponent();

            ModbusServer server = new ModbusServer();
            server.UDPFlag = false;
            server.Listen();

            server.HoldingRegistersChanged += (s, e) =>
            {
                Console.WriteLine($"A megváltozott holding regiszter száma: {s}");
                Console.WriteLine($"Értéke: {server.holdingRegisters[s]}");
            };

            server.CoilsChanged += (s, e) =>
            {
                Console.WriteLine($"A megváltozott coil regiszter száma: {s}");
                Console.WriteLine($"Értéke: {server.coils[s]}");

            };

            server.LogDataChanged += () =>
            {
            };

            server.NumberOfConnectedClientsChanged += () =>
            {
                //label1.Text= server.NumberOfConnections.ToString();
            };
        }

        private void ModBusSim_Load(object sender, EventArgs e)
        {
            
        }
    }
}
