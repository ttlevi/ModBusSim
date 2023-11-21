using System.Windows.Forms;

namespace ModBusSim.Controls
{
    public partial class Display : UserControl
    {
        public int w = 40;
        public int h = 15;

        private int address;
        private int valueOfHoldingReg;

        public int Address
        {
            get { return address; }
            set { address = value; lblAddr.Text = address.ToString(); }
        }

        public int Value
        {
            get { return valueOfHoldingReg; }
            set { valueOfHoldingReg = value;
                if (lblValue.InvokeRequired)
                {
                    this.Invoke((MethodInvoker)delegate { lblValue.Text = value.ToString(); });
                }
                else
                {
                    lblValue.Text = value.ToString();
                }
            }
        }

        public Display()
        {
            InitializeComponent();
            Width = w;
            Height = h;
            lblAddr.Height = h;
            lblValue.Height = h;
            lblAddr.Width = w / 3;
            lblValue.Left = w / 3 + 3;
            lblValue.Width = w / 3 * 2;
        }
    }
}
