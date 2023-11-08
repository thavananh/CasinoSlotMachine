namespace CasinoSlotMachine
{
    partial class frmMenuScreen
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
            glTitle = new GradientLabel();
            glPlay = new GradientLabel();
            glHelp = new GradientLabel();
            glCredit = new GradientLabel();
            glQuit = new GradientLabel();
            SuspendLayout();
            // 
            // glTitle
            // 
            glTitle.BackgroundColorBottom = Color.Empty;
            glTitle.BackgroundColorTop = Color.Empty;
            glTitle.BackgroundGradientAngel = 0F;
            glTitle.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            glTitle.Location = new Point(0, 22);
            glTitle.Name = "glTitle";
            glTitle.Size = new Size(531, 44);
            glTitle.TabIndex = 0;
            glTitle.Text = "Casino Slot Machine";
            glTitle.TextColorBottom = Color.Yellow;
            glTitle.TextColorTop = Color.Aqua;
            glTitle.TextGradientAngel = 0F;
            // 
            // glPlay
            // 
            glPlay.AutoSize = true;
            glPlay.BackgroundColorBottom = Color.Empty;
            glPlay.BackgroundColorTop = Color.Empty;
            glPlay.BackgroundGradientAngel = 0F;
            glPlay.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            glPlay.ForeColor = Color.Coral;
            glPlay.Location = new Point(192, 76);
            glPlay.Name = "glPlay";
            glPlay.Size = new Size(169, 40);
            glPlay.TabIndex = 1;
            glPlay.Text = "PLAY NOW";
            glPlay.TextColorBottom = Color.Yellow;
            glPlay.TextColorTop = Color.Yellow;
            glPlay.TextGradientAngel = 0F;
            glPlay.Click += glPlay_Click;
            // 
            // glHelp
            // 
            glHelp.AutoSize = true;
            glHelp.BackgroundColorBottom = Color.Empty;
            glHelp.BackgroundColorTop = Color.Empty;
            glHelp.BackgroundGradientAngel = 0F;
            glHelp.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            glHelp.ForeColor = Color.Coral;
            glHelp.Location = new Point(192, 139);
            glHelp.Name = "glHelp";
            glHelp.Size = new Size(87, 40);
            glHelp.TabIndex = 2;
            glHelp.Text = "HELP";
            glHelp.TextColorBottom = Color.Yellow;
            glHelp.TextColorTop = Color.Yellow;
            glHelp.TextGradientAngel = 0F;
            glHelp.Click += glHelp_Click;
            // 
            // glCredit
            // 
            glCredit.AutoSize = true;
            glCredit.BackgroundColorBottom = Color.Empty;
            glCredit.BackgroundColorTop = Color.Empty;
            glCredit.BackgroundGradientAngel = 0F;
            glCredit.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            glCredit.ForeColor = Color.Coral;
            glCredit.Location = new Point(192, 204);
            glCredit.Name = "glCredit";
            glCredit.Size = new Size(116, 40);
            glCredit.TabIndex = 3;
            glCredit.Text = "CREDIT";
            glCredit.TextColorBottom = Color.Yellow;
            glCredit.TextColorTop = Color.Yellow;
            glCredit.TextGradientAngel = 0F;
            glCredit.Click += glCredit_Click;
            // 
            // glQuit
            // 
            glQuit.AutoSize = true;
            glQuit.BackgroundColorBottom = Color.Empty;
            glQuit.BackgroundColorTop = Color.Empty;
            glQuit.BackgroundGradientAngel = 0F;
            glQuit.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            glQuit.ForeColor = Color.Coral;
            glQuit.Location = new Point(192, 270);
            glQuit.Name = "glQuit";
            glQuit.Size = new Size(86, 40);
            glQuit.TabIndex = 4;
            glQuit.Text = "QUIT";
            glQuit.TextColorBottom = Color.Yellow;
            glQuit.TextColorTop = Color.Yellow;
            glQuit.TextGradientAngel = 0F;
            glQuit.Click += glQuit_Click;
            // 
            // frmMenuScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(67, 1, 1);
            ClientSize = new Size(531, 335);
            Controls.Add(glQuit);
            Controls.Add(glCredit);
            Controls.Add(glHelp);
            Controls.Add(glPlay);
            Controls.Add(glTitle);
            Name = "frmMenuScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMenuScreen";
            FormClosing += frmMenuScreen_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GradientLabel glTitle;
        private GradientLabel glPlay;
        private GradientLabel glHelp;
        private GradientLabel glCredit;
        private GradientLabel glQuit;
    }
}