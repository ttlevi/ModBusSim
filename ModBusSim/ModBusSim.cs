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
    public partial class ModBusSim : Form
    {
        public ModBusSim()
        {
            InitializeComponent();

            ModbusServer server = new ModbusServer();
            server.UDPFlag = false;
            server.Listen();

            ModbusClient client = new ModbusClient();
            client.IPAddress = "127.0.0.1";
            client.Connect();

            server.HoldingRegistersChanged += (s, e) =>
            {
                Console.WriteLine($"A megváltozott holding regiszter száma: {e}");
                Console.WriteLine($"Értéke: {server.holdingRegisters[e]}");
            };

            server.CoilsChanged += (s, e) =>
            {
                Console.WriteLine($"A meváltozott coil regiszter száma: {e}");
                Console.WriteLine($"Értéke: {server.coils[e]}");

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
