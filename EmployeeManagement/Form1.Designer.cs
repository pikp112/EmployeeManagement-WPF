namespace EmployeeManagement
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label6 = new Label();
            login_signupBtn = new Button();
            label5 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            login_username = new MaskedTextBox();
            login_showPassword = new CheckBox();
            login_btn = new Button();
            login_password = new MaskedTextBox();
            label7 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(75, 8, 138);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(login_signupBtn);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(319, 353);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(29, 146);
            label6.Name = "label6";
            label6.Size = new Size(248, 28);
            label6.TabIndex = 8;
            label6.Text = "Employee Management";
            label6.Click += label6_Click;
            // 
            // login_signupBtn
            // 
            login_signupBtn.BackColor = Color.FromArgb(33, 11, 97);
            login_signupBtn.Cursor = Cursors.Hand;
            login_signupBtn.FlatAppearance.BorderSize = 0;
            login_signupBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 192);
            login_signupBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 192);
            login_signupBtn.FlatStyle = FlatStyle.Flat;
            login_signupBtn.ForeColor = Color.White;
            login_signupBtn.Location = new Point(88, 294);
            login_signupBtn.Name = "login_signupBtn";
            login_signupBtn.Size = new Size(94, 29);
            login_signupBtn.TabIndex = 8;
            login_signupBtn.Text = "SIGNUP";
            login_signupBtn.UseVisualStyleBackColor = false;
            login_signupBtn.Click += login_signupBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(52, 258);
            label5.Name = "label5";
            label5.Size = new Size(172, 21);
            label5.TabIndex = 8;
            label5.Text = "Register your account";
            label5.Click += label5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(596, 9);
            label1.Name = "label1";
            label1.Size = new Size(22, 24);
            label1.TabIndex = 0;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(393, 67);
            label2.Name = "label2";
            label2.Size = new Size(155, 28);
            label2.TabIndex = 1;
            label2.Text = "Login Account";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10F);
            label3.Location = new Point(339, 129);
            label3.Name = "label3";
            label3.Size = new Size(85, 21);
            label3.TabIndex = 2;
            label3.Text = "Username";
            label3.Click += label3_Click;
            // 
            // login_username
            // 
            login_username.Location = new Point(339, 153);
            login_username.Name = "login_username";
            login_username.Size = new Size(279, 27);
            login_username.TabIndex = 3;
            login_username.MaskInputRejected += login_username_MaskInputRejected;
            // 
            // login_showPassword
            // 
            login_showPassword.AutoSize = true;
            login_showPassword.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_showPassword.Location = new Point(488, 249);
            login_showPassword.Name = "login_showPassword";
            login_showPassword.Size = new Size(130, 22);
            login_showPassword.TabIndex = 6;
            login_showPassword.Text = "Show password";
            login_showPassword.UseVisualStyleBackColor = true;
            login_showPassword.CheckedChanged += login_showPassword_CheckedChanged;
            // 
            // login_btn
            // 
            login_btn.Cursor = Cursors.Hand;
            login_btn.Location = new Point(424, 297);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(94, 29);
            login_btn.TabIndex = 7;
            login_btn.Text = "LOGIN";
            login_btn.UseVisualStyleBackColor = true;
            login_btn.Click += login_btn_Click;
            // 
            // login_password
            // 
            login_password.Location = new Point(339, 216);
            login_password.Name = "login_password";
            login_password.PasswordChar = '*';
            login_password.Size = new Size(279, 27);
            login_password.TabIndex = 5;
            login_password.MaskInputRejected += maskedTextBox2_MaskInputRejected;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(339, 193);
            label7.Name = "label7";
            label7.Size = new Size(81, 21);
            label7.TabIndex = 9;
            label7.Text = "Password";
            label7.Click += label7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(630, 353);
            Controls.Add(label7);
            Controls.Add(login_btn);
            Controls.Add(login_showPassword);
            Controls.Add(login_password);
            Controls.Add(login_username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private MaskedTextBox login_username;
        private CheckBox login_showPassword;
        private Button login_btn;
        private Label label5;
        private Button login_signupBtn;
        private Label label6;
        private MaskedTextBox login_password;
        private Label label7;
    }
}
