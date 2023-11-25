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
            OpenRoomProperties();
        }

        private void roomPropertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenRoomProperties();
        }

        private void digitalcoilDeviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Creating new DigitalDevice

            DigitalDevice device = new DigitalDevice();
            device.Room = this;
            device.Position = Devices.Count;
            AddDevice(device);
        }

        private void analogholdingDeviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Creating new AnalogDevice

            AnalogDevice device = new AnalogDevice();
            device.Room = this;
            device.Position = Devices.Count;
            AddDevice(device);
        }

        public void SaveRoom()
        {
            // Setting the proper Device positions and RoomDisplay properties on the screen

            SetDevicePositions();
            Building.RefreshRoomDisplays(this);
        }

        public void SetDevicePositions()
        {
            // Resetting the Device positions

            int nr = 0;
            foreach (Device device in panel1.Controls)
            {
                device.Position = nr;
                nr++;
            }
        }

        private void OpenRoomProperties()
        {
            // Opening new RoomProperties window

            RoomProperties roomProperties = new RoomProperties();
            roomProperties.Room = this;
            roomProperties.TopMost = true;
            roomProperties.Show();
        }

        private void AddDevice(Device device)
        {
            // Adding the given Device to the screen and to the Devices list property of the room

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
            // Removing the given Device from everywhere and resetting the control positions

            Devices.Remove(toremove);
            panel1.Controls.Remove(toremove);
            SetDevicePositions();
            SaveRoom();
        }

        private void Room_FormClosing(object sender, FormClosingEventArgs e)
        {
            // To prevent the Room from dispatching when closed

            SaveRoom();
            e.Cancel = true;
            this.Visible = false;
            RoomProperties.Close();
        }
    }
}
