namespace Futsal_Scoreboard
{
    partial class Scoreboard
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
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblT1Foul = new Label();
            lblPeriod = new Label();
            lblT2Foul = new Label();
            pbTeamOne = new PictureBox();
            pbTeamTwo = new PictureBox();
            lblTeamOne = new Label();
            lblTeamTwo = new Label();
            label10 = new Label();
            lblTimeout = new Label();
            lblTimer = new Label();
            panel4 = new Panel();
            lblT1Score = new Label();
            panel5 = new Panel();
            lblT2Score = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbTeamOne).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbTeamTwo).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Khaki;
            label1.Location = new Point(409, -4);
            label1.Name = "label1";
            label1.Size = new Size(366, 81);
            label1.TabIndex = 0;
            label1.Text = "Arena Name";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(lblT1Foul);
            panel1.Location = new Point(361, 157);
            panel1.Name = "panel1";
            panel1.Size = new Size(143, 133);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.Khaki;
            panel2.Controls.Add(lblPeriod);
            panel2.Location = new Point(521, 157);
            panel2.Name = "panel2";
            panel2.Size = new Size(143, 133);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.Red;
            panel3.Controls.Add(lblT2Foul);
            panel3.Location = new Point(682, 157);
            panel3.Name = "panel3";
            panel3.Size = new Size(143, 133);
            panel3.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(382, 94);
            label2.Name = "label2";
            label2.Size = new Size(108, 60);
            label2.TabIndex = 3;
            label2.Text = "Foul";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Khaki;
            label3.Location = new Point(520, 94);
            label3.Name = "label3";
            label3.Size = new Size(149, 60);
            label3.TabIndex = 4;
            label3.Text = "Period";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(702, 94);
            label4.Name = "label4";
            label4.Size = new Size(108, 60);
            label4.TabIndex = 5;
            label4.Text = "Foul";
            // 
            // lblT1Foul
            // 
            lblT1Foul.AutoSize = true;
            lblT1Foul.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblT1Foul.Location = new Point(32, 12);
            lblT1Foul.Name = "lblT1Foul";
            lblT1Foul.Size = new Size(88, 106);
            lblT1Foul.TabIndex = 6;
            lblT1Foul.Text = "0";
            // 
            // lblPeriod
            // 
            lblPeriod.AutoSize = true;
            lblPeriod.BackColor = Color.Transparent;
            lblPeriod.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPeriod.Location = new Point(29, 12);
            lblPeriod.Name = "lblPeriod";
            lblPeriod.Size = new Size(88, 106);
            lblPeriod.TabIndex = 7;
            lblPeriod.Text = "0";
            // 
            // lblT2Foul
            // 
            lblT2Foul.AutoSize = true;
            lblT2Foul.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblT2Foul.Location = new Point(30, 12);
            lblT2Foul.Name = "lblT2Foul";
            lblT2Foul.Size = new Size(88, 106);
            lblT2Foul.TabIndex = 8;
            lblT2Foul.Text = "0";
            // 
            // pbTeamOne
            // 
            pbTeamOne.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbTeamOne.BackColor = SystemColors.Highlight;
            pbTeamOne.Location = new Point(24, 216);
            pbTeamOne.Name = "pbTeamOne";
            pbTeamOne.Size = new Size(270, 231);
            pbTeamOne.TabIndex = 6;
            pbTeamOne.TabStop = false;
            // 
            // pbTeamTwo
            // 
            pbTeamTwo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbTeamTwo.BackColor = Color.Red;
            pbTeamTwo.Location = new Point(899, 216);
            pbTeamTwo.Name = "pbTeamTwo";
            pbTeamTwo.Size = new Size(270, 231);
            pbTeamTwo.TabIndex = 7;
            pbTeamTwo.TabStop = false;
            // 
            // lblTeamOne
            // 
            lblTeamOne.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTeamOne.AutoSize = true;
            lblTeamOne.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTeamOne.ForeColor = Color.White;
            lblTeamOne.Location = new Point(75, 450);
            lblTeamOne.Name = "lblTeamOne";
            lblTeamOne.Size = new Size(167, 60);
            lblTeamOne.TabIndex = 8;
            lblTeamOne.Text = "Team A";
            lblTeamOne.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTeamTwo
            // 
            lblTeamTwo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTeamTwo.AutoSize = true;
            lblTeamTwo.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTeamTwo.ForeColor = Color.White;
            lblTeamTwo.Location = new Point(958, 450);
            lblTeamTwo.Name = "lblTeamTwo";
            lblTeamTwo.Size = new Size(164, 60);
            lblTeamTwo.TabIndex = 9;
            lblTeamTwo.Text = "Team B";
            lblTeamTwo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Khaki;
            label10.Location = new Point(499, 493);
            label10.Name = "label10";
            label10.Size = new Size(186, 60);
            label10.TabIndex = 10;
            label10.Text = "Timeout";
            // 
            // lblTimeout
            // 
            lblTimeout.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTimeout.AutoSize = true;
            lblTimeout.BackColor = Color.Khaki;
            lblTimeout.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTimeout.Location = new Point(503, 553);
            lblTimeout.Name = "lblTimeout";
            lblTimeout.Size = new Size(176, 81);
            lblTimeout.TabIndex = 11;
            lblTimeout.Text = "01:20";
            lblTimeout.Click += label11_Click;
            // 
            // lblTimer
            // 
            lblTimer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTimer.AutoSize = true;
            lblTimer.BackColor = Color.Transparent;
            lblTimer.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTimer.ForeColor = Color.White;
            lblTimer.Location = new Point(409, 635);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(376, 159);
            lblTimer.TabIndex = 12;
            lblTimer.Text = "45:00";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = SystemColors.Highlight;
            panel4.Controls.Add(lblT1Score);
            panel4.Location = new Point(42, 564);
            panel4.Name = "panel4";
            panel4.Size = new Size(233, 205);
            panel4.TabIndex = 7;
            // 
            // lblT1Score
            // 
            lblT1Score.AutoSize = true;
            lblT1Score.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblT1Score.ForeColor = Color.White;
            lblT1Score.Location = new Point(54, 24);
            lblT1Score.Name = "lblT1Score";
            lblT1Score.Size = new Size(132, 159);
            lblT1Score.TabIndex = 6;
            lblT1Score.Text = "0";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel5.BackColor = Color.Red;
            panel5.Controls.Add(lblT2Score);
            panel5.Location = new Point(925, 564);
            panel5.Name = "panel5";
            panel5.Size = new Size(233, 205);
            panel5.TabIndex = 8;
            // 
            // lblT2Score
            // 
            lblT2Score.AutoSize = true;
            lblT2Score.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblT2Score.ForeColor = Color.White;
            lblT2Score.Location = new Point(60, 25);
            lblT2Score.Name = "lblT2Score";
            lblT2Score.Size = new Size(132, 159);
            lblT2Score.TabIndex = 6;
            lblT2Score.Text = "0";
            // 
            // Scoreboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1192, 803);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(lblTimer);
            Controls.Add(lblTimeout);
            Controls.Add(label10);
            Controls.Add(lblTeamTwo);
            Controls.Add(lblTeamOne);
            Controls.Add(pbTeamTwo);
            Controls.Add(pbTeamOne);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Scoreboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbTeamOne).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbTeamTwo).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblT1Foul;
        private Label lblPeriod;
        private Label lblT2Foul;
        private PictureBox pbTeamOne;
        private PictureBox pbTeamTwo;
        private Label lblTeamOne;
        private Label lblTeamTwo;
        private Label label10;
        private Label lblTimeout;
        private Label lblTimer;
        private Panel panel4;
        private Label lblT1Score;
        private Panel panel5;
        private Label lblT2Score;
    }
}