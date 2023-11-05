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
        public int Position { get; set; }
    }
}
