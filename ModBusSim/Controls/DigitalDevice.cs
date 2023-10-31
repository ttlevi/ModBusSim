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
            int nr = int.Parse(cboNrOfRegs.Text);

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            RefreshField();
        }
    }
}
