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
        public Room Room { get; set; }

        public RoomProperties(Room source)
        {
            InitializeComponent();
            txtColor.BackColor = source.Color;
            txtName.Text = source.Text;
            Room = source;
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            txtColor.BackColor = colorDialog1.Color;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Room.SetProperties(txtName.Text,txtColor.BackColor);
            Close();
        }
    }
}
