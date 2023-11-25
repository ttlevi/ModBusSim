using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModBusSim.Controls
{

    // This class is an abstraction of the two kinds of devices, helps to set up the common parameters in one place.

    public class Device : UserControl
    {
        private int w;
        private int h;
        private int d;

        public Room Room { get; set; }
        public string DeviceName { get; set; }
        public int NrOfRegs { get; set; }
        public string Type { get; set; }

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

                w = Width;
                h = Height;
                d = DeviceDpi / 96 * 10;
                Left = d + (position % 4) * (w+d);
                Top = d + (position / 4) * (h+d);
                Width = w;
                Height = h;
            }
        }
    }
}
