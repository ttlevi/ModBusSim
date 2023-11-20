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

        public int Value { get; set; }


        public Display()
        {
            InitializeComponent();
        }

        public void SetValue(int value)
        {
            lblValue.Text = value.ToString();
        }
    }
}
