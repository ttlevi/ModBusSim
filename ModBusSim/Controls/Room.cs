using ModBusSim.Controls;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ModBusSim
{
    // This class defines a Room with Devices is your Building

    [Serializable]
    public partial class Room : Form
    {
        private Color roomcolor;
        public RoomProperties RoomProperties { get; set; }

        public Color Color
        {
            get { return roomcolor; }
            set { roomcolor = value; panelRoom.BackColor = Color; }
        }

        public List<Device> Devices { get; set; } = new List<Device>();
        public Building Building { get; set; }
        public bool Exists { get; set; } = false;

        public Room(bool presaved)
        {
            InitializeComponent();

            this.Color = Color.LightGray;

            if (!presaved) { OpenRoomProperties(); }
        }

        private void roomPropertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenRoomProperties();
        }

        private void addDeviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Creating new Device

            Device device = new Device();
            device.Room = this;
            device.Position = Devices.Count;
            AddDevice(device,false);
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
            foreach (Device device in panelRoom.Controls)
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

        public void AddDevice(Device device, bool presaved)
        {
            // Adding the given Device to the screen

            panelRoom.Controls.Add(device);
            
            if (!presaved) {
                Devices.Add(device);
                for (int i = 1; i < 255; i++)
                {
                    if (!Building.UnitIDsInUse.Contains(i))
                    {
                        device.UnitID = i;
                        Building.UnitIDsInUse.Add(i);
                        break;
                    }
                }
            }
            else
            {
                Building.UnitIDsInUse.Add(device.UnitID);
            }
            
            SaveRoom();
        }

        public void RemoveDevice(Device toremove)
        {
            // Removing the given Device from everywhere and resetting the control positions

            Devices.Remove(toremove);
            panelRoom.Controls.Remove(toremove);
            SetDevicePositions();
            SaveRoom();
        }

        private void Room_FormClosing(object sender, FormClosingEventArgs e)
        {
            // To prevent the Room from disposing when closed

            SaveRoom();
            e.Cancel = true;
            this.Visible = false;
            if (RoomProperties != null) { RoomProperties.Close(); }
        }

        public RoomSettings ToRoomSettings()
        {
            RoomSettings roomSettings = new RoomSettings()
            {
                Text = this.Text,
                Color = this.Color.ToArgb(),
                Exists = this.Exists
            };

            roomSettings.Devices = new List<DeviceSettings>();

            foreach (Device device in panelRoom.Controls) { roomSettings.Devices.Add(device.ToDeviceSetting()); }

            return roomSettings;
        }

        public static Room FromRoomSettings(RoomSettings roomSettings)
        {
            Room room = new Room(true);
            room.Text = roomSettings.Text;
            room.Color = Color.FromArgb(roomSettings.Color);
            room.Exists = roomSettings.Exists;
            
            foreach (DeviceSettings device in roomSettings.Devices) {
                room.Devices.Add(Device.FromDeviceSettings(device));
            }

            return room;
        }
    }

    public class RoomSettings
    {
        public string Text { get; set; }
        public int Color { get; set; }
        public List<DeviceSettings> Devices { get; set; }
        public bool Exists { get; set; }
    }
}
