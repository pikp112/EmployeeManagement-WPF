namespace EmployeeManagement
{
    partial class RegisterForm
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
            label7 = new Label();
            signup_btn = new Button();
            signup_showPassword = new CheckBox();
            signup_password = new MaskedTextBox();
            signup_username = new MaskedTextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            signup_loginBtn = new Button();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(339, 191);
            label7.Name = "label7";
            label7.Size = new Size(81, 21);
            label7.TabIndex = 18;
            label7.Text = "Password";
            // 
            // signup_btn
            // 
            signup_btn.Cursor = Cursors.Hand;
            signup_btn.Location = new Point(424, 295);
            signup_btn.Name = "signup_btn";
            signup_btn.Size = new Size(94, 29);
            signup_btn.TabIndex = 17;
            signup_btn.Text = "SIGNUP";
            signup_btn.UseVisualStyleBackColor = true;
            signup_btn.Click += signup_btn_Click;
            // 
            // signup_showPassword
            // 
            signup_showPassword.AutoSize = true;
            signup_showPassword.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_showPassword.Location = new Point(488, 247);
            signup_showPassword.Name = "signup_showPassword";
            signup_showPassword.Size = new Size(130, 22);
            signup_showPassword.TabIndex = 16;
            signup_showPassword.Text = "Show password";
            signup_showPassword.UseVisualStyleBackColor = true;
            signup_showPassword.CheckedChanged += signup_showPassword_CheckedChanged;
            // 
            // signup_password
            // 
            signup_password.Location = new Point(339, 214);
            signup_password.Name = "signup_password";
            signup_password.PasswordChar = '*';
            signup_password.Size = new Size(279, 27);
            signup_password.TabIndex = 15;
            // 
            // signup_username
            // 
            signup_username.Location = new Point(339, 151);
            signup_username.Name = "signup_username";
            signup_username.Size = new Size(279, 27);
            signup_username.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10F);
            label3.Location = new Point(339, 127);
            label3.Name = "label3";
            label3.Size = new Size(85, 21);
            label3.TabIndex = 13;
            label3.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(393, 65);
            label2.Name = "label2";
            label2.Size = new Size(183, 28);
            label2.TabIndex = 12;
            label2.Text = "Register Account";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(596, 7);
            label1.Name = "label1";
            label1.Size = new Size(22, 24);
            label1.TabIndex = 10;
            label1.Text = "X";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(75, 8, 138);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(signup_loginBtn);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(319, 353);
            panel1.TabIndex = 11;
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
            // 
            // signup_loginBtn
            // 
            signup_loginBtn.BackColor = Color.FromArgb(33, 11, 97);
            signup_loginBtn.Cursor = Cursors.Hand;
            signup_loginBtn.FlatAppearance.BorderSize = 0;
            signup_loginBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 192);
            signup_loginBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 192);
            signup_loginBtn.FlatStyle = FlatStyle.Flat;
            signup_loginBtn.ForeColor = Color.White;
            signup_loginBtn.Location = new Point(88, 294);
            signup_loginBtn.Name = "signup_loginBtn";
            signup_loginBtn.Size = new Size(94, 29);
            signup_loginBtn.TabIndex = 8;
            signup_loginBtn.Text = "SIGNUP";
            signup_loginBtn.UseVisualStyleBackColor = false;
            signup_loginBtn.Click += signup_loginBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(52, 258);
            label5.Name = "label5";
            label5.Size = new Size(149, 21);
            label5.TabIndex = 8;
            label5.Text = "Login your account";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 353);
            Controls.Add(label7);
            Controls.Add(signup_btn);
            Controls.Add(signup_showPassword);
            Controls.Add(signup_password);
            Controls.Add(signup_username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Button signup_btn;
        private CheckBox signup_showPassword;
        private MaskedTextBox signup_password;
        private MaskedTextBox signup_username;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Label label6;
        private Button signup_loginBtn;
        private Label label5;
    }
}