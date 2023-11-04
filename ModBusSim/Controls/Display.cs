using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace ModBusSim.Controls
{
    public class Display : Label
    {
        public int Address { get; set; }
        public Display()
        {
            Text = "0";
            Width = 45;
            Height = 15;
            BackColor = Color.Black;
            ForeColor = Color.White;
        }
        public void SetValue(int value)
        {
            this.Invoke((MethodInvoker)(() => this.Text = value.ToString()));
        }
    }
}
