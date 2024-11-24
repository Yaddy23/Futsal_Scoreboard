namespace Futsal_Scoreboard
{
    partial class Teams
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
            dataGridView1 = new DataGridView();
            btnRemoveTeam = new Button();
            btnAddTeam = new Button();
            txtTeam = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(156, 48);
            label1.Name = "label1";
            label1.Size = new Size(65, 28);
            label1.TabIndex = 0;
            label1.Text = "Teams";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 97);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(341, 333);
            dataGridView1.TabIndex = 1;
            // 
            // btnRemoveTeam
            // 
            btnRemoveTeam.Font = new Font("Segoe UI", 12F);
            btnRemoveTeam.Location = new Point(73, 436);
            btnRemoveTeam.Name = "btnRemoveTeam";
            btnRemoveTeam.Size = new Size(236, 40);
            btnRemoveTeam.TabIndex = 2;
            btnRemoveTeam.Text = "Remove Selected Team";
            btnRemoveTeam.UseVisualStyleBackColor = true;
            // 
            // btnAddTeam
            // 
            btnAddTeam.Font = new Font("Segoe UI", 12F);
            btnAddTeam.Location = new Point(73, 518);
            btnAddTeam.Name = "btnAddTeam";
            btnAddTeam.Size = new Size(236, 37);
            btnAddTeam.TabIndex = 3;
            btnAddTeam.Text = "Add";
            btnAddTeam.UseVisualStyleBackColor = true;
            // 
            // txtTeam
            // 
            txtTeam.Font = new Font("Segoe UI", 12F);
            txtTeam.Location = new Point(73, 478);
            txtTeam.Name = "txtTeam";
            txtTeam.Size = new Size(236, 34);
            txtTeam.TabIndex = 4;
            // 
            // Teams
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtTeam);
            Controls.Add(btnAddTeam);
            Controls.Add(btnRemoveTeam);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Teams";
            Size = new Size(394, 564);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button btnRemoveTeam;
        private Button btnAddTeam;
        private TextBox txtTeam;
    }
}
