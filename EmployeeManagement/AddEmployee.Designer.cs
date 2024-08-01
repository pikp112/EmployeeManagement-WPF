namespace EmployeeManagement
{
    partial class AddEmployee
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
            panel2 = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            textBox3 = new TextBox();
            label5 = new Label();
            comboBox2 = new ComboBox();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(833, 250);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(button8);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 283);
            panel2.Name = "panel2";
            panel2.Size = new Size(833, 223);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 16);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 0;
            label1.Text = "Employee's Data";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(20, 39);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(792, 188);
            dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 14);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 2;
            label2.Text = "Employee ID";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(120, 14);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(191, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(120, 59);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(191, 27);
            textBox2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 59);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 4;
            label3.Text = "Full name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 108);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 6;
            label4.Text = "Gender";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female", "Others" });
            comboBox1.Location = new Point(120, 105);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(86, 28);
            comboBox1.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(449, 14);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(191, 27);
            textBox3.TabIndex = 9;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(338, 14);
            label5.Name = "label5";
            label5.Size = new Size(105, 20);
            label5.TabIndex = 8;
            label5.Text = "Phone number";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Male", "Female", "Others" });
            comboBox2.Location = new Point(449, 58);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(86, 28);
            comboBox2.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(386, 59);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 10;
            label6.Text = "Gender";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(687, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 85);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(33, 11, 97);
            button1.ForeColor = Color.White;
            button1.Location = new Point(687, 124);
            button1.Name = "button1";
            button1.Size = new Size(125, 29);
            button1.TabIndex = 13;
            button1.Text = "Import";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDark;
            button2.FlatAppearance.CheckedBackColor = Color.FromArgb(33, 11, 97);
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 11, 97);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 11, 97);
            button2.Location = new Point(150, 162);
            button2.Name = "button2";
            button2.Size = new Size(94, 36);
            button2.TabIndex = 14;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlDark;
            button3.FlatAppearance.CheckedBackColor = Color.FromArgb(33, 11, 97);
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 11, 97);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 11, 97);
            button3.Location = new Point(274, 162);
            button3.Name = "button3";
            button3.Size = new Size(94, 36);
            button3.TabIndex = 15;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(33, 11, 97);
            button4.FlatAppearance.CheckedBackColor = Color.FromArgb(33, 11, 97);
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 11, 97);
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 11, 97);
            button4.ForeColor = Color.White;
            button4.Location = new Point(505, 162);
            button4.Name = "button4";
            button4.Size = new Size(94, 36);
            button4.TabIndex = 16;
            button4.Text = "Add";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ControlDark;
            button5.FlatAppearance.CheckedBackColor = Color.FromArgb(33, 11, 97);
            button5.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 11, 97);
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 11, 97);
            button5.Location = new Point(386, 162);
            button5.Name = "button5";
            button5.Size = new Size(94, 36);
            button5.TabIndex = 17;
            button5.Text = "Add";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(33, 11, 97);
            button6.FlatAppearance.CheckedBackColor = Color.FromArgb(33, 11, 97);
            button6.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 11, 97);
            button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 11, 97);
            button6.ForeColor = Color.White;
            button6.Location = new Point(150, 162);
            button6.Name = "button6";
            button6.Size = new Size(94, 36);
            button6.TabIndex = 14;
            button6.Text = "Add";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(33, 11, 97);
            button7.FlatAppearance.CheckedBackColor = Color.FromArgb(33, 11, 97);
            button7.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 11, 97);
            button7.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 11, 97);
            button7.ForeColor = Color.White;
            button7.Location = new Point(274, 162);
            button7.Name = "button7";
            button7.Size = new Size(94, 36);
            button7.TabIndex = 15;
            button7.Text = "Add";
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(33, 11, 97);
            button8.FlatAppearance.CheckedBackColor = Color.FromArgb(33, 11, 97);
            button8.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 11, 97);
            button8.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 11, 97);
            button8.ForeColor = Color.White;
            button8.Location = new Point(386, 162);
            button8.Name = "button8";
            button8.Size = new Size(94, 36);
            button8.TabIndex = 17;
            button8.Text = "Add";
            button8.UseVisualStyleBackColor = false;
            // 
            // AddEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 518);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AddEmployee";
            Text = "AddEmployee";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private TextBox textBox3;
        private Label label5;
        private ComboBox comboBox1;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
        private ComboBox comboBox2;
        private Label label6;
        private Button button8;
        private Button button7;
        private Button button6;
    }
}