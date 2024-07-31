using System.Data.SqlClient;

namespace EmployeeManagement
{
    public partial class RegisterForm : Form
    {
        private SqlConnection sqlConnection = new(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\H3XM\OneDrive - Eurofins IT-ST07\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30");

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void signup_loginBtn_Click(object sender, EventArgs e)
        {
            var loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void signup_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            signup_password.PasswordChar = signup_showPassword.Checked ? '\0' : '*';
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(signup_username.Text) || string.IsNullOrWhiteSpace(signup_password.Text))
            {
                MessageBox.Show("Please fill all the fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (sqlConnection.State != System.Data.ConnectionState.Open)
                {
                    try
                    {
                        sqlConnection.Open();

                        var selectUsername = "SELECT COUNT(id) FROM users WHERE username = @user";

                        using (SqlCommand checkUser = new(selectUsername, sqlConnection))
                        {
                            checkUser.Parameters.AddWithValue("@user", signup_username.Text.Trim());

                            var count = (int)checkUser.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show($"{signup_username.Text.Trim()} is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                var today = DateTime.Today;

                                var insertData = "INSERT INTO users " +
                                    "(username, password, date_register) " +
                                    "VALUES (@username, @password, @dateReg)";

                                using (SqlCommand cmd = new(insertData, sqlConnection))
                                {
                                    cmd.Parameters.AddWithValue("@username", signup_username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@password", signup_showPassword.Text.Trim());
                                    cmd.Parameters.AddWithValue("@dateReg", today);

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Registered succesfully!", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    var loginForm = new Form1();
                                    loginForm.Show();
                                    this.Hide();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        sqlConnection.Close();
                    }
                }
            }
        }
    }
}