using ModBusSim.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ModBusSim
{
    public partial class Room : Form
    {
        private Color roomcolor;
        public RoomProperties RoomProperties { get; set; }

        public Color Color
        {
            get { return roomcolor; }
            set { roomcolor = value; panel1.BackColor = Color; }
        }

        public List<Device> Devices { get; set; } = new List<Device>();
        public Building Building { get; set; }
        public bool Exists { get; set; } = false;

        public Room()
        {
            InitializeComponent();
            Color = panel1.BackColor;
            panel1.AutoScroll = true;
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void roomPropertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenRoomProperties();
        }

        private void digitalcoilDeviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DigitalDevice device = new DigitalDevice();
            device.Room = this;
            device.Position = Devices.Count;
            AddDevice(device);
        }

        private void analogholdingDeviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnalogDevice device = new AnalogDevice();
            device.Room = this;
            device.Position = Devices.Count;
            AddDevice(device);
        }

        public void SaveRoom()
        {
            SetDevicePositions();
            Building.RefreshRoomDisplays(this);
        }

        public void SetDevicePositions()
        {
            int nr = 0;
            foreach (Device device in panel1.Controls)
            {
                device.Position = nr;
                nr++;
            }
        }

        private void OpenRoomProperties()
        {
            RoomProperties roomProperties = new RoomProperties();
            roomProperties.Room = this;
            roomProperties.TopMost = true;
            roomProperties.Show();
        }

        private void AddDevice(Device device)
        {
            panel1.Controls.Add(device);
            Devices.Add(device);
            for (int i = 1; i < 255; i++)
            {
                if (!Building.UnitIDsInUse.Contains(i)) { device.UnitID = i; break; }
            }
            SaveRoom();
        }

        public void RemoveDevice(Device toremove)
        {
            Devices.Remove(toremove);
            panel1.Controls.Remove(toremove);
            SetDevicePositions();
            SaveRoom();
        }

        private void Room_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveRoom();
            e.Cancel = true;
            this.Visible = false;
            RoomProperties.Close();
        }

        private void Room_Load(object sender, EventArgs e)
        {
            OpenRoomProperties();
        }
    }
}
