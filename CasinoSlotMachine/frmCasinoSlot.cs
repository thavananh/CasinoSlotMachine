using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Media;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
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

        // khởi tạo list (mảng 1 chiều) tương ứng với cột 1, cột 2, cột 3
        List<PictureBox> col1;
        List<PictureBox> col2;
        List<PictureBox> col3;

        // Tự định nghĩa một kiểu dữ liệu Class chứa thông tin gồm idImage (id ảnh) và asset (ảnh)
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
        // khởi tạo một dictionary dùng để random ảnh, với mỗi giá trị key (int) sẽ tương ứng với một value (ImageTaoLao)
        Dictionary<int, ImageTaoLao> assetList;

        // khởi tạo số lần quay cho mỗi cột
        static int scrollTime1 = 0;
        static int scrollTime2 = 0;
        static int scrollTime3 = 0;


        // khởi tạo biến rand
        static Random rand = new Random();

        // khởi tạo biến chứa các giá trị random tương ứng cho ba cột
        static int randNum1, randNum2, randNum3;

        // dùng để tránh bị gọi messagebox hai lần
        bool isExiting = false;

        // khởi tạo SoundPlayer để phát nhạc, thư viện mặc định của c# chỉ có thể phát nhạc có đuổi là .wav
        SoundPlayer player = new SoundPlayer(Properties.Resources.theme);

        private void frmCasinoSlot_FormClosing(object sender, FormClosingEventArgs e)
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


        // là tiền thưởng khi chưa chơi
        decimal totalWin = 0;

        // mặc đinh player có 1000 đô
        decimal credit = 1000;

        void loadTien()
        {
            // gán cho Text cho label với string có định dạng currency theo kiểu mỹ en-US
            // add cho comboBox các mức bet
            glCredit.Text = credit.ToString("C", new CultureInfo("en-us"));
            cboBet.Items.Add(10.ToString("C", new CultureInfo("en-us")));
            cboBet.Items.Add(20.ToString("C", new CultureInfo("en-us")));
            cboBet.Items.Add(50.ToString("C", new CultureInfo("en-us")));
            cboBet.Items.Add(100.ToString("C", new CultureInfo("en-us")));
            cboBet.Items.Add(200.ToString("C", new CultureInfo("en-us")));
            cboBet.Items.Add(500.ToString("C", new CultureInfo("en-us")));
            // set mức cược mặc định là 10 đô 
            cboBet.SelectedIndex = 0;
            // gán cho tiền thưởng là 0
            glSoTienThuong.Text = 0.ToString("C", new CultureInfo("en-us"));
        }

        private void frmCasinoSlot_Load(object sender, EventArgs e)
        {
            loadTien();
            player.PlayLooping();
        }

        void loadHinhAnh()
        {
            // khởi tạo 7 img với id từ 1 đến 7, ảnh có thêm xem trong phần resources
            ImageTaoLao img1 = new ImageTaoLao(1, Properties.Resources._1);
            ImageTaoLao img2 = new ImageTaoLao(2, Properties.Resources._2);
            ImageTaoLao img3 = new ImageTaoLao(3, Properties.Resources._3);
            ImageTaoLao img4 = new ImageTaoLao(4, Properties.Resources._4);
            ImageTaoLao img5 = new ImageTaoLao(5, Properties.Resources._5);
            ImageTaoLao img6 = new ImageTaoLao(6, Properties.Resources._6);
            ImageTaoLao img7 = new ImageTaoLao(7, Properties.Resources._7);

            // dùng để random
            assetList = new Dictionary<int, ImageTaoLao>()
            {
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
            };

            // random hình ảnh và gán tag cho các picture box
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

            // khởi tạo list tương ứng với 3 picture box
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



        // dùng để di chuyển các hình ảnh
        void movePictureBox(int speed)
        {
            randNum1 = rand.Next(0, 3);
            if (pctb1.Top > panel1.Height)
            {

                pctb1.Top = -panel1.Height / 2; // tạo hiệu ứng
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

            if (panel1.Height == 477 || panel1.Height == 716 || panel1.Height == 596)
            {
                if (col1[randNum1].Location.Y == 122) // thử bấm máy tính đi 
                {
                    scrollTime1++;
                }
            }
            else if (panel1.Height == 358) // 100%
            {
                if (col1[randNum1].Location.Y == 121) // thử bấm máy tính đi 
                {
                    scrollTime1++;
                }
            }
            else if (panel1.Height == 763)
            {
                if (col1[randNum1].Location.Y == 129) // thử bấm máy tính đi 
                {
                    scrollTime1++;
                }
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
            if (panel2.Height == 477 || panel2.Height == 716 || panel2.Height == 596)
            {
                if (col2[randNum2].Location.Y == 122) // thử bấm máy tính đi 
                {
                    scrollTime2++;
                }
            }
            else if (panel2.Height == 358)
            {
                if (col2[randNum2].Location.Y == 121) // thử bấm máy tính đi 
                {
                    scrollTime2++;
                }
            }
            else if (panel2.Height == 763)
            {
                if (col2[randNum2].Location.Y == 129) // thử bấm máy tính đi 
                {
                    scrollTime2++;
                }
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
            if (panel3.Height == 477 || panel3.Height == 716 || panel3.Height == 596)
            {
                if (col3[randNum3].Location.Y == 122) // thử bấm máy tính đi 
                {
                    scrollTime3++;
                }
            }
            else if (panel3.Height == 358)
            {
                if (col3[randNum3].Location.Y == 121) // thử bấm máy tính đi 
                {
                    scrollTime3++;
                }
            }
            else if (panel3.Height == 763)
            {
                if (col3[randNum3].Location.Y == 129) // thử bấm máy tính đi 
                {
                    scrollTime3++;
                }
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

        // điều kiện win là 1 hàng có 2 cột liên tiếp cùng chạy
        int isWin()
        {
            if ((col1[randNum1].Tag.ToString() == col2[randNum2].Tag.ToString()) && (col2[randNum2].Tag.ToString() == col3[randNum3].Tag.ToString()))
            {
                return 2;
            }
            else if ((col1[randNum1].Tag.ToString() == col2[randNum2].Tag.ToString()) || (col2[randNum2].Tag.ToString() == col3[randNum3].Tag.ToString()))
            {
                return 1;
            }
            return 0;
        }

        TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>(); // dùng để đợi game chạy hết 1 round rồi mới chạy tiếp

        private void btnPlay_Click(object sender, EventArgs e)
        {
            // kiểm tra tiền player có lớn hơn hoặc bằng tiền cược không
            if (Decimal.Parse(glCredit.Text, NumberStyles.Currency, new CultureInfo("en-us")) >= Decimal.Parse(cboBet.SelectedItem.ToString(), NumberStyles.Currency, new CultureInfo("en-us")))
            {
                tcs = new TaskCompletionSource<bool>();
                credit -= Decimal.Parse(cboBet.SelectedItem.ToString(), NumberStyles.Currency, new CultureInfo("en-us"));
                glCredit.Text = credit.ToString("C", new CultureInfo("en-us"));
                btnPlay.Enabled = false; // không cho người dùng bấm play game khi đã CHẠY RỒI
                btnGameMenu.Enabled = false;
                cboBet.Enabled = false;
                btnAutoPlay.Enabled = false;
                loadHinhAnh();
                scrollTime1 = 0;
                scrollTime2 = 0;
                scrollTime3 = 0;
                timer1.Start();
                timer2.Start();
                timer3.Start();
            }
            else
            {
                MessageBox.Show("Dừng lại là thất bại, nạp tiền chơi tiếp đi !!!");
            }
        }

        

        // đã set thuộc tính timer có interval là 1ms nghĩa là cứ 1 mili giây thì hàm timer_tick này sẽ được gọi 1 lần
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (scrollTime1 >= 3)
            {
                timer1.Stop();
                if (!timer1.Enabled && !timer2.Enabled && !timer3.Enabled)
                {
                    if (btnAutoPlay.BackColor != Color.Yellow)
                    {
                        btnPlay.Enabled = true;
                    }
                    btnGameMenu.Enabled = true;
                    btnAutoPlay.Enabled = true;
                    cboBet.Enabled = true;
                    if (isWin() == 1)
                    {
                        totalWin += Decimal.Parse(cboBet.SelectedItem.ToString(), NumberStyles.Currency, new CultureInfo("en-us")) * (decimal)1.1;
                        glSoTienThuong.Text = totalWin.ToString("C", new CultureInfo("en-us"));
                        credit += Decimal.Parse(cboBet.SelectedItem.ToString(), NumberStyles.Currency, new CultureInfo("en-us")) * (decimal)1.1;
                        glCredit.Text = credit.ToString("C", new CultureInfo("en-us"));
                    }
                    else if (isWin() == 2)
                    {
                        totalWin += Decimal.Parse(cboBet.SelectedItem.ToString(), NumberStyles.Currency, new CultureInfo("en-us")) * (decimal)1.25;
                        glSoTienThuong.Text = totalWin.ToString("C", new CultureInfo("en-us"));
                        credit += Decimal.Parse(cboBet.SelectedItem.ToString(), NumberStyles.Currency, new CultureInfo("en-us")) * (decimal)1.25;
                        glCredit.Text = credit.ToString("C", new CultureInfo("en-us"));
                    }
                    tcs.SetResult(true);
                }
                return;
            }
            movePictureBox(15);

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (scrollTime2 >= 3)
            {
                timer2.Stop();
                if (!timer1.Enabled && !timer2.Enabled && !timer3.Enabled)
                {
                    if (btnAutoPlay.BackColor != Color.Yellow)
                    {
                        btnPlay.Enabled = true;
                    }
                    btnGameMenu.Enabled = true;
                    btnAutoPlay.Enabled = true;
                    cboBet.Enabled = true;
                    if (isWin() == 1)
                    {
                        totalWin += Decimal.Parse(cboBet.SelectedItem.ToString(), NumberStyles.Currency, new CultureInfo("en-us")) * (decimal)1.1;
                        glSoTienThuong.Text = totalWin.ToString("C", new CultureInfo("en-us"));
                        credit += Decimal.Parse(cboBet.SelectedItem.ToString(), NumberStyles.Currency, new CultureInfo("en-us")) * (decimal)1.1;
                        glCredit.Text = credit.ToString("C", new CultureInfo("en-us"));
                    }
                    else if (isWin() == 2)
                    {
                        totalWin += Decimal.Parse(cboBet.SelectedItem.ToString(), NumberStyles.Currency, new CultureInfo("en-us")) * (decimal)1.25;
                        glSoTienThuong.Text = totalWin.ToString("C", new CultureInfo("en-us"));
                        credit += Decimal.Parse(cboBet.SelectedItem.ToString(), NumberStyles.Currency, new CultureInfo("en-us")) * (decimal)1.25;
                        glCredit.Text = credit.ToString("C", new CultureInfo("en-us"));
                    }
                    tcs.SetResult(true);
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
                if (!timer1.Enabled && !timer2.Enabled && !timer3.Enabled)
                {
                    if (btnAutoPlay.BackColor != Color.Yellow)
                    {
                        btnPlay.Enabled = true;
                    }
                    btnGameMenu.Enabled = true;
                    btnAutoPlay.Enabled = true;
                    cboBet.Enabled = true;
                    if (isWin() == 1)
                    {
                        totalWin += Decimal.Parse(cboBet.SelectedItem.ToString(), NumberStyles.Currency, new CultureInfo("en-us")) * (decimal)1.1;
                        glSoTienThuong.Text = totalWin.ToString("C", new CultureInfo("en-us"));
                        credit += Decimal.Parse(cboBet.SelectedItem.ToString(), NumberStyles.Currency, new CultureInfo("en-us")) * (decimal)1.1;
                        glCredit.Text = credit.ToString("C", new CultureInfo("en-us"));
                    }
                    else if (isWin() == 2)
                    {
                        totalWin += Decimal.Parse(cboBet.SelectedItem.ToString(), NumberStyles.Currency, new CultureInfo("en-us")) * (decimal)1.25;
                        glSoTienThuong.Text = totalWin.ToString("C", new CultureInfo("en-us"));
                        credit += Decimal.Parse(cboBet.SelectedItem.ToString(), NumberStyles.Currency, new CultureInfo("en-us")) * (decimal)1.25;
                        glCredit.Text = credit.ToString("C", new CultureInfo("en-us"));
                    }
                    tcs.SetResult(true);
                }
                return;
            }
            movePictureBox2(15);
        }

        bool isCancel = false;

        // AutoPlay
        private async void btnAutoPlay_Click(object sender, EventArgs e)
        {
            if (btnAutoPlay.BackColor == SystemColors.Control && Decimal.Parse(glCredit.Text, NumberStyles.Currency, new CultureInfo("en-us")) >= Decimal.Parse(cboBet.SelectedItem.ToString(), NumberStyles.Currency, new CultureInfo("en-us")))
            {
                btnAutoPlay.BackColor = Color.Yellow;
                while (Decimal.Parse(glCredit.Text, NumberStyles.Currency, new CultureInfo("en-us")) >= Decimal.Parse(cboBet.SelectedItem.ToString(), NumberStyles.Currency, new CultureInfo("en-us")))
                {
                    
                    if (isCancel)
                    {
                        break;
                    }
                    btnPlay_Click(sender, e);
                    btnAutoPlay.Enabled = true;
                    await tcs.Task;
                    await Task.Delay(1000); // làm chậm lại animation, để ảnh scroll hết
                }
            }
            else
            {
                btnPlay.Enabled = true;
                btnAutoPlay.BackColor = SystemColors.Control;
                btnAutoPlay.UseVisualStyleBackColor = true;
                isCancel = true;
            }
        }



        private void btnGameMenu_Click(object sender, EventArgs e)
        {
            frmMenuScreen menu = new frmMenuScreen();
            FormClosing -= frmCasinoSlot_FormClosing;
            player.Stop();
            this.Close();
            menu.Show();
        }


        // PlayLoop do mình gán tag mặc định
        private void btnSpeaker_Click(object sender, EventArgs e)
        {
            if (btnSpeaker.Tag.ToString() == "PlayLoop")
            {
                btnSpeaker.Tag = "Mute";
                btnSpeaker.BackgroundImage = Properties.Resources.volume_mute;
                player.Stop();
            }
            else
            {
                btnSpeaker.Tag = "PlayLoop";
                btnSpeaker.BackgroundImage = Properties.Resources.speaker_filled_audio_tool;
                player.PlayLooping();
            }
        }

        // Luật chơi
        private void btnGameRules_Click(object sender, EventArgs e)
        {
            MessageBox.Show("2 cột liên tiếp có hình giống nhau sẽ chiến thắng với số tiền thưởng = số cược * 1.1 và 3 cột có hình giống nhau liên tiếp sẽ chiến thắng với số tiền thưởng = số cược * 1.25", "Hướng dẫn", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
