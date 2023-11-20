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

        private int unitID;

        public int UnitID
        {
            get { return unitID; }
            set { unitID = value;
                foreach (Control o in Controls) { if (o is NumericUpDown) { o.Text = UnitID.ToString(); } }
            }
        }

        private int position;

        public int Position
        {
            get { return position; }
            set {
                position = value;
                Left = 20 + (position % 4) * 520;
                Top = 20 + (position / 4) * 420;
            }
        }
    }
}
