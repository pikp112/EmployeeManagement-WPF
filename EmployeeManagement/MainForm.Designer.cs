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
            dashboard1 = new Dashboard();
            label1 = new Label();
            exit = new Label();
            panel2 = new Panel();
            logout_btn = new Button();
            salary_btn = new Button();
            addemployee_btn = new Button();
            dashboard_btn = new Button();
            label2 = new Label();
            salary1 = new Salary();
            dashboard2 = new Dashboard();
            addEmployee1 = new AddEmployee();
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
            // dashboard1
            // 
            dashboard1.Location = new Point(59, 13);
            dashboard1.Name = "dashboard1";
            dashboard1.Size = new Size(1035, 693);
            dashboard1.TabIndex = 2;
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
            panel2.Controls.Add(logout_btn);
            panel2.Controls.Add(salary_btn);
            panel2.Controls.Add(addemployee_btn);
            panel2.Controls.Add(dashboard_btn);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 51);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 575);
            panel2.TabIndex = 1;
            // 
            // logout_btn
            // 
            logout_btn.Location = new Point(105, 454);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(74, 43);
            logout_btn.TabIndex = 6;
            logout_btn.Text = "Sign out";
            logout_btn.UseVisualStyleBackColor = true;
            logout_btn.Click += button4_Click;
            // 
            // salary_btn
            // 
            salary_btn.Location = new Point(69, 325);
            salary_btn.Name = "salary_btn";
            salary_btn.Size = new Size(149, 44);
            salary_btn.TabIndex = 5;
            salary_btn.Text = "SALARY";
            salary_btn.UseVisualStyleBackColor = true;
            salary_btn.Click += salary_btn_Click;
            // 
            // addemployee_btn
            // 
            addemployee_btn.Location = new Point(69, 256);
            addemployee_btn.Name = "addemployee_btn";
            addemployee_btn.Size = new Size(149, 44);
            addemployee_btn.TabIndex = 4;
            addemployee_btn.Text = "ADD EMPLOYEE";
            addemployee_btn.UseVisualStyleBackColor = true;
            addemployee_btn.Click += addemployee_btn_Click;
            // 
            // dashboard_btn
            // 
            dashboard_btn.Location = new Point(69, 183);
            dashboard_btn.Name = "dashboard_btn";
            dashboard_btn.Size = new Size(149, 44);
            dashboard_btn.TabIndex = 3;
            dashboard_btn.Text = "DASHBOARD";
            dashboard_btn.UseVisualStyleBackColor = true;
            dashboard_btn.Click += button1_Click;
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
            // dashboard2
            // 
            dashboard2.Location = new Point(306, 57);
            dashboard2.Name = "dashboard2";
            dashboard2.Size = new Size(872, 557);
            dashboard2.TabIndex = 3;
            // 
            // addEmployee1
            // 
            addEmployee1.Location = new Point(306, 57);
            addEmployee1.Name = "addEmployee1";
            addEmployee1.Size = new Size(872, 557);
            addEmployee1.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1190, 626);
            Controls.Add(addEmployee1);
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
        private Button dashboard_btn;
        private Label label2;
        private Button logout_btn;
        private Button salary_btn;
        private Button addemployee_btn;
        private Salary salary1;
        private Dashboard dashboard1;
        private Dashboard dashboard2;
        private AddEmployee addEmployee1;
    }
}