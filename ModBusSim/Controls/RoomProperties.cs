using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModBusSim.Controls
{
    public partial class RoomProperties : Form
    {
        private Room room;

        public Room Room
        {
            get { return room; }
            set { room = value; txtColor.BackColor = Room.Color; txtName.Text = Room.Text; Room.RoomProperties = this; }
        }

        public RoomProperties()
        {
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            txtColor.BackColor = colorDialog1.Color;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Room.Text = txtName.Text;
            Room.Color = txtColor.BackColor;
            Room.SaveRoom();
            Close();
        }

        private void RoomProperties_FormClosing(object sender, FormClosingEventArgs e)
        {
            Room.SaveRoom();
        }
    }
}
