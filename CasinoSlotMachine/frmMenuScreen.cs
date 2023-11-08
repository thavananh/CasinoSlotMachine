using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasinoSlotMachine
{
    public partial class frmMenuScreen : Form
    {
        public frmMenuScreen()
        {
            InitializeComponent();
        }

        private void glPlay_Click(object sender, EventArgs e)
        {
            frmCasinoSlot casinoSlot = new frmCasinoSlot();
            casinoSlot.Show();
            this.Hide();
        }

        private void glHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("2 cột liên tiếp có hình giống nhau sẽ chiến thắng với số tiền thưởng = số cược * 1.1 và 3 cột có hình giống nhau liên tiếp sẽ chiến thắng với số tiền thưởng = số cược * 1.25", "Hướng dẫn", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void glCredit_Click(object sender, EventArgs e)
        {

        }

        private void glQuit_Click(object sender, EventArgs e)
        {
        }
    }
}
