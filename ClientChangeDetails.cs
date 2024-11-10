using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class ClientChangeDetails : Form
    {
        private string connectionString = "Server=LAPTOP-AEP37085\\SQLEXPRESS;Database=EmployeeManagement;Integrated Security=True;";
        private int employeeId;
        private ClientProfile clientProfileForm;

        public ClientChangeDetails(int employeeId, ClientProfile clientProfileForm)
        {
            InitializeComponent();
            this.employeeId = employeeId;
            this.clientProfileForm = clientProfileForm;
            this.Load += new EventHandler(this.ClientChangeDetails_Load);
        }

        private void ClientChangeDetails_Load(object sender, EventArgs e)
        {
            LoadCurrentDetails();
        }

        private void LoadCurrentDetails()
        {
            string query = "SELECT name, age, number FROM tbl_employees WHERE employees_id = @employeeId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@employeeId", employeeId);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        nameTextBox.Text = reader["name"].ToString();
                        ageTextBox.Text = reader["age"].ToString();
                        numberTextBox.Text = reader["number"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Employee details not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching employee details: " + ex.Message);
                }
            }
        }

        private void updateDetailsButton_Click(object sender, EventArgs e)
        {
            string newName = nameTextBox.Text;
            string newAge = ageTextBox.Text;
            string newNumber = numberTextBox.Text;
            string query = "UPDATE tbl_employees SET name = @name, age = @age, number = @number WHERE employees_id = @employeeId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@name", newName);
                    command.Parameters.AddWithValue("@age", newAge);
                    command.Parameters.AddWithValue("@number", newNumber);
                    command.Parameters.AddWithValue("@employeeId", employeeId);

                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Details updated successfully.");
                        this.Close();
                        clientProfileForm.LoadEmployeeProfile();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update details.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating details: " + ex.Message);
                }
            }
        }
    }
}
