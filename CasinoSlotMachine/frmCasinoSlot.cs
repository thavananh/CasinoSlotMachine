using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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

        List<PictureBox> col1;
        List<PictureBox> col2;
        List<PictureBox> col3;
        Dictionary<int, ImageTaoLao> assetList;

        static int scrollTime1 = 0;
        static int scrollTime2 = 0;
        static int scrollTime3 = 0;

        static Random rand = new Random();
        static int randNum1, randNum2, randNum3;

        public class ImageTaoLao
        {
            private int idImage;

            public int IdImage { get => idImage; set => idImage = value; }
            public Image Asset { get => asset; set => asset = value; }

            private Image asset;

            public ImageTaoLao(int id, Bitmap asset)
            {
                this.IdImage = id;
                this.Asset = asset;
            }
        }
        private void frmCasinoSlot_Load(object sender, EventArgs e)
        {
            loadHinhAnh();
        }

        void loadHinhAnh()
        {
            ImageTaoLao img1 = new ImageTaoLao(1, Properties.Resources._1);
            ImageTaoLao img2 = new ImageTaoLao(2, Properties.Resources._2);
            ImageTaoLao img3 = new ImageTaoLao(3, Properties.Resources._3);
            ImageTaoLao img4 = new ImageTaoLao(4, Properties.Resources._4);
            ImageTaoLao img5 = new ImageTaoLao(5, Properties.Resources._5);
            ImageTaoLao img6 = new ImageTaoLao(6, Properties.Resources._6);
            ImageTaoLao img7 = new ImageTaoLao(7, Properties.Resources._7);

            assetList = new Dictionary<int, ImageTaoLao>()
            {
                //{1, Properties.Resources._1},
                //{2, Properties.Resources._1},
                //{3, Properties.Resources._2},
                //{4, Properties.Resources._2},
                //{5, Properties.Resources._2},
                //{6, Properties.Resources._3},
                //{7, Properties.Resources._3},
                //{8, Properties.Resources._4},
                //{9, Properties.Resources._5},
                //{10, Properties.Resources._6},
                //{11, Properties.Resources._7},
                {1, img1},
                {2, img1},
                {3, img1},
                {4, img1},
                {5, img2},
                {6, img2},
                {7, img2},
                {8, img3},
                {9, img3},
                {10, img4},
                {11, img4},
                {12, img5},
                {13, img6},
                {14, img7},
                //{1, img1},
                //{2, img1},
                //{3, img1},
                //{4, img1},
                //{5, img1},
                //{6, img1},
                //{7, img1},
                //{8, img1},
                //{9, img1},
                //{10, img1},
                //{11, img1},
                //{12, img1},
                //{13, img1},
                //{14, img1},
            };


            int randTaoLao = rand.Next(1, 15);
            pctb1.BackgroundImage = assetList[randTaoLao].Asset;
            pctb1.Tag = assetList[randTaoLao].IdImage;
            randTaoLao = rand.Next(1, 15);
            pctb2.BackgroundImage = assetList[randTaoLao].Asset;
            pctb2.Tag = assetList[randTaoLao].IdImage;
            randTaoLao = rand.Next(1, 15);
            pctb3.BackgroundImage = assetList[randTaoLao].Asset;
            pctb3.Tag = assetList[randTaoLao].IdImage;
            randTaoLao = rand.Next(1, 15);
            pctb4.BackgroundImage = assetList[randTaoLao].Asset;
            pctb4.Tag = assetList[randTaoLao].IdImage;
            randTaoLao = rand.Next(1, 15);
            pctb5.BackgroundImage = assetList[randTaoLao].Asset;
            pctb5.Tag = assetList[randTaoLao].IdImage;
            randTaoLao = rand.Next(1, 15);
            pctb6.BackgroundImage = assetList[randTaoLao].Asset;
            pctb6.Tag = assetList[randTaoLao].IdImage;
            randTaoLao = rand.Next(1, 15);
            pctb7.BackgroundImage = assetList[randTaoLao].Asset;
            pctb7.Tag = assetList[randTaoLao].IdImage;
            randTaoLao = rand.Next(1, 15);
            pctb8.BackgroundImage = assetList[randTaoLao].Asset;
            pctb8.Tag = assetList[randTaoLao].IdImage;
            randTaoLao = rand.Next(1, 15);
            pctb9.BackgroundImage = assetList[randTaoLao].Asset;
            pctb9.Tag = assetList[randTaoLao].IdImage;
            col1 = new List<PictureBox>()
            {
                pctb1,
                pctb2,
                pctb3

            };
            col2 = new List<PictureBox>()
            {
                pctb4,
                pctb5,
                pctb6
            };
            col3 = new List<PictureBox>()
            {
                pctb7,
                pctb8,
                pctb9
            };
        }


        void movePictureBox(int speed)
        {
            randNum1 = rand.Next(0, 3);
            if (pctb1.Top > panel1.Height)
            {

                pctb1.Top = -panel1.Height / 2;
            }
            else
            {
                pctb1.Top += speed;
            }
            if (pctb2.Top > panel1.Height)
            {

                pctb2.Top = -panel1.Height / 2;
            }
            else
            {
                pctb2.Top += speed;
            }
            if (col1[randNum1].Location.Y == 121)
            {
                scrollTime1++;
            }
            if (pctb3.Top > panel1.Height)
            {

                pctb3.Top = -panel1.Height / 2;
            }
            else
            {
                pctb3.Top += speed;
            }
        }

        void movePictureBox1(int speed)
        {
            randNum2 = rand.Next(0, 3);
            if (pctb4.Top > panel2.Height)
            {
                pctb4.Top = -panel2.Height / 2;
            }
            else
            {
                pctb4.Top += speed;
            }
            if (pctb5.Top > panel2.Height)
            {

                pctb5.Top = -panel2.Height / 2;
            }
            else
            {
                pctb5.Top += speed;
            }
            if (col2[randNum2].Location.Y == 121)
            {
                scrollTime2++;
            }
            if (pctb6.Top > panel2.Height)
            {

                pctb6.Top = -panel2.Height / 2;
            }
            else
            {
                pctb6.Top += speed;
            }

        }

        void movePictureBox2(int speed)
        {
            randNum3 = rand.Next(0, 3);
            if (pctb7.Top > panel3.Height)
            {
                pctb7.Top = -panel3.Height / 2;
            }
            else
            {
                pctb7.Top += speed;
            }
            if (pctb8.Top > panel3.Height)
            {

                pctb8.Top = -panel3.Height / 2;
            }
            else
            {
                pctb8.Top += speed;
            }
            if (col3[randNum3].Location.Y == 121)
            {
                scrollTime3++;
            }
            if (pctb9.Top > panel3.Height)
            {

                pctb9.Top = -panel3.Height / 2;
            }
            else
            {
                pctb9.Top += speed;
            }

        }

        bool isWin()
        {
            if ((col1[randNum1].Tag.ToString() == col2[randNum2].Tag.ToString()) || (col2[randNum2].Tag.ToString() == col3[randNum3].Tag.ToString()))
            {
                return true;
            }
            return false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (scrollTime1 >= 3)
            {
                timer1.Stop();
                if (isWin() && !timer2.Enabled && !timer3.Enabled)
                {

                    MessageBox.Show("bạn đã chiến thắng");
                }
                return;
            }
            movePictureBox(15);

        }

        decimal totalWin = 0;
        decimal credit = 0;
        decimal bet = 0;



        private void button4_Click(object sender, EventArgs e)
        {
            scrollTime1 = 0;
            scrollTime2 = 0;
            scrollTime3 = 0;
            timer1.Start();
            timer2.Start();
            timer3.Start();
            loadHinhAnh();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (scrollTime2 >= 3)
            {
                timer2.Stop();
                if (isWin() && !timer1.Enabled && !timer3.Enabled)
                {

                    MessageBox.Show("bạn đã chiến thắng");

                }
                return;
            }
            movePictureBox1(15);

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (scrollTime3 >= 3)
            {
                timer3.Stop();
                if (isWin() && !timer1.Enabled && !timer2.Enabled)
                {

                    MessageBox.Show("bạn đã chiến thắng");

                }
                return;
            }
            movePictureBox2(15);
        }
    }
}
