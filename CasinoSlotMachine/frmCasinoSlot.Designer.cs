namespace CasinoSlotMachine
{
    partial class frmCasinoSlot
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCasinoSlot));
            glSoTienThuong = new GradientLabel();
            gradientPanelSoTienThuong = new GradientPanel();
            gradientPanel1 = new GradientPanel();
            gradientPanel2 = new GradientPanel();
            btnSpeaker = new Button();
            btnGameMenu = new Button();
            btnGameRules = new Button();
            glCredit = new GradientLabel();
            pctb3 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            pctb2 = new PictureBox();
            pctb1 = new PictureBox();
            btnPlay = new Button();
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            pctb6 = new PictureBox();
            pctb4 = new PictureBox();
            pctb5 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            pctb8 = new PictureBox();
            pctb7 = new PictureBox();
            pctb9 = new PictureBox();
            cboBet = new ComboBox();
            btnAutoPlay = new Button();
            label1 = new Label();
            label2 = new Label();
            gradientPanelSoTienThuong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctb3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctb2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctb1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctb6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctb4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctb5).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctb8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctb7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctb9).BeginInit();
            SuspendLayout();
            // 
            // glSoTienThuong
            // 
            glSoTienThuong.Aligntment = StringAlignment.Center;
            glSoTienThuong.BackColor = Color.Transparent;
            glSoTienThuong.BackgroundColorBottom = Color.Empty;
            glSoTienThuong.BackgroundColorTop = Color.Empty;
            glSoTienThuong.BackgroundGradientAngel = 0F;
            glSoTienThuong.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point);
            glSoTienThuong.LineAlignment = StringAlignment.Center;
            glSoTienThuong.Location = new Point(0, 23);
            glSoTienThuong.Name = "glSoTienThuong";
            glSoTienThuong.Size = new Size(800, 64);
            glSoTienThuong.TabIndex = 0;
            glSoTienThuong.Text = "320.000.000";
            glSoTienThuong.TextAlign = ContentAlignment.MiddleCenter;
            glSoTienThuong.TextColorBottom = Color.FromArgb(255, 229, 47);
            glSoTienThuong.TextColorTop = Color.FromArgb(254, 219, 24);
            glSoTienThuong.TextGradientAngel = 90F;
            // 
            // gradientPanelSoTienThuong
            // 
            gradientPanelSoTienThuong.ColorBottom = Color.FromArgb(110, 20, 41);
            gradientPanelSoTienThuong.ColorTop = Color.FromArgb(192, 64, 0);
            gradientPanelSoTienThuong.Controls.Add(glSoTienThuong);
            gradientPanelSoTienThuong.GradientAngle = 45F;
            gradientPanelSoTienThuong.Location = new Point(0, 0);
            gradientPanelSoTienThuong.Name = "gradientPanelSoTienThuong";
            gradientPanelSoTienThuong.Size = new Size(800, 112);
            gradientPanelSoTienThuong.TabIndex = 1;
            // 
            // gradientPanel1
            // 
            gradientPanel1.ColorBottom = Color.FromArgb(204, 157, 59);
            gradientPanel1.ColorTop = Color.FromArgb(255, 192, 128);
            gradientPanel1.GradientAngle = 90F;
            gradientPanel1.Location = new Point(264, 118);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(10, 358);
            gradientPanel1.TabIndex = 2;
            // 
            // gradientPanel2
            // 
            gradientPanel2.ColorBottom = Color.FromArgb(204, 157, 59);
            gradientPanel2.ColorTop = Color.FromArgb(255, 192, 128);
            gradientPanel2.GradientAngle = 90F;
            gradientPanel2.Location = new Point(533, 118);
            gradientPanel2.Name = "gradientPanel2";
            gradientPanel2.Size = new Size(10, 358);
            gradientPanel2.TabIndex = 3;
            // 
            // btnSpeaker
            // 
            btnSpeaker.BackgroundImage = Properties.Resources.speaker_filled_audio_tool;
            btnSpeaker.BackgroundImageLayout = ImageLayout.Stretch;
            btnSpeaker.Location = new Point(4, 501);
            btnSpeaker.Name = "btnSpeaker";
            btnSpeaker.Size = new Size(51, 51);
            btnSpeaker.TabIndex = 4;
            btnSpeaker.Tag = "PlayLoop";
            btnSpeaker.UseVisualStyleBackColor = true;
            btnSpeaker.Click += btnSpeaker_Click;
            // 
            // btnGameMenu
            // 
            btnGameMenu.Location = new Point(61, 493);
            btnGameMenu.Name = "btnGameMenu";
            btnGameMenu.Size = new Size(99, 29);
            btnGameMenu.TabIndex = 5;
            btnGameMenu.Text = "GAMES MENU";
            btnGameMenu.UseVisualStyleBackColor = true;
            btnGameMenu.Click += btnGameMenu_Click;
            // 
            // btnGameRules
            // 
            btnGameRules.Location = new Point(61, 528);
            btnGameRules.Name = "btnGameRules";
            btnGameRules.Size = new Size(99, 29);
            btnGameRules.TabIndex = 6;
            btnGameRules.Text = "GAME RULES";
            btnGameRules.UseVisualStyleBackColor = true;
            btnGameRules.Click += btnGameRules_Click;
            // 
            // glCredit
            // 
            glCredit.Aligntment = StringAlignment.Center;
            glCredit.AutoSize = true;
            glCredit.BackgroundColorBottom = Color.Empty;
            glCredit.BackgroundColorTop = Color.Empty;
            glCredit.BackgroundGradientAngel = 0F;
            glCredit.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            glCredit.LineAlignment = StringAlignment.Center;
            glCredit.Location = new Point(314, 513);
            glCredit.Name = "glCredit";
            glCredit.Size = new Size(186, 40);
            glCredit.TabIndex = 8;
            glCredit.Text = "000.000.000";
            glCredit.TextColorBottom = Color.White;
            glCredit.TextColorTop = Color.White;
            glCredit.TextGradientAngel = 0F;
            // 
            // pctb3
            // 
            pctb3.BackColor = Color.Transparent;
            pctb3.BackgroundImage = Properties.Resources._2;
            pctb3.BackgroundImageLayout = ImageLayout.Stretch;
            pctb3.Location = new Point(0, 274);
            pctb3.Margin = new Padding(3, 2, 3, 2);
            pctb3.Name = "pctb3";
            pctb3.Size = new Size(255, 164);
            pctb3.TabIndex = 13;
            pctb3.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(pctb2);
            panel1.Controls.Add(pctb1);
            panel1.Controls.Add(pctb3);
            panel1.Location = new Point(4, 118);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(255, 358);
            panel1.TabIndex = 14;
            // 
            // pctb2
            // 
            pctb2.BackColor = Color.Transparent;
            pctb2.BackgroundImage = Properties.Resources._2;
            pctb2.BackgroundImageLayout = ImageLayout.Stretch;
            pctb2.Location = new Point(0, 89);
            pctb2.Margin = new Padding(3, 2, 3, 2);
            pctb2.Name = "pctb2";
            pctb2.Size = new Size(255, 164);
            pctb2.TabIndex = 15;
            pctb2.TabStop = false;
            // 
            // pctb1
            // 
            pctb1.BackColor = Color.Transparent;
            pctb1.BackgroundImage = Properties.Resources._1;
            pctb1.BackgroundImageLayout = ImageLayout.Stretch;
            pctb1.Location = new Point(0, -89);
            pctb1.Margin = new Padding(3, 2, 3, 2);
            pctb1.Name = "pctb1";
            pctb1.Size = new Size(255, 164);
            pctb1.TabIndex = 14;
            pctb1.TabStop = false;
            // 
            // btnPlay
            // 
            btnPlay.Location = new Point(674, 480);
            btnPlay.Margin = new Padding(3, 2, 3, 2);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(82, 22);
            btnPlay.TabIndex = 15;
            btnPlay.Text = "Chơi";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // timer2
            // 
            timer2.Interval = 1;
            timer2.Tick += timer2_Tick;
            // 
            // timer3
            // 
            timer3.Interval = 1;
            timer3.Tick += timer3_Tick;
            // 
            // pctb6
            // 
            pctb6.BackColor = Color.Transparent;
            pctb6.BackgroundImage = Properties.Resources._2;
            pctb6.BackgroundImageLayout = ImageLayout.Stretch;
            pctb6.Location = new Point(0, 274);
            pctb6.Margin = new Padding(3, 2, 3, 2);
            pctb6.Name = "pctb6";
            pctb6.Size = new Size(255, 164);
            pctb6.TabIndex = 13;
            pctb6.TabStop = false;
            // 
            // pctb4
            // 
            pctb4.BackColor = Color.Transparent;
            pctb4.BackgroundImage = Properties.Resources._1;
            pctb4.BackgroundImageLayout = ImageLayout.Stretch;
            pctb4.Location = new Point(0, -89);
            pctb4.Margin = new Padding(3, 2, 3, 2);
            pctb4.Name = "pctb4";
            pctb4.Size = new Size(255, 164);
            pctb4.TabIndex = 14;
            pctb4.TabStop = false;
            // 
            // pctb5
            // 
            pctb5.BackColor = Color.Transparent;
            pctb5.BackgroundImage = Properties.Resources._2;
            pctb5.BackgroundImageLayout = ImageLayout.Stretch;
            pctb5.Location = new Point(0, 89);
            pctb5.Margin = new Padding(3, 2, 3, 2);
            pctb5.Name = "pctb5";
            pctb5.Size = new Size(255, 164);
            pctb5.TabIndex = 15;
            pctb5.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(pctb5);
            panel2.Controls.Add(pctb4);
            panel2.Controls.Add(pctb6);
            panel2.Location = new Point(279, 118);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(255, 358);
            panel2.TabIndex = 15;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(pctb8);
            panel3.Controls.Add(pctb7);
            panel3.Controls.Add(pctb9);
            panel3.Location = new Point(545, 118);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(255, 358);
            panel3.TabIndex = 16;
            // 
            // pctb8
            // 
            pctb8.BackColor = Color.Transparent;
            pctb8.BackgroundImage = Properties.Resources._2;
            pctb8.BackgroundImageLayout = ImageLayout.Stretch;
            pctb8.Location = new Point(0, 89);
            pctb8.Margin = new Padding(3, 2, 3, 2);
            pctb8.Name = "pctb8";
            pctb8.Size = new Size(255, 164);
            pctb8.TabIndex = 15;
            pctb8.TabStop = false;
            // 
            // pctb7
            // 
            pctb7.BackColor = Color.Transparent;
            pctb7.BackgroundImage = Properties.Resources._1;
            pctb7.BackgroundImageLayout = ImageLayout.Stretch;
            pctb7.Location = new Point(0, -89);
            pctb7.Margin = new Padding(3, 2, 3, 2);
            pctb7.Name = "pctb7";
            pctb7.Size = new Size(255, 164);
            pctb7.TabIndex = 14;
            pctb7.TabStop = false;
            // 
            // pctb9
            // 
            pctb9.BackColor = Color.Transparent;
            pctb9.BackgroundImage = Properties.Resources._2;
            pctb9.BackgroundImageLayout = ImageLayout.Stretch;
            pctb9.Location = new Point(0, 274);
            pctb9.Margin = new Padding(3, 2, 3, 2);
            pctb9.Name = "pctb9";
            pctb9.Size = new Size(255, 164);
            pctb9.TabIndex = 13;
            pctb9.TabStop = false;
            // 
            // cboBet
            // 
            cboBet.BackColor = Color.FromArgb(67, 1, 1);
            cboBet.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            cboBet.ForeColor = Color.White;
            cboBet.FormattingEnabled = true;
            cboBet.Location = new Point(625, 510);
            cboBet.Margin = new Padding(3, 2, 3, 2);
            cboBet.Name = "cboBet";
            cboBet.Size = new Size(150, 48);
            cboBet.TabIndex = 17;
            // 
            // btnAutoPlay
            // 
            btnAutoPlay.AutoSize = true;
            btnAutoPlay.BackColor = SystemColors.Control;
            btnAutoPlay.BackgroundImage = Properties.Resources.game_controller;
            btnAutoPlay.BackgroundImageLayout = ImageLayout.Stretch;
            btnAutoPlay.Location = new Point(640, 478);
            btnAutoPlay.Margin = new Padding(3, 2, 3, 2);
            btnAutoPlay.Name = "btnAutoPlay";
            btnAutoPlay.Size = new Size(30, 30);
            btnAutoPlay.TabIndex = 18;
            btnAutoPlay.UseVisualStyleBackColor = false;
            btnAutoPlay.Click += btnAutoPlay_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Blue;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(193, 513);
            label1.Name = "label1";
            label1.Size = new Size(116, 40);
            label1.TabIndex = 19;
            label1.Text = "CREDIT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Blue;
            label2.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Yellow;
            label2.Location = new Point(523, 513);
            label2.Name = "label2";
            label2.Size = new Size(68, 40);
            label2.TabIndex = 20;
            label2.Text = "BET";
            // 
            // frmCasinoSlot
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(67, 1, 1);
            ClientSize = new Size(800, 563);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAutoPlay);
            Controls.Add(cboBet);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(btnPlay);
            Controls.Add(panel1);
            Controls.Add(glCredit);
            Controls.Add(btnGameRules);
            Controls.Add(btnGameMenu);
            Controls.Add(btnSpeaker);
            Controls.Add(gradientPanel2);
            Controls.Add(gradientPanel1);
            Controls.Add(gradientPanelSoTienThuong);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCasinoSlot";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCasinoSlot";
            FormClosing += frmCasinoSlot_FormClosing;
            Load += frmCasinoSlot_Load;
            gradientPanelSoTienThuong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pctb3).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pctb2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctb1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctb6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctb4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctb5).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pctb8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctb7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctb9).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GradientLabel glSoTienThuong;
        private GradientPanel gradientPanelSoTienThuong;
        private GradientPanel gradientPanel1;
        private GradientPanel gradientPanel2;
        private Button btnSpeaker;
        private Button btnGameMenu;
        private Button btnGameRules;
        private GradientLabel glCredit;
        private PictureBox pctb3;
        private System.Windows.Forms.Timer timer1;
        private Panel panel1;
        private Button btnPlay;
        private PictureBox pctb1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private PictureBox pctb2;
        private PictureBox pctb6;
        private PictureBox pctb4;
        private PictureBox pctb5;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pctb8;
        private PictureBox pctb7;
        private PictureBox pctb9;
        private ComboBox cboBet;
        private Button btnAutoPlay;
        private Label label1;
        private Label label2;
    }
}