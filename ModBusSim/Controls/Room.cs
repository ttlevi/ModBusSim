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
            this.Name = name;
            this.Text = name;
            this.BackColor = color;
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
            panel1.Controls.Add(digDiv);
        }
    }
}
