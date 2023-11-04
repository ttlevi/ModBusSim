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
        private string roomNAme;

        public string RoomName
        {
            get { return roomNAme; }
            set { roomNAme = value; lblName.Text = RoomName; }
        }

        public UCRoom()
        {
            InitializeComponent();
        }
    }
}
