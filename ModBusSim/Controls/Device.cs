using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModBusSim.Controls
{
    public class Device : UserControl
    {
        public Room Room { get; set; }
        public int UnitID { get; set; }
        private int position;

        public int Position
        {
            get { return position; }
            set {
                position = value;
                Left = 10 + (position % 5) * 260;
                Top = 10 + (position / 5) * 230;
            }
        }
    }
}
