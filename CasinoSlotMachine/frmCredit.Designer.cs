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
            gradientLabel1 = new GradientLabel();
            gradientLabel2 = new GradientLabel();
            gradientLabel3 = new GradientLabel();
            gradientLabel4 = new GradientLabel();
            gradientLabel5 = new GradientLabel();
            SuspendLayout();
            // 
            // gradientLabel1
            // 
            gradientLabel1.BackgroundColorBottom = Color.Empty;
            gradientLabel1.BackgroundColorTop = Color.Empty;
            gradientLabel1.BackgroundGradientAngel = 0F;
            gradientLabel1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            gradientLabel1.Location = new Point(24, 9);
            gradientLabel1.Name = "gradientLabel1";
            gradientLabel1.Size = new Size(537, 53);
            gradientLabel1.TabIndex = 6;
            gradientLabel1.Text = "Nguyễn Võ Minh Duy - 48.01.104.035";
            gradientLabel1.TextColorBottom = Color.Yellow;
            gradientLabel1.TextColorTop = Color.Aqua;
            gradientLabel1.TextGradientAngel = 0F;
            gradientLabel1.Click += gradientLabel1_Click;
            // 
            // gradientLabel2
            // 
            gradientLabel2.AutoSize = true;
            gradientLabel2.BackgroundColorBottom = Color.Empty;
            gradientLabel2.BackgroundColorTop = Color.Empty;
            gradientLabel2.BackgroundGradientAngel = 0F;
            gradientLabel2.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            gradientLabel2.Location = new Point(387, 99);
            gradientLabel2.Name = "gradientLabel2";
            gradientLabel2.Size = new Size(433, 40);
            gradientLabel2.TabIndex = 7;
            gradientLabel2.Text = "Lầu Minh Tâm - 48.01.104.118";
            gradientLabel2.TextColorBottom = Color.Yellow;
            gradientLabel2.TextColorTop = Color.Aqua;
            gradientLabel2.TextGradientAngel = 0F;
            // 
            // gradientLabel3
            // 
            gradientLabel3.BackgroundColorBottom = Color.Empty;
            gradientLabel3.BackgroundColorTop = Color.Empty;
            gradientLabel3.BackgroundGradientAngel = 0F;
            gradientLabel3.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            gradientLabel3.Location = new Point(318, 256);
            gradientLabel3.Name = "gradientLabel3";
            gradientLabel3.Size = new Size(502, 40);
            gradientLabel3.TabIndex = 11;
            gradientLabel3.Text = "Liên Quốc Đại Tâm - 48.01.104.119";
            gradientLabel3.TextColorBottom = Color.Yellow;
            gradientLabel3.TextColorTop = Color.Aqua;
            gradientLabel3.TextGradientAngel = 0F;
            // 
            // gradientLabel4
            // 
            gradientLabel4.BackgroundColorBottom = Color.Empty;
            gradientLabel4.BackgroundColorTop = Color.Empty;
            gradientLabel4.BackgroundGradientAngel = 0F;
            gradientLabel4.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            gradientLabel4.Location = new Point(24, 177);
            gradientLabel4.Name = "gradientLabel4";
            gradientLabel4.Size = new Size(468, 53);
            gradientLabel4.TabIndex = 10;
            gradientLabel4.Text = "Văn Thành Thích - 48.01.104.127";
            gradientLabel4.TextColorBottom = Color.Yellow;
            gradientLabel4.TextColorTop = Color.Aqua;
            gradientLabel4.TextGradientAngel = 0F;
            // 
            // gradientLabel5
            // 
            gradientLabel5.BackgroundColorBottom = Color.Empty;
            gradientLabel5.BackgroundColorTop = Color.Empty;
            gradientLabel5.BackgroundGradientAngel = 0F;
            gradientLabel5.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            gradientLabel5.Location = new Point(24, 322);
            gradientLabel5.Name = "gradientLabel5";
            gradientLabel5.Size = new Size(549, 53);
            gradientLabel5.TabIndex = 12;
            gradientLabel5.Text = "Nguyễn Phúc Nguyên - 48.01.104.098";
            gradientLabel5.TextColorBottom = Color.Yellow;
            gradientLabel5.TextColorTop = Color.Aqua;
            gradientLabel5.TextGradientAngel = 0F;
            // 
            // frmCredit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(67, 1, 1);
            ClientSize = new Size(832, 412);
            Controls.Add(gradientLabel5);
            Controls.Add(gradientLabel3);
            Controls.Add(gradientLabel4);
            Controls.Add(gradientLabel2);
            Controls.Add(gradientLabel1);
            Name = "frmCredit";
            Text = "frmCredit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GradientLabel gradientLabel1;
        private GradientLabel gradientLabel2;
        private GradientLabel gradientLabel3;
        private GradientLabel gradientLabel4;
        private GradientLabel gradientLabel5;
    }
}