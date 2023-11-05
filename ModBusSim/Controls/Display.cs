using System.Windows.Forms;

namespace ModBusSim.Controls
{
    public partial class Display : UserControl
    {
        private int address;

        public int Address
        {
            get { return Address; }
            set { address = value; lblAddr.Text = address.ToString(); }
        }

        private int holdingValue;

        public int Value
        {
            get { return holdingValue; }
            set { holdingValue = value; lblValue.Text = holdingValue.ToString(); }
        }


        public Display()
        {
            InitializeComponent();
        }
    }
}
