namespace EmployeeManagement
{
    partial class MainForm
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
            panel1 = new Panel();
            label1 = new Label();
            exit = new Label();
            panel2 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            salary1 = new Salary();
            dashboard1 = new Dashboard();
            dashboard2 = new Dashboard();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(75, 8, 138);
            panel1.Controls.Add(dashboard1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(exit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1190, 51);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(183, 21);
            label1.TabIndex = 1;
            label1.Text = "Employee Management";
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exit.ForeColor = Color.White;
            exit.Location = new Point(1156, 13);
            exit.Name = "exit";
            exit.Size = new Size(22, 24);
            exit.TabIndex = 0;
            exit.Text = "X";
            exit.Click += exit_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(75, 8, 138);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 51);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 575);
            panel2.TabIndex = 1;
            // 
            // button4
            // 
            button4.Location = new Point(105, 454);
            button4.Name = "button4";
            button4.Size = new Size(74, 43);
            button4.TabIndex = 6;
            button4.Text = "Sign out";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(69, 325);
            button3.Name = "button3";
            button3.Size = new Size(149, 44);
            button3.TabIndex = 5;
            button3.Text = "SALARY";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(69, 256);
            button2.Name = "button2";
            button2.Size = new Size(149, 44);
            button2.TabIndex = 4;
            button2.Text = "ADD EMPLOYEE";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(69, 183);
            button1.Name = "button1";
            button1.Size = new Size(149, 44);
            button1.TabIndex = 3;
            button1.Text = "DASHBOAD";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(69, 114);
            label2.Name = "label2";
            label2.Size = new Size(149, 24);
            label2.TabIndex = 2;
            label2.Text = "Welcome, user!";
            // 
            // salary1
            // 
            salary1.Location = new Point(306, 57);
            salary1.Name = "salary1";
            salary1.Size = new Size(872, 557);
            salary1.TabIndex = 2;
            // 
            // dashboard1
            // 
            dashboard1.Location = new Point(59, 13);
            dashboard1.Name = "dashboard1";
            dashboard1.Size = new Size(1035, 693);
            dashboard1.TabIndex = 2;
            // 
            // dashboard2
            // 
            dashboard2.Location = new Point(306, 57);
            dashboard2.Name = "dashboard2";
            dashboard2.Size = new Size(872, 557);
            dashboard2.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1190, 626);
            Controls.Add(dashboard2);
            Controls.Add(salary1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label exit;
        private Label label1;
        private Panel panel2;
        private Button button1;
        private Label label2;
        private Button button4;
        private Button button3;
        private Button button2;
        private Salary salary1;
        private Dashboard dashboard1;
        private Dashboard dashboard2;
    }
}