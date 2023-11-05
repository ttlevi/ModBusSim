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
    public partial class UCRoom : UserControl
    {
        private string roomName;
        private int nrOfDig;
        private int nrOfAn;
        public Room Room { get; set; }

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

        public string RoomName
        {
            get { return roomName; }
            set { roomName = value; lblName.Text = RoomName; }
        }

        public UCRoom(Room source)
        {
            InitializeComponent();
            Room = source;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            Room room = new Room();
            room.Devices = Room.Devices;
            room.Exists = Room.Exists;
            room.Building = Room.Building;
            room.SetProperties(Room.Name, Room.Color);
            room.Show();
        }
    }
}
