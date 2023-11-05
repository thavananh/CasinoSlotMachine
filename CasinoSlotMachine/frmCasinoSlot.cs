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
    public partial class frmCasinoSlot : Form
    {
        public frmCasinoSlot()
        {
            InitializeComponent();
        }

        private void frmCasinoSlot_Load(object sender, EventArgs e)
        {

        }

        private void gradientLabel3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            movePictureBox(6);
        }
        void movePictureBox(int speed)
        {

            if (pictureBox1.Top > panel1.Height)
            {
                pictureBox1.Top = -panel1.Height;
            }
            else
            {
                pictureBox1.Top += speed;
            }
            if (pictureBox3.Top > panel1.Height)
            {
                pictureBox3.Top = (-panel1.Height * 2) + pictureBox3.Top;
            }
            else
            {
                pictureBox3.Top += speed;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
