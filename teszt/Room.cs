using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teszt
{
    public partial class Room : Form
    {
        public Color Color { get; set; } = Color.Black;
        public int Square { get; set; } = 100;
        public Form1 source { get; set; }
        public Room()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Room room = new Room();
            room.Color = Color;
            room.Square = Square;
            source.AddRoom(this);
        }
    }
}
