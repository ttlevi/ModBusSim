using System.Windows.Forms;

namespace ModBusSim.Controls
{
    public partial class Display : UserControl
    {
        private int address;

        public int Address
        {
            get { return address; }
            set { address = value; lblAddr.Text = address.ToString(); }
        }

        private int valueOfHoldingReg;

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
        }
    }
}
