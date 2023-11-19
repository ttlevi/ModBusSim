using FluentModbus;
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

            ModbusTcpServer server = new ModbusTcpServer();
            server.Start();

            server.CoilsChanged += (s, regAddresses) =>
            {
                Console.WriteLine(regAddresses.Coils[0].ToString());
            };

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

        public void RefreshRoomDisplays(Room newroom)
        {
            if (!newroom.Exists) { newroom.Exists = true; rooms.Add(newroom); }
            int nr = 0;
            foreach (RoomDisplay disp in panel1.Controls)
            {
                disp.SetPropOfRoomDisplay(disp.Room);
                disp.Position = nr;
                nr++;
            }
        }

        private void newRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Room newroom = new Room();
            RoomDisplay disp = new RoomDisplay();
            disp.Room = newroom;
            disp.Building = this;
            panel1.Controls.Add(disp);
            RefreshRoomDisplays(disp.Room);
            newroom.Building = this;
            newroom.Show(); 
        }

        public void RemoveRoom(Room toremove)
        {
            toremove.Close();
            toremove.Dispose();
            rooms.Remove(toremove);
            foreach (RoomDisplay disp in panel1.Controls)
            {
                if (disp.Room == toremove) { panel1.Controls.Remove(disp); }
                RefreshRoomDisplays(disp.Room);
            }

        }
    }
}
