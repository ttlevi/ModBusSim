using ModBusSim.Controls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ModBusTest.EasyModBus;
using System.Net;

namespace ModBusSim
{
    public partial class Building : Form
    {
        private int w = 200;
        private int h = 200;

        private List<Room> rooms = new List<Room>();
        public ModbusServerCluster Cluster { get; set; }
        public List<int> UnitIDsInUse { get; set; } = new List<int>();
        public Building()
        {
            InitializeComponent();
            Cluster = new ModbusServerCluster();
            Cluster.Port = 502;
            Cluster.Listen();

            Width = w;
            Height = h;

            WindowState = FormWindowState.Maximized;
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
