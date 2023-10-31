using EasyModbus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ModBusSim.Controls
{
    public partial class DigitalDevice : UserControl
    {
        public DigitalDevice()
        {
            InitializeComponent();
            RefreshField();

        }

        private void RefreshField()
        {
            panel1.Controls.Clear();

            int nr = int.Parse(cboNrOfRegs.Text);
            List<RadioButton> leds = new List<RadioButton>();
            for (int i = 1; i < nr+1; i++)
            {
                RadioButton led = new RadioButton();

                led.Text = i.ToString();
                led.Top = ((i-1)/5)*30;
                led.Left = ((i-1)%5)*50;
                led.Enabled = false;
                led.RightToLeft = RightToLeft.Yes;

                leds.Add(led);
                panel1.Controls.Add(led);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            RefreshField();
        }
    }
}
