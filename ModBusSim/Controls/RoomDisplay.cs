using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ModBusSim.Controls
{
    public partial class RoomDisplay : UserControl
    {
        private int w = 200;
        private int h = 60;
        private int d = 10;

        private int nrOfDig;
        private int nrOfAn;
        private int position;

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
                Width = w;
                Height = h;
            }
        }

        public RoomDisplay()
        {
            InitializeComponent();
        }

        public void SetPropOfRoomDisplay(Room source)
        {
            Room = source;
            BackColor = source.Color;
            lblName.Text = source.Text;
            NrOfAn = 0;
            NrOfDig = 0;
            foreach (Device device in Room.Devices)
            {
                if (device is AnalogDevice) { NrOfAn++; }
                else { NrOfDig++; }
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            Room.Visible = true;
            Room.TopMost = true;
            Room.WindowState = FormWindowState.Normal;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Building.RemoveRoom(Room);
        }
    }
}
