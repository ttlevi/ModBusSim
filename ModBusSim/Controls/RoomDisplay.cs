using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ModBusSim.Controls
{
    public partial class RoomDisplay : UserControl
    {
        // Variables for width, height and distance
        private int w;
        private int h;
        private int d;

        // Variables for device info
        private int nrOfDig;
        private int nrOfAn;
        private int position;

        // Properties for the RoomDisplays Room and Building relation
        public Room Room { get; set; }
        public Building Building { get; set; }

        public int NrOfAn
        {
            get { return nrOfAn; }
            set { nrOfAn = value; lblNrOfAn.Text = nrOfAn.ToString(); }
        }

        public int NrOfDig
        {
            get { return nrOfDig; }
            set { nrOfDig = value; lblNrOfDig.Text = nrOfDig.ToString(); }
        }

        public int Position
        {
            get { return position; }
            set
            {
                position = value;
                Left = (position % 5) * (w+d);
                Top = (position / 5) * (h+d);
            }
        }

        public RoomDisplay()
        {
            InitializeComponent();

            w = Width;
            h = Height;
            d = DeviceDpi / 96 * 10;
        }

        public void SetPropOfRoomDisplay(Room source)
        {
            // Set up RoomDisplay visuals and Room relation

            Room = source;
            BackColor = source.Color;
            lblName.Text = source.Text;
            NrOfAn = 0;
            NrOfDig = 0;
            foreach (Device device in Room.Devices)
            {
                if (device.IsDigital) { NrOfDig++; }
                else { NrOfAn++; }
            }
        }

        // Buttons to open and remove Room instance
        private void btnOpen_Click(object sender, EventArgs e)
        {
            Room.Visible = true;
            Room.Activate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Building.RemoveRoom(Room);
        }
    }
}
