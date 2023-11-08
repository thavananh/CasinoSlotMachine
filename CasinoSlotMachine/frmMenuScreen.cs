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
            FormClosing += frmMenuScreen_FormClosing;
        }

        private bool isExiting = false;

        private void frmMenuScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isExiting)
            {
                DialogResult r = MessageBox.Show("Bạn có muốn thoát không ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r != DialogResult.No)
                {
                    isExiting = true;
                    Application.Exit(); // khi gọi hàm này nó gọi cả Event FormClosing lần nữa
                }
                else
                {
                    e.Cancel = true; // Ngăn form đóng nếu người dùng chọn "No"
                }
            }
        }

        private void glPlay_Click(object sender, EventArgs e)
        {

            FormClosing -= frmMenuScreen_FormClosing;
            this.Close();
            frmCasinoSlot casinoSlot = new frmCasinoSlot();
            casinoSlot.Show();
        }

        private void glHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("2 cột liên tiếp có hình giống nhau sẽ chiến thắng với số tiền thưởng = số cược * 1.1 và 3 cột có hình giống nhau liên tiếp sẽ chiến thắng với số tiền thưởng = số cược * 1.25", "Hướng dẫn", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void glCredit_Click(object sender, EventArgs e)
        {
            frmCredit credit = new frmCredit();
            credit.Show();
            this.Hide();
        }

        private void glQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
