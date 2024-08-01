using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class AddEmployee : UserControl
    {
        private SqlConnection sqlConnection = new(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\H3XM\OneDrive - Eurofins IT-ST07\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30");

        public AddEmployee()
        {
            InitializeComponent();
            DisplayEmployeeData();
        }

        public void DisplayEmployeeData()
        {
            var ed = new EmployeeData();
            var listData = ed.EmployeeDatas();

            dataGridView1.DataSource = listData;
        }

        public void ClearFields()
        {
            addEmployee_id.Text = "";
            addEmployee_fullName.Text = "";
            addEmployee_gender.SelectedIndex = -1;
            addEmployee_phone.Text = "";
            addEmployee_position.SelectedIndex = -1;
            addEmployee_status.SelectedIndex = -1;
            addEmployee_photo.Image = null;
        }

        private void addEmployee_add_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addEmployee_id.Text)
                || string.IsNullOrWhiteSpace(addEmployee_fullName.Text)
                || string.IsNullOrWhiteSpace(addEmployee_gender.Text)
                || string.IsNullOrWhiteSpace(addEmployee_phone.Text)
                || string.IsNullOrWhiteSpace(addEmployee_position.Text)
                || string.IsNullOrWhiteSpace(addEmployee_status.Text)
                || addEmployee_photo.Image == null)
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    try
                    {
                        sqlConnection.Open();

                        var checmEmId = "SELECT COUNT(*) FROM employees WHERE employee_id = @emId AND delete_date IS NULL";

                        using (SqlCommand checmEm = new SqlCommand(checmEmId, sqlConnection))
                        {
                            checmEm.Parameters.AddWithValue("@emId", addEmployee_id.Text.Trim());

                            var count = (int)checmEm.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show(addEmployee_id.Text.Trim() + " is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                var today = DateTime.Today;

                                var insertData = "INSERT INTO employees " +
                                    "(employee_id, full_name, gender, contact_number, position, image, salary, insert_date, status) " +
                                    "VALUES(@employeeId, @fullName, @gender, @contact_number, @position, @image, @salary, @insert_date, @status)";

                                var path = Path.Combine(@"C:\Training\EmployeeManagement\EmployeeManagement\Directory\" + addEmployee_id.Text.Trim() + ".jpg");

                                var directoryPath = Path.GetDirectoryName(path);

                                if (!Directory.Exists(directoryPath))
                                    Directory.CreateDirectory(directoryPath!);

                                File.Copy(addEmployee_photo.ImageLocation, path, true);

                                using (SqlCommand cmd = new SqlCommand(insertData, sqlConnection))
                                {
                                    cmd.Parameters.AddWithValue("@employeeID", addEmployee_id.Text.Trim());
                                    cmd.Parameters.AddWithValue("@fullName", addEmployee_fullName.Text.Trim());
                                    cmd.Parameters.AddWithValue("@gender", addEmployee_gender.Text.Trim());
                                    cmd.Parameters.AddWithValue("@contact_number", addEmployee_phone.Text.Trim());
                                    cmd.Parameters.AddWithValue("@position", addEmployee_position.Text.Trim());
                                    cmd.Parameters.AddWithValue("@image", path);
                                    cmd.Parameters.AddWithValue("@salary", 0);
                                    cmd.Parameters.AddWithValue("@insert_date", today);
                                    cmd.Parameters.AddWithValue("@status", addEmployee_status.Text.Trim());

                                    cmd.ExecuteNonQuery();

                                    DisplayEmployeeData();

                                    MessageBox.Show("Added succesfully!", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error " + ex.Message, "Error Message");
                    }
                    finally
                    {
                        sqlConnection.Close();
                    }
                }
            }
        }

        private void addEmployee_import_Click(object sender, EventArgs e)
        {
            try
            {
                var dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg; *.png)|*.jpg;*.png";
                var imagePath = "";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    addEmployee_photo.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addEmployee_status_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                addEmployee_id.Text = row.Cells[1].Value.ToString();
                addEmployee_fullName.Text = row.Cells[2].Value.ToString();
                addEmployee_gender.Text = row.Cells[3].Value.ToString();
                addEmployee_phone.Text = row.Cells[4].Value.ToString();
                addEmployee_position.Text = row.Cells[5].Value.ToString();

                var imagePath = row.Cells[6].Value.ToString();
                if (!string.IsNullOrWhiteSpace(imagePath))
                    addEmployee_photo.Image = Image.FromFile(imagePath);
                else
                    addEmployee_photo = null;

                addEmployee_status.Text = row.Cells[8].Value.ToString();
            }
        }

        private void addEmployee_update_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addEmployee_id.Text)
                || string.IsNullOrWhiteSpace(addEmployee_fullName.Text)
                || string.IsNullOrWhiteSpace(addEmployee_gender.Text)
                || string.IsNullOrWhiteSpace(addEmployee_phone.Text)
                || string.IsNullOrWhiteSpace(addEmployee_position.Text)
                || string.IsNullOrWhiteSpace(addEmployee_status.Text)
                || addEmployee_photo.Image == null)
            {
                MessageBox.Show("Please fill all blank fields"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to UPDATE " +
                    "Employee ID: " + addEmployee_id.Text.Trim() + "?", "Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        sqlConnection.Open();
                        DateTime today = DateTime.Today;

                        string updateData = "UPDATE employees SET full_name = @fullName" +
                            ", gender = @gender, contact_number = @contactNum" +
                            ", position = @position, update_date = @updateDate, status = @status " +
                            "WHERE employee_id = @employeeID";

                        using (SqlCommand cmd = new SqlCommand(updateData, sqlConnection))
                        {
                            cmd.Parameters.AddWithValue("@fullName", addEmployee_fullName.Text.Trim());
                            cmd.Parameters.AddWithValue("@gender", addEmployee_gender.Text.Trim());
                            cmd.Parameters.AddWithValue("@contactNum", addEmployee_phone.Text.Trim());
                            cmd.Parameters.AddWithValue("@position", addEmployee_position.Text.Trim());
                            cmd.Parameters.AddWithValue("@updateDate", today);
                            cmd.Parameters.AddWithValue("@status", addEmployee_status.Text.Trim());
                            cmd.Parameters.AddWithValue("@employeeID", addEmployee_id.Text.Trim());

                            cmd.ExecuteNonQuery();

                            DisplayEmployeeData();

                            MessageBox.Show("Update successfully!"
                                , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ClearFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex
                        , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        sqlConnection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Cancelled."
                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void addEmployee_clear_btn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addEmployee_id.Text)
                || string.IsNullOrWhiteSpace(addEmployee_fullName.Text)
                || string.IsNullOrWhiteSpace(addEmployee_gender.Text)
                || string.IsNullOrWhiteSpace(addEmployee_phone.Text)
                || string.IsNullOrWhiteSpace(addEmployee_position.Text)
                || string.IsNullOrWhiteSpace(addEmployee_status.Text)
                || addEmployee_photo.Image == null)
            {
                MessageBox.Show("Please fill all blank fields"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to DELETE " +
                    "Employee ID: " + addEmployee_id.Text.Trim() + "?", "Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        sqlConnection.Open();
                        DateTime today = DateTime.Today;

                        string updateData = "UPDATE employees SET delete_date = @deleteDate " +
                            "WHERE employee_id = @employeeID";

                        using (SqlCommand cmd = new SqlCommand(updateData, sqlConnection))
                        {
                            cmd.Parameters.AddWithValue("@deleteDate", today);
                            cmd.Parameters.AddWithValue("@employeeID", addEmployee_id.Text.Trim());

                            cmd.ExecuteNonQuery();

                            DisplayEmployeeData();

                            MessageBox.Show("Update successfully!"
                                , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ClearFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex
                        , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        sqlConnection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Cancelled."
                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}