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

        static int scrollTime1 = 0;
        static int scrollTime2 = 0;
        static int scorllTime3 = 0;

        void movePictureBox(int speed)
        {
           
            if (pctb1.Top > panel1.Height)
            {
                pctb1.Top = -panel1.Height;
            }
            else
            {
                pctb1.Top += speed;
            }
            if (pctb2.Top > panel1.Height)
            {
                pctb2.Top = (-panel1.Height * 2) + pctb2.Top;
            }
            else
            {
                pctb2.Top += speed;
            }
        }

        void movePictureBox1(int speed)
        {
            if (pctb3.Top > panel2.Height)
            {
                pctb3.Top = -panel2.Height;
            }
            else
            {
                pctb3.Top += speed;
            }
            if (pctb4.Top > panel2.Height)
            {
                pctb4.Top = (-panel2.Height * 2) + pctb4.Top;
            }
            else
            {
                pctb4.Top += speed;
            }
        }

        void movePictureBox2(int speed)
        {
            if (pctb5.Top > panel3.Height)
            {
                pctb5.Top = -panel3.Height;
            }
            else
            {
                pctb5.Top += speed;
            }
            if (pctb6.Top > panel1.Height)
            {
                pctb6.Top = (-panel3.Height * 2) + pctb6.Top;
            }
            else
            {
                pctb6.Top += speed;
            }
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            movePictureBox(10);
            await Task.Delay(300);
            timer2.Start();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private async void timer2_Tick(object sender, EventArgs e)
        {
            movePictureBox1(10);
            await Task.Delay(500);
            timer3.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            movePictureBox2(10);
        }
    }
}
