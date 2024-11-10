using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class LoginForm : Form
    {
        private string connectionString = "Server=LAPTOP-AEP37085\\SQLEXPRESS;Database=EmployeeManagement;Integrated Security=True;";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextbox.Text;
            string password = passwordTextbox.Text;

            int adminId = VerifyLogin("tbl_admin", username, password, true);
            if (adminId > 0)
            {
                AdminHome adminHomeForm = new AdminHome(adminId);
                adminHomeForm.Show();
                adminHomeForm.WindowState = FormWindowState.Maximized;
                this.Hide();
            }
            else
            {
                int employeeId = VerifyLogin("tbl_employees", username, password, false);
                if (employeeId > 0)
                {
                    ClientHome clientHomeForm = new ClientHome(employeeId);
                    clientHomeForm.Show();
                    clientHomeForm.WindowState = FormWindowState.Maximized;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
        }

        private int VerifyLogin(string tableName, string username, string password, bool isAdmin)
        {
            int id = -1;
            string query = "";

            if (isAdmin)
            {
                query = "SELECT admin_id FROM tbl_admin WHERE username = @username AND password = @password";
            }
            else
            {
                query = "SELECT employees_id FROM tbl_employees WHERE username = @username AND password = @password";
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        if (isAdmin)
                        {
                            id = Convert.ToInt32(reader["admin_id"]);
                        }
                        else
                        {
                            id = Convert.ToInt32(reader["employees_id"]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            return id;
        }
    }
}
