using System.Drawing;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace ModBusSim.Controls
{
    public class Led : Label
    {
        private int address;
        private bool valueOfCoil;

        // Property for Coil Address
        public int Address
        {
            get { return address; }
            set { address = value; Text = address.ToString(); }
        }

        // Property for Coil Value
        public bool Value
        {
            get { return valueOfCoil; }
            set {
                valueOfCoil = value;
                if (value) { BackColor = Color.Green; }
                else { BackColor = Color.Red; }
            }
        }

        // Constructor sets up the visuals of the label
        public Led()
        {
            TextAlign = ContentAlignment.MiddleCenter;
            BackColor = Color.Red;
            ForeColor = Color.White;
        }
    }
}
