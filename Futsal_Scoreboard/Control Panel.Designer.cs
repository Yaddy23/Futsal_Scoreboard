namespace Futsal_Scoreboard
{
    partial class Control_Panel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtFieldName = new TextBox();
            btnBuzzer = new Button();
            panel1 = new Panel();
            label2 = new Label();
            txtTeam1 = new TextBox();
            cmbT1 = new ComboBox();
            txtTeam2 = new TextBox();
            cmbT2 = new ComboBox();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            panel2 = new Panel();
            lblScoreT1 = new Label();
            btnT1Minus = new Button();
            btnT1Add = new Button();
            btnT2Add = new Button();
            panel3 = new Panel();
            lblScoreT2 = new Label();
            btnT2Minus = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            panel4 = new Panel();
            label3 = new Label();
            lblTimer = new Label();
            lblExtraTime = new Label();
            btnPauseTimer = new Button();
            btnStartTimer = new Button();
            btnResetTimer = new Button();
            label5 = new Label();
            btnStartTimeout = new Button();
            btnStopTimeout = new Button();
            panel5 = new Panel();
            label4 = new Label();
            checkBox1 = new CheckBox();
            textBox1 = new TextBox();
            btnPeriodMinus = new Button();
            panel6 = new Panel();
            lblPeriod = new Label();
            btnPeriodAdd = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(55, 23);
            label1.Name = "label1";
            label1.Size = new Size(111, 28);
            label1.TabIndex = 0;
            label1.Text = "Field Name";
            // 
            // txtFieldName
            // 
            txtFieldName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFieldName.Location = new Point(190, 23);
            txtFieldName.Name = "txtFieldName";
            txtFieldName.PlaceholderText = "Textfield (ad, info, etc)";
            txtFieldName.Size = new Size(669, 34);
            txtFieldName.TabIndex = 1;
            txtFieldName.TextAlign = HorizontalAlignment.Center;
            // 
            // btnBuzzer
            // 
            btnBuzzer.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuzzer.Location = new Point(878, 22);
            btnBuzzer.Name = "btnBuzzer";
            btnBuzzer.Size = new Size(114, 33);
            btnBuzzer.TabIndex = 2;
            btnBuzzer.Text = "Buzzer [B]";
            btnBuzzer.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(btnT2Minus);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(btnT2Add);
            panel1.Controls.Add(btnT1Add);
            panel1.Controls.Add(btnT1Minus);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(cmbT2);
            panel1.Controls.Add(txtTeam2);
            panel1.Controls.Add(cmbT1);
            panel1.Controls.Add(txtTeam1);
            panel1.Location = new Point(0, 106);
            panel1.Name = "panel1";
            panel1.Size = new Size(1356, 259);
            panel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 5);
            label2.Name = "label2";
            label2.Size = new Size(170, 28);
            label2.TabIndex = 4;
            label2.Text = "Team Data / Score";
            // 
            // txtTeam1
            // 
            txtTeam1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTeam1.Location = new Point(96, 42);
            txtTeam1.Name = "txtTeam1";
            txtTeam1.PlaceholderText = "Team Name";
            txtTeam1.Size = new Size(166, 34);
            txtTeam1.TabIndex = 5;
            txtTeam1.TextAlign = HorizontalAlignment.Center;
            // 
            // cmbT1
            // 
            cmbT1.BackColor = Color.LightGray;
            cmbT1.FormattingEnabled = true;
            cmbT1.Location = new Point(96, 87);
            cmbT1.Name = "cmbT1";
            cmbT1.Size = new Size(166, 28);
            cmbT1.TabIndex = 6;
            // 
            // txtTeam2
            // 
            txtTeam2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTeam2.Location = new Point(1076, 42);
            txtTeam2.Name = "txtTeam2";
            txtTeam2.PlaceholderText = "Team Name";
            txtTeam2.Size = new Size(166, 34);
            txtTeam2.TabIndex = 7;
            txtTeam2.TextAlign = HorizontalAlignment.Center;
            // 
            // cmbT2
            // 
            cmbT2.BackColor = Color.LightGray;
            cmbT2.FormattingEnabled = true;
            cmbT2.Location = new Point(1076, 87);
            cmbT2.Name = "cmbT2";
            cmbT2.Size = new Size(166, 28);
            cmbT2.TabIndex = 8;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(22, 136);
            button2.Name = "button2";
            button2.Size = new Size(114, 33);
            button2.TabIndex = 5;
            button2.Text = "Set Logo";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(219, 136);
            button1.Name = "button1";
            button1.Size = new Size(114, 33);
            button1.TabIndex = 9;
            button1.Text = "Set Logo";
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(119, 196);
            button3.Name = "button3";
            button3.Size = new Size(114, 33);
            button3.TabIndex = 10;
            button3.Text = "Reset";
            button3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.Controls.Add(lblScoreT1);
            panel2.Location = new Point(432, 48);
            panel2.Name = "panel2";
            panel2.Size = new Size(109, 195);
            panel2.TabIndex = 11;
            // 
            // lblScoreT1
            // 
            lblScoreT1.AutoSize = true;
            lblScoreT1.BackColor = Color.Transparent;
            lblScoreT1.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblScoreT1.Location = new Point(-4, 39);
            lblScoreT1.Name = "lblScoreT1";
            lblScoreT1.Size = new Size(132, 159);
            lblScoreT1.TabIndex = 12;
            lblScoreT1.Text = "0";
            // 
            // btnT1Minus
            // 
            btnT1Minus.BackColor = Color.LightGray;
            btnT1Minus.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnT1Minus.Location = new Point(350, 136);
            btnT1Minus.Margin = new Padding(0);
            btnT1Minus.Name = "btnT1Minus";
            btnT1Minus.Size = new Size(72, 49);
            btnT1Minus.TabIndex = 12;
            btnT1Minus.Text = "-1";
            btnT1Minus.UseVisualStyleBackColor = false;
            // 
            // btnT1Add
            // 
            btnT1Add.BackColor = Color.LawnGreen;
            btnT1Add.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnT1Add.Location = new Point(559, 108);
            btnT1Add.Margin = new Padding(0);
            btnT1Add.Name = "btnT1Add";
            btnT1Add.Size = new Size(94, 108);
            btnT1Add.TabIndex = 13;
            btnT1Add.Text = "+1 [Q]";
            btnT1Add.UseVisualStyleBackColor = false;
            // 
            // btnT2Add
            // 
            btnT2Add.BackColor = Color.LawnGreen;
            btnT2Add.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnT2Add.Location = new Point(693, 108);
            btnT2Add.Margin = new Padding(0);
            btnT2Add.Name = "btnT2Add";
            btnT2Add.Size = new Size(94, 108);
            btnT2Add.TabIndex = 14;
            btnT2Add.Text = "+1 [W]";
            btnT2Add.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Blue;
            panel3.Controls.Add(lblScoreT2);
            panel3.Location = new Point(808, 48);
            panel3.Name = "panel3";
            panel3.Size = new Size(109, 195);
            panel3.TabIndex = 13;
            // 
            // lblScoreT2
            // 
            lblScoreT2.AutoSize = true;
            lblScoreT2.BackColor = Color.Transparent;
            lblScoreT2.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblScoreT2.Location = new Point(-4, 43);
            lblScoreT2.Name = "lblScoreT2";
            lblScoreT2.Size = new Size(132, 159);
            lblScoreT2.TabIndex = 12;
            lblScoreT2.Text = "0";
            // 
            // btnT2Minus
            // 
            btnT2Minus.BackColor = Color.LightGray;
            btnT2Minus.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnT2Minus.Location = new Point(930, 136);
            btnT2Minus.Margin = new Padding(0);
            btnT2Minus.Name = "btnT2Minus";
            btnT2Minus.Size = new Size(72, 49);
            btnT2Minus.TabIndex = 15;
            btnT2Minus.Text = "-1";
            btnT2Minus.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(1117, 196);
            button4.Name = "button4";
            button4.Size = new Size(114, 33);
            button4.TabIndex = 18;
            button4.Text = "Reset";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(1217, 136);
            button5.Name = "button5";
            button5.Size = new Size(114, 33);
            button5.TabIndex = 17;
            button5.Text = "Set Logo";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Location = new Point(1020, 136);
            button6.Name = "button6";
            button6.Size = new Size(114, 33);
            button6.TabIndex = 16;
            button6.Text = "Set Logo";
            button6.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(btnStopTimeout);
            panel4.Controls.Add(btnStartTimeout);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(btnResetTimer);
            panel4.Controls.Add(btnStartTimer);
            panel4.Controls.Add(btnPauseTimer);
            panel4.Controls.Add(lblExtraTime);
            panel4.Controls.Add(lblTimer);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(0, 388);
            panel4.Name = "panel4";
            panel4.Size = new Size(1357, 150);
            panel4.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 9);
            label3.Name = "label3";
            label3.Size = new Size(54, 28);
            label3.TabIndex = 6;
            label3.Text = "Time";
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.BackColor = Color.PaleTurquoise;
            lblTimer.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTimer.Location = new Point(129, 22);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(234, 106);
            lblTimer.TabIndex = 19;
            lblTimer.Text = "45:00";
            // 
            // lblExtraTime
            // 
            lblExtraTime.AutoSize = true;
            lblExtraTime.BackColor = Color.PaleTurquoise;
            lblExtraTime.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblExtraTime.Location = new Point(369, 44);
            lblExtraTime.Name = "lblExtraTime";
            lblExtraTime.Size = new Size(98, 54);
            lblExtraTime.TabIndex = 20;
            lblExtraTime.Text = "1:00";
            // 
            // btnPauseTimer
            // 
            btnPauseTimer.BackColor = Color.Red;
            btnPauseTimer.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPauseTimer.Location = new Point(642, 23);
            btnPauseTimer.Margin = new Padding(0);
            btnPauseTimer.Name = "btnPauseTimer";
            btnPauseTimer.Size = new Size(118, 108);
            btnPauseTimer.TabIndex = 21;
            btnPauseTimer.Text = "Pause [P]";
            btnPauseTimer.UseVisualStyleBackColor = false;
            // 
            // btnStartTimer
            // 
            btnStartTimer.BackColor = Color.LawnGreen;
            btnStartTimer.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStartTimer.Location = new Point(503, 22);
            btnStartTimer.Margin = new Padding(0);
            btnStartTimer.Name = "btnStartTimer";
            btnStartTimer.Size = new Size(118, 108);
            btnStartTimer.TabIndex = 22;
            btnStartTimer.Text = "Start [S]";
            btnStartTimer.UseVisualStyleBackColor = false;
            // 
            // btnResetTimer
            // 
            btnResetTimer.BackColor = Color.LightGray;
            btnResetTimer.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnResetTimer.Location = new Point(777, 47);
            btnResetTimer.Margin = new Padding(0);
            btnResetTimer.Name = "btnResetTimer";
            btnResetTimer.Size = new Size(140, 57);
            btnResetTimer.TabIndex = 19;
            btnResetTimer.Text = "Reset";
            btnResetTimer.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(1085, 9);
            label5.Name = "label5";
            label5.Size = new Size(136, 41);
            label5.TabIndex = 19;
            label5.Text = "Timeout";
            label5.Click += label5_Click;
            // 
            // btnStartTimeout
            // 
            btnStartTimeout.BackColor = Color.LawnGreen;
            btnStartTimeout.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStartTimeout.Location = new Point(1037, 71);
            btnStartTimeout.Margin = new Padding(0);
            btnStartTimeout.Name = "btnStartTimeout";
            btnStartTimeout.Size = new Size(118, 55);
            btnStartTimeout.TabIndex = 23;
            btnStartTimeout.Text = "Start";
            btnStartTimeout.UseVisualStyleBackColor = false;
            // 
            // btnStopTimeout
            // 
            btnStopTimeout.BackColor = Color.Red;
            btnStopTimeout.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStopTimeout.Location = new Point(1176, 71);
            btnStopTimeout.Margin = new Padding(0);
            btnStopTimeout.Name = "btnStopTimeout";
            btnStopTimeout.Size = new Size(118, 55);
            btnStopTimeout.TabIndex = 24;
            btnStopTimeout.Text = "Stop";
            btnStopTimeout.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(btnPeriodAdd);
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(btnPeriodMinus);
            panel5.Controls.Add(textBox1);
            panel5.Controls.Add(checkBox1);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(0, 577);
            panel5.Name = "panel5";
            panel5.Size = new Size(1355, 154);
            panel5.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 9);
            label4.Name = "label4";
            label4.Size = new Size(68, 28);
            label4.TabIndex = 25;
            label4.Text = "Period";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(463, 65);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(109, 24);
            checkBox1.TabIndex = 26;
            checkBox1.Text = "Hide Period";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(594, 62);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Period 1";
            textBox1.Size = new Size(166, 34);
            textBox1.TabIndex = 19;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // btnPeriodMinus
            // 
            btnPeriodMinus.BackColor = Color.LightGray;
            btnPeriodMinus.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPeriodMinus.Location = new Point(787, 56);
            btnPeriodMinus.Margin = new Padding(0);
            btnPeriodMinus.Name = "btnPeriodMinus";
            btnPeriodMinus.Size = new Size(72, 49);
            btnPeriodMinus.TabIndex = 19;
            btnPeriodMinus.Text = "-1";
            btnPeriodMinus.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Yellow;
            panel6.Controls.Add(lblPeriod);
            panel6.Location = new Point(878, 28);
            panel6.Name = "panel6";
            panel6.Size = new Size(104, 98);
            panel6.TabIndex = 27;
            // 
            // lblPeriod
            // 
            lblPeriod.AutoSize = true;
            lblPeriod.BackColor = Color.Transparent;
            lblPeriod.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPeriod.Location = new Point(22, 8);
            lblPeriod.Name = "lblPeriod";
            lblPeriod.Size = new Size(67, 81);
            lblPeriod.TabIndex = 28;
            lblPeriod.Text = "0";
            // 
            // btnPeriodAdd
            // 
            btnPeriodAdd.BackColor = Color.LawnGreen;
            btnPeriodAdd.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPeriodAdd.Location = new Point(1003, 33);
            btnPeriodAdd.Margin = new Padding(0);
            btnPeriodAdd.Name = "btnPeriodAdd";
            btnPeriodAdd.Size = new Size(108, 79);
            btnPeriodAdd.TabIndex = 25;
            btnPeriodAdd.Text = "+1";
            btnPeriodAdd.UseVisualStyleBackColor = false;
            // 
            // Control_Panel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(btnBuzzer);
            Controls.Add(txtFieldName);
            Controls.Add(label1);
            Name = "Control_Panel";
            Size = new Size(1355, 753);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFieldName;
        private Button btnBuzzer;
        private Panel panel1;
        private Label label2;
        private TextBox txtTeam1;
        private Button button2;
        private ComboBox cmbT2;
        private TextBox txtTeam2;
        private ComboBox cmbT1;
        private Button button3;
        private Button button1;
        private Button btnT1Minus;
        private Panel panel2;
        private Label lblScoreT1;
        private Button btnT1Add;
        private Button btnT2Minus;
        private Panel panel3;
        private Label lblScoreT2;
        private Button btnT2Add;
        private Button button4;
        private Button button5;
        private Button button6;
        private Panel panel4;
        private Label lblTimer;
        private Label label3;
        private Label label5;
        private Button btnResetTimer;
        private Button btnStartTimer;
        private Button btnPauseTimer;
        private Label lblExtraTime;
        private Button btnStopTimeout;
        private Button btnStartTimeout;
        private Panel panel5;
        private TextBox textBox1;
        private CheckBox checkBox1;
        private Label label4;
        private Button btnPeriodAdd;
        private Panel panel6;
        private Label lblPeriod;
        private Button btnPeriodMinus;
    }
}
