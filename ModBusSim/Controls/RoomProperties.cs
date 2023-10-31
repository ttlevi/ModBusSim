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
        private Room sourceRoom;
        public RoomProperties(Room sourceRoom)
        {
            InitializeComponent();
            this.sourceRoom = sourceRoom;
            txtColor.BackColor = sourceRoom.BackColor;
            txtName.Text = sourceRoom.Text;
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            txtColor.BackColor = colorDialog1.Color;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            sourceRoom.SetProperties(txtName.Text,txtColor.BackColor);
            Close();
        }
    }
}
