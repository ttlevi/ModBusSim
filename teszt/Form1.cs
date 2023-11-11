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
    public partial class Form1 : Form
    {
        private List<Room> rooms = new List<Room>();
        public Form1()
        {
            InitializeComponent();  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Room room in rooms) { Console.WriteLine(room.Square); Console.WriteLine(room.Color); };
        }

        public void AddRoom(Room room)
        {
            rooms.Add(room);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Room room = new Room();
            room.source = this;
            room.Show();
        }
    }
}
