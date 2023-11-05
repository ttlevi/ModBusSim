using ModBusSim.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ModBusSim
{
    public partial class Room : Form
    {
        public Color Color { get; set; } = Color.Gray;
        public List<Device> Devices { get; set; } = new List<Device>();
        public Building Building { get; set; }
        public bool Exists { get; set; } = false;

        public Room()
        {
            InitializeComponent();
        }

        private void OpenRoomProperties()
        {
            RoomProperties roomProperties = new RoomProperties(this);
            roomProperties.TopMost = true;
            roomProperties.Show();
        }

        public void SetProperties(string name, Color color)
        {
            Name = name;
            Text = name;
            panel1.BackColor = color;
            Color = color;
        }

        private void AddDevice(Device device, int nr)
        {
            device.Left = 10+(nr % 5) * 260;
            device.Top = 10+(nr / 5) * 230;
            panel1.Controls.Add(device);
            Devices.Add(device);
        }

        private void Room_Load(object sender, EventArgs e)
        {
            if (!Exists) { OpenRoomProperties();  };
            foreach (Device device in Devices) { AddDevice(device, device.Position); };
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
            AddDevice(device,device.Position);
        }

        private void analogholdingDeviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnalogDevice device = new AnalogDevice();
            device.Room = this;
            device.Position = Devices.Count;
            AddDevice(device, device.Position);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int nr = 0;
            foreach (Device device in panel1.Controls)
            {
                device.Position = nr;
                nr++;
            }
            Building.NewRoom(this);
        }
    }
}
