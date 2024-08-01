namespace EmployeeManagement
{
    partial class Salary
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
            salary_clear_btn = new Button();
            salary_update_btn = new Button();
            salary_salary = new MaskedTextBox();
            label5 = new Label();
            salary_position = new MaskedTextBox();
            label4 = new Label();
            salary_name = new MaskedTextBox();
            label3 = new Label();
            salary_employeeId = new MaskedTextBox();
            label2 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(salary_clear_btn);
            panel1.Controls.Add(salary_update_btn);
            panel1.Controls.Add(salary_salary);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(salary_position);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(salary_name);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(salary_employeeId);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(19, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(247, 528);
            panel1.TabIndex = 0;
            // 
            // salary_clear_btn
            // 
            salary_clear_btn.BackColor = Color.FromArgb(33, 11, 97);
            salary_clear_btn.FlatAppearance.CheckedBackColor = Color.FromArgb(33, 11, 97);
            salary_clear_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 11, 97);
            salary_clear_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 11, 97);
            salary_clear_btn.ForeColor = Color.White;
            salary_clear_btn.Location = new Point(135, 398);
            salary_clear_btn.Name = "salary_clear_btn";
            salary_clear_btn.Size = new Size(94, 36);
            salary_clear_btn.TabIndex = 16;
            salary_clear_btn.Text = "Clear";
            salary_clear_btn.UseVisualStyleBackColor = false;
            // 
            // salary_update_btn
            // 
            salary_update_btn.BackColor = Color.FromArgb(33, 11, 97);
            salary_update_btn.FlatAppearance.CheckedBackColor = Color.FromArgb(33, 11, 97);
            salary_update_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 11, 97);
            salary_update_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 11, 97);
            salary_update_btn.ForeColor = Color.White;
            salary_update_btn.Location = new Point(19, 398);
            salary_update_btn.Name = "salary_update_btn";
            salary_update_btn.Size = new Size(94, 36);
            salary_update_btn.TabIndex = 15;
            salary_update_btn.Text = "Update";
            salary_update_btn.UseVisualStyleBackColor = false;
            // 
            // salary_salary
            // 
            salary_salary.Location = new Point(19, 342);
            salary_salary.Name = "salary_salary";
            salary_salary.Size = new Size(210, 27);
            salary_salary.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 309);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 8;
            label5.Text = "Salary";
            // 
            // salary_position
            // 
            salary_position.Location = new Point(19, 263);
            salary_position.Name = "salary_position";
            salary_position.Size = new Size(210, 27);
            salary_position.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 230);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 6;
            label4.Text = "Position";
            // 
            // salary_name
            // 
            salary_name.Location = new Point(19, 183);
            salary_name.Name = "salary_name";
            salary_name.Size = new Size(210, 27);
            salary_name.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 150);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 4;
            label3.Text = "Full name";
            // 
            // salary_employeeId
            // 
            salary_employeeId.Location = new Point(19, 101);
            salary_employeeId.Name = "salary_employeeId";
            salary_employeeId.Size = new Size(210, 27);
            salary_employeeId.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 68);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 2;
            label2.Text = "Employee ID";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(284, 15);
            panel2.Name = "panel2";
            panel2.Size = new Size(572, 528);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(18, 68);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(538, 441);
            dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 15);
            label1.Name = "label1";
            label1.Size = new Size(128, 31);
            label1.TabIndex = 0;
            label1.Text = "Employees";
            // 
            // Salary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Salary";
            Size = new Size(875, 565);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label1;
        private MaskedTextBox salary_salary;
        private Label label5;
        private MaskedTextBox salary_position;
        private Label label4;
        private MaskedTextBox salary_name;
        private Label label3;
        private MaskedTextBox salary_employeeId;
        private Button button2;
        private Button button3;
        private Button salary_clear_btn;
        private Button salary_update_btn;
    }
}
