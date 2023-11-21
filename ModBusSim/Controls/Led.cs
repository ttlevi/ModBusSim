using System.Drawing;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace ModBusSim.Controls
{
    public class Led : Label
    {
        public int w = 40;
        public int h = 15;

        private int address;
        private bool valueOfCoil;

        public int Address
        {
            get { return address; }
            set { address = value; Text = address.ToString(); }
        }

        public bool Value
        {
            get { return valueOfCoil; }
            set {
                valueOfCoil = value;
                if (value) { BackColor = Color.Green; }
                else { BackColor = Color.Red; }
            }
        }

        public Led()
        {
            Width = w;
            Height = h;
            TextAlign = ContentAlignment.MiddleCenter;
            BackColor = Color.Red;
            ForeColor = Color.White;
        }
    }
}
