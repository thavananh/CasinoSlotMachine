namespace CasinoSlotMachine
{
    partial class frmCredit
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
            glDuy = new GradientLabel();
            glMinhTam = new GradientLabel();
            glDaiTam = new GradientLabel();
            glThich = new GradientLabel();
            glNguyen = new GradientLabel();
            btnGameMenu = new Button();
            SuspendLayout();
            // 
            // glDuy
            // 
            glDuy.Aligntment = StringAlignment.Center;
            glDuy.Anchor = AnchorStyles.Left;
            glDuy.AutoSize = true;
            glDuy.BackgroundColorBottom = Color.Empty;
            glDuy.BackgroundColorTop = Color.Empty;
            glDuy.BackgroundGradientAngel = 0F;
            glDuy.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            glDuy.LineAlignment = StringAlignment.Center;
            glDuy.Location = new Point(1, 9);
            glDuy.Name = "glDuy";
            glDuy.Size = new Size(533, 40);
            glDuy.TabIndex = 6;
            glDuy.Text = "Nguyễn Võ Minh Duy - 48.01.104.035";
            glDuy.TextColorBottom = Color.Yellow;
            glDuy.TextColorTop = Color.Aqua;
            glDuy.TextGradientAngel = 0F;
            glDuy.Click += glDuy_Click;
            // 
            // glMinhTam
            // 
            glMinhTam.Aligntment = StringAlignment.Center;
            glMinhTam.AutoSize = true;
            glMinhTam.BackgroundColorBottom = Color.Empty;
            glMinhTam.BackgroundColorTop = Color.Empty;
            glMinhTam.BackgroundGradientAngel = 0F;
            glMinhTam.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            glMinhTam.LineAlignment = StringAlignment.Center;
            glMinhTam.Location = new Point(283, 75);
            glMinhTam.Name = "glMinhTam";
            glMinhTam.Size = new Size(433, 40);
            glMinhTam.TabIndex = 7;
            glMinhTam.Text = "Lầu Minh Tâm - 48.01.104.118";
            glMinhTam.TextColorBottom = Color.Yellow;
            glMinhTam.TextColorTop = Color.Aqua;
            glMinhTam.TextGradientAngel = 0F;
            glMinhTam.Click += glMinhTam_Click;
            // 
            // glDaiTam
            // 
            glDaiTam.Aligntment = StringAlignment.Center;
            glDaiTam.Anchor = AnchorStyles.Left;
            glDaiTam.AutoSize = true;
            glDaiTam.BackgroundColorBottom = Color.Empty;
            glDaiTam.BackgroundColorTop = Color.Empty;
            glDaiTam.BackgroundGradientAngel = 0F;
            glDaiTam.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            glDaiTam.LineAlignment = StringAlignment.Center;
            glDaiTam.Location = new Point(221, 190);
            glDaiTam.Name = "glDaiTam";
            glDaiTam.RightToLeft = RightToLeft.No;
            glDaiTam.Size = new Size(495, 40);
            glDaiTam.TabIndex = 11;
            glDaiTam.Text = "Liên Quốc Đại Tâm - 48.01.104.119";
            glDaiTam.TextColorBottom = Color.Yellow;
            glDaiTam.TextColorTop = Color.Aqua;
            glDaiTam.TextGradientAngel = 0F;
            glDaiTam.Click += glDaiTam_Click;
            // 
            // glThich
            // 
            glThich.Aligntment = StringAlignment.Center;
            glThich.AutoSize = true;
            glThich.BackgroundColorBottom = Color.Empty;
            glThich.BackgroundColorTop = Color.Empty;
            glThich.BackgroundGradientAngel = 0F;
            glThich.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            glThich.LineAlignment = StringAlignment.Center;
            glThich.Location = new Point(1, 132);
            glThich.Name = "glThich";
            glThich.Size = new Size(464, 40);
            glThich.TabIndex = 10;
            glThich.Text = "Văn Thành Thích - 48.01.104.127";
            glThich.TextColorBottom = Color.Yellow;
            glThich.TextColorTop = Color.Aqua;
            glThich.TextGradientAngel = 0F;
            glThich.Click += glThich_Click;
            // 
            // glNguyen
            // 
            glNguyen.Aligntment = StringAlignment.Center;
            glNguyen.AutoSize = true;
            glNguyen.BackgroundColorBottom = Color.Empty;
            glNguyen.BackgroundColorTop = Color.Empty;
            glNguyen.BackgroundGradientAngel = 0F;
            glNguyen.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            glNguyen.LineAlignment = StringAlignment.Center;
            glNguyen.Location = new Point(1, 244);
            glNguyen.Name = "glNguyen";
            glNguyen.Size = new Size(540, 40);
            glNguyen.TabIndex = 12;
            glNguyen.Text = "Nguyễn Phúc Nguyên - 48.01.104.098";
            glNguyen.TextColorBottom = Color.Yellow;
            glNguyen.TextColorTop = Color.Aqua;
            glNguyen.TextGradientAngel = 0F;
            glNguyen.Click += glNguyen_Click;
            // 
            // btnGameMenu
            // 
            btnGameMenu.Location = new Point(598, 289);
            btnGameMenu.Name = "btnGameMenu";
            btnGameMenu.Size = new Size(91, 29);
            btnGameMenu.TabIndex = 13;
            btnGameMenu.Text = "GAMES MENU";
            btnGameMenu.UseVisualStyleBackColor = true;
            btnGameMenu.Click += btnGameMenu_Click;
            // 
            // frmCredit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(67, 1, 1);
            ClientSize = new Size(728, 328);
            Controls.Add(btnGameMenu);
            Controls.Add(glNguyen);
            Controls.Add(glDaiTam);
            Controls.Add(glThich);
            Controls.Add(glMinhTam);
            Controls.Add(glDuy);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmCredit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCredit";
            FormClosing += frmCredit_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GradientLabel glDuy;
        private GradientLabel glMinhTam;
        private GradientLabel glDaiTam;
        private GradientLabel glThich;
        private GradientLabel glNguyen;
        private Button btnGameMenu;
    }
}