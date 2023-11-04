using EasyModbus;
using ModBusSim.Controls;
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
        public ModbusServer server { get; set; }
        private List<Room> rooms = new List<Room>();
        public ServerSim()
        {
            InitializeComponent();

            //server = new ModbusServer();
            //server.UDPFlag = false;
            //server.Port = 502;
            //server.Listen();

            //server.HoldingRegistersChanged += (s, e) =>
            //{
            //    Console.WriteLine($"A megváltozott holding regiszter száma: {s}");
            //    Console.WriteLine($"Értéke: {server.holdingRegisters[s]}");
            //    for (int i = 1; i < 10; i++) { Console.Write($"{server.holdingRegisters[i]}, "); };
            //    Console.WriteLine();
            //};

            //server.CoilsChanged += (s, e) =>
            //{
            //    Console.WriteLine($"A megváltozott coil regiszter száma: {s}");
            //    Console.WriteLine($"Értéke: {server.coils[s]}");
            //    for (int i = 1; i < 10; i++) { Console.Write($"{server.coils[i]}, "); };
            //    Console.WriteLine();
            //};
        }

        public void NewRoom(Room newroom)
        {
            rooms.Add(newroom);
            int nr = rooms.Count;
            UCRoom uc = new UCRoom();
            uc.Top = ((nr - 1) / 8) * 90;
            uc.Left = ((nr - 1) % 8) * 210;
            uc.BackColor = newroom.BackColor;
            uc.RoomName = newroom.Text;
            panel1.Controls.Add(uc);
        }

        private void newRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Room newroom = new Room(this);
            newroom.Show();
        }
    }
}
