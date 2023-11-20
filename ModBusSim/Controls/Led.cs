using System.Drawing;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace ModBusSim.Controls
{
    public class Led : Label
    {
        private int address;
        private bool valueOfCoil;

        public bool Value
        {
            get { return valueOfCoil; }
            set {
                valueOfCoil = value;
                if (value) { BackColor = Color.Green; }
                else { BackColor = Color.Red; }
            }
        }


        public int Address
        {
            get { return address; }
            set { address = value; Text = address.ToString(); }
        }

        public Led()
        {
            Width = 80;
            Height = 30;
            TextAlign = ContentAlignment.MiddleCenter;
            BackColor = Color.Red;
            ForeColor = Color.White;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Led
            // 
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(0, 0);
            this.ResumeLayout(false);

        }
    }
}
