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
                for (int i = 1; i < 10; i++) { Console.Write($"{server.holdingRegisters[i]}, "); };
                Console.WriteLine();
            };

            server.CoilsChanged += (s, e) =>
            {
                Console.WriteLine($"A megváltozott coil regiszter száma: {s}");
                Console.WriteLine($"Értéke: {server.coils[s]}");
                for (int i = 1; i < 10; i++) { Console.Write($"{server.coils[i]}, "); };
                Console.WriteLine();
            };
        }

        private void newRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Room newroom = new Room();
            newroom.Show();
        }
    }
}
