using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
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

        private void glDuy_Click(object sender, EventArgs e)
        {
            var process = new ProcessStartInfo("C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe");
            string urlFacebook = "https://www.facebook.com/profile.php?id=100015450043466";
            process.Arguments = urlFacebook;
            System.Diagnostics.Process.Start(urlFacebook);
        }

        private void glMinhTam_Click(object sender, EventArgs e)
        {
            var process = new ProcessStartInfo("C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe");
            string urlFacebook = "https://www.facebook.com/minhtam.lau";
            process.Arguments = urlFacebook;
            System.Diagnostics.Process.Start(process);
        }

        private void glThich_Click(object sender, EventArgs e)
        {
        }

        private void glDaiTam_Click(object sender, EventArgs e)
        {
        }

        private void glNguyen_Click(object sender, EventArgs e)
        {
            var process = new ProcessStartInfo("C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe");
            string urlFacebook = "https://www.facebook.com/cubonll";
            process.Arguments = urlFacebook;
            System.Diagnostics.Process.Start(urlFacebook);
        }
    }
}
