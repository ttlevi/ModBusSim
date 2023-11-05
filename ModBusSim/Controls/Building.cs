using EasyModbus;
using ModBusSim.Controls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ModBusSim
{
    public partial class Building : Form
    {
        private List<Room> rooms = new List<Room>();
        public Building()
        {
            InitializeComponent();

            ModbusServer server = new ModbusServer();
            server.Listen();

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

        public void LoadResources()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            
        }

        public void NewRoom(Room newroom)
        {
            if (!newroom.Exists) { newroom.Exists = true; rooms.Add(newroom); }
            LoadRooms();
        }

        public void RemoveRoom(Room newroom)
        {
            rooms.Remove(newroom);
            LoadRooms();
        }

        private void LoadRooms()
        {
            panel1.Controls.Clear();
            int nr = 0;
            foreach (Room room in rooms){
                UCRoom uc = new UCRoom(room);
                uc.Top = (nr / 5) * 90;
                uc.Left = (nr % 5) * 210;
                uc.BackColor = room.Color;
                uc.RoomName = room.Text;
                uc.Room = room;
                panel1.Controls.Add(uc);
                nr++;
            }
        }

        private void newRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Room newroom = new Room();
            newroom.Building = this;
            newroom.Show();
        }
    }
}
