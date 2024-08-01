using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class EmployeeData
    {
        private SqlConnection sqlConnection = new(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\H3XM\OneDrive - Eurofins IT-ST07\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30");
        public int ID { get; set; }
        public string? EmployeeID { get; set; }
        public string? Name { get; set; }
        public string? Gender { get; set; }
        public string? Contact { get; set; }
        public string? Position { get; set; }
        public string? Image { get; set; }
        public int Salary { get; set; }
        public string? Status { get; set; }

        public List<EmployeeData> EmployeeDatas()
        {
            var listData = new List<EmployeeData>();

            if (sqlConnection.State != System.Data.ConnectionState.Open)
            {
                try
                {
                    sqlConnection.Open();

                    var selectData = "SELECT * FROM employees WHERE delete_date IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, sqlConnection))
                    {
                        var reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            var ed = new EmployeeData();
                            ed.ID = (int)reader["id"];
                            ed.EmployeeID = reader["employee_id"].ToString();
                            ed.Name = reader["full_name"].ToString();
                            ed.Gender = reader["gender"].ToString();
                            ed.Contact = reader["contact_number"].ToString();
                            ed.Position = reader["position"].ToString();
                            ed.Image = reader["image"].ToString();
                            ed.Salary = (int)reader["salary"];
                            ed.Status = reader["status"].ToString();

                            listData.Add(ed);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    sqlConnection.Close();
                }
            }

            return listData;
        }

        public List<EmployeeData> SalaryEmployeeListData()
        {
            var listdata = new List<EmployeeData>();

            if (sqlConnection.State != ConnectionState.Open)
            {
                try
                {
                    sqlConnection.Open();

                    string selectData = "SELECT * FROM employees WHERE delete_date IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, sqlConnection))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            var ed = new EmployeeData();
                            ed.EmployeeID = reader["employee_id"].ToString();
                            ed.Name = reader["full_name"].ToString();
                            ed.Position = reader["position"].ToString();
                            ed.Salary = (int)reader["salary"];

                            listdata.Add(ed);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
            return listdata;
        }
    }
}