using System.Windows.Forms;

namespace ModBusSim.Controls
{
    public partial class Display : UserControl
    {
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
        }

        public void SetLabelsLayout() {
            lblAddr.Top = 0;
            lblValue.Top = 0;

            lblAddr.Left = 0;
            lblAddr.Width = Width / 2;

            lblValue.Left = Width / 2;
            lblValue.Width = Width / 2;

            lblAddr.Height = Height;
            lblValue.Height = Height;
        }
    }
}
