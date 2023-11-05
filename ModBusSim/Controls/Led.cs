using System.Drawing;
using Label = System.Windows.Forms.Label;

namespace ModBusSim.Controls
{
    public class Led : Label
    { 
        public Led()
        {
            Width = 20;
            Height = 20;
            TextAlign = ContentAlignment.MiddleCenter;
            BackColor = Color.Red;
            ForeColor = Color.White;
        }
        public void Switch(bool value)
        {
            if (value)
            {
                BackColor = Color.Green;
            }
            else
            {
                BackColor = Color.Red;
            }
        }
    }
}
