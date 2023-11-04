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
    public partial class Room : Form
    {
        int nrOfDevices = 0;
        private ServerSim ServerSim;
        public Room(ServerSim serverSim)
        {
            InitializeComponent();
            ServerSim = serverSim;
        }

        private void OpenRoomProperties()
        {
            RoomProperties roomProperties = new RoomProperties(this);
            roomProperties.TopMost = true;
            roomProperties.Show();
        }

        public void SetProperties(string name, Color color)
        {
            this.Name = name;
            this.Text = name;
            this.BackColor = color;
        }

        private void AddNewDevice(UserControl device)
        {
            device.Left = ((nrOfDevices) % 5) * 310;
            device.Top = ((nrOfDevices) / 5) * 220;
            nrOfDevices += 1;
            panel1.Controls.Add(device);
        }

        private void Room_Load(object sender, EventArgs e)
        {
            OpenRoomProperties();
        }

        private void roomPropertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenRoomProperties();
        }

        private void digitalcoilDeviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DigitalDevice digDiv = new DigitalDevice();
            AddNewDevice(digDiv);
        }

        private void analogholdingDeviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnalogDevice analogDiv = new AnalogDevice();
            AddNewDevice(analogDiv);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ServerSim.NewRoom(this);
        }
    }
}
