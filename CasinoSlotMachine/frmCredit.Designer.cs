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
            glDuy.BackgroundColorBottom = Color.Empty;
            glDuy.BackgroundColorTop = Color.Empty;
            glDuy.BackgroundGradientAngel = 0F;
            glDuy.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            glDuy.Location = new Point(24, 9);
            glDuy.Name = "glDuy";
            glDuy.Size = new Size(537, 53);
            glDuy.TabIndex = 6;
            glDuy.Text = "Nguyễn Võ Minh Duy - 48.01.104.035";
            glDuy.TextColorBottom = Color.Yellow;
            glDuy.TextColorTop = Color.Aqua;
            glDuy.TextGradientAngel = 0F;
            glDuy.Click += glDuy_Click;
            // 
            // glMinhTam
            // 
            glMinhTam.AutoSize = true;
            glMinhTam.BackgroundColorBottom = Color.Empty;
            glMinhTam.BackgroundColorTop = Color.Empty;
            glMinhTam.BackgroundGradientAngel = 0F;
            glMinhTam.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            glMinhTam.Location = new Point(387, 99);
            glMinhTam.Name = "glMinhTam";
            glMinhTam.Size = new Size(541, 50);
            glMinhTam.TabIndex = 7;
            glMinhTam.Text = "Lầu Minh Tâm - 48.01.104.118";
            glMinhTam.TextColorBottom = Color.Yellow;
            glMinhTam.TextColorTop = Color.Aqua;
            glMinhTam.TextGradientAngel = 0F;
            glMinhTam.Click += glMinhTam_Click;
            // 
            // glDaiTam
            // 
            glDaiTam.BackgroundColorBottom = Color.Empty;
            glDaiTam.BackgroundColorTop = Color.Empty;
            glDaiTam.BackgroundGradientAngel = 0F;
            glDaiTam.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            glDaiTam.Location = new Point(318, 256);
            glDaiTam.Name = "glDaiTam";
            glDaiTam.Size = new Size(502, 40);
            glDaiTam.TabIndex = 11;
            glDaiTam.Text = "Liên Quốc Đại Tâm - 48.01.104.119";
            glDaiTam.TextColorBottom = Color.Yellow;
            glDaiTam.TextColorTop = Color.Aqua;
            glDaiTam.TextGradientAngel = 0F;
            glDaiTam.Click += glDaiTam_Click;
            // 
            // glThich
            // 
            glThich.BackgroundColorBottom = Color.Empty;
            glThich.BackgroundColorTop = Color.Empty;
            glThich.BackgroundGradientAngel = 0F;
            glThich.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            glThich.Location = new Point(24, 173);
            glThich.Name = "glThich";
            glThich.Size = new Size(468, 53);
            glThich.TabIndex = 10;
            glThich.Text = "Văn Thành Thích - 48.01.104.127";
            glThich.TextColorBottom = Color.Yellow;
            glThich.TextColorTop = Color.Aqua;
            glThich.TextGradientAngel = 0F;
            glThich.Click += glThich_Click;
            // 
            // glNguyen
            // 
            glNguyen.BackgroundColorBottom = Color.Empty;
            glNguyen.BackgroundColorTop = Color.Empty;
            glNguyen.BackgroundGradientAngel = 0F;
            glNguyen.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            glNguyen.Location = new Point(24, 322);
            glNguyen.Name = "glNguyen";
            glNguyen.Size = new Size(549, 53);
            glNguyen.TabIndex = 12;
            glNguyen.Text = "Nguyễn Phúc Nguyên - 48.01.104.098";
            glNguyen.TextColorBottom = Color.Yellow;
            glNguyen.TextColorTop = Color.Aqua;
            glNguyen.TextGradientAngel = 0F;
            glNguyen.Click += glNguyen_Click;
            // 
            // btnGameMenu
            // 
            btnGameMenu.Location = new Point(683, 385);
            btnGameMenu.Margin = new Padding(3, 4, 3, 4);
            btnGameMenu.Name = "btnGameMenu";
            btnGameMenu.Size = new Size(104, 39);
            btnGameMenu.TabIndex = 13;
            btnGameMenu.Text = "GAMES MENU";
            btnGameMenu.UseVisualStyleBackColor = true;
            btnGameMenu.Click += btnGameMenu_Click;
            // 
            // frmCredit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(67, 1, 1);
            ClientSize = new Size(832, 437);
            Controls.Add(btnGameMenu);
            Controls.Add(glNguyen);
            Controls.Add(glDaiTam);
            Controls.Add(glThich);
            Controls.Add(glMinhTam);
            Controls.Add(glDuy);
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