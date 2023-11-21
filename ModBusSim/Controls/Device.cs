﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModBusSim.Controls
{
    public class Device : UserControl
    {
        private int w = 250;
        private int h = 200;
        private int d = 10;

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
                Left = d + (position % 4) * (w+d);
                Top = d + (position / 4) * (h+d);
                Width = w;
                Height = h;
            }
        }
    }
}
