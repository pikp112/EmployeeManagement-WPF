namespace EmployeeManagement
{
    partial class Dashboard
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
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(20, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(827, 157);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Location = new Point(20, 197);
            panel2.Name = "panel2";
            panel2.Size = new Size(827, 353);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(75, 8, 138);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(17, 15);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 125);
            panel3.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(75, 8, 138);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(289, 15);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 125);
            panel4.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(75, 8, 138);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(560, 15);
            panel5.Name = "panel5";
            panel5.Size = new Size(250, 125);
            panel5.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(40, 70);
            label1.Name = "label1";
            label1.Size = new Size(158, 24);
            label1.TabIndex = 0;
            label1.Text = "Total Employees";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(46, 70);
            label2.Name = "label2";
            label2.Size = new Size(166, 24);
            label2.TabIndex = 1;
            label2.Text = "Active Employees";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(44, 70);
            label3.Name = "label3";
            label3.Size = new Size(183, 24);
            label3.TabIndex = 2;
            label3.Text = "Inactive Employees";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(108, 22);
            label4.Name = "label4";
            label4.Size = new Size(21, 24);
            label4.TabIndex = 1;
            label4.Text = "0";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(120, 22);
            label5.Name = "label5";
            label5.Size = new Size(21, 24);
            label5.TabIndex = 2;
            label5.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(118, 22);
            label6.Name = "label6";
            label6.Size = new Size(21, 24);
            label6.TabIndex = 3;
            label6.Text = "0";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Dashboard";
            Size = new Size(875, 565);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private Label label2;
        private Panel panel5;
        private Label label3;
        private Panel panel3;
        private Label label4;
        private Label label1;
        private Panel panel2;
        private Label label5;
        private Label label6;
    }
}
