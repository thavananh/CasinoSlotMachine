using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasinoSlotMachine
{
    public partial class frmCredit : Form
    {
        public frmCredit()
        {
            InitializeComponent();
        }

        bool isExiting = false;

        // xuất messagebox và có lựa chọn yes no
        private void frmCredit_FormClosing(object sender, FormClosingEventArgs e)
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

        private void glDuy_Click(object sender, EventArgs e)
        {
            var process = new ProcessStartInfo("C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe");
            string urlFacebook = @"https://www.facebook.com/profile.php?id=100015450043466";
            process.Arguments = urlFacebook;
            System.Diagnostics.Process.Start(urlFacebook);
        }

        private void glMinhTam_Click(object sender, EventArgs e)
        {
            // tìm trình duyệt chrome
            var process = new ProcessStartInfo("C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe");
            string urlFacebook = @"https://www.facebook.com/minhtam.lau";
            process.Arguments = urlFacebook; // chỉ đường dẫn web vào chrome
            System.Diagnostics.Process.Start(process); // chạy toàn bộ process trên
        }

        private void glThich_Click(object sender, EventArgs e)
        {
            var process = new ProcessStartInfo("C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe");
            string urlFacebook = @"https://www.facebook.com/cucshitmauhong";
            process.Arguments = urlFacebook;
            System.Diagnostics.Process.Start(urlFacebook);
        }

        private void glDaiTam_Click(object sender, EventArgs e)
        {
            var process = new ProcessStartInfo("C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe");
            string urlFacebook = @"https://www.facebook.com/lqdai.tom.2003/";
            process.Arguments = urlFacebook;
            System.Diagnostics.Process.Start(urlFacebook);
        }

        private void glNguyen_Click(object sender, EventArgs e)
        {
            var process = new ProcessStartInfo("C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe");
            string urlFacebook = @"https://www.facebook.com/cubonll";
            process.Arguments = urlFacebook;
            System.Diagnostics.Process.Start(urlFacebook);
        }

        private void btnGameMenu_Click(object sender, EventArgs e)
        {
            frmMenuScreen menu = new frmMenuScreen(); // tạo một instance của frmMenuScreen
            FormClosing -= frmCredit_FormClosing; // Loại bỏ messagebox để khi chuyển đổi ứng dụng, tắt form credit không bị nhảy thông báo lên
            this.Close();
            menu.Show(); // gọi form menu
        }
    }
}
