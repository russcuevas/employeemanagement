using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class AdminChangeDetails : Form
    {
        private string connectionString = "Server=LAPTOP-AEP37085\\SQLEXPRESS;Database=EmployeeManagement;Integrated Security=True;";
        private int adminId;
        private AdminProfile adminProfileForm;

        public AdminChangeDetails(int adminId, AdminProfile adminProfileForm)
        {
            InitializeComponent();
            this.adminId = adminId;
            this.adminProfileForm = adminProfileForm;
            this.Load += new EventHandler(this.AdminChangeDetails_Load);
        }

        private void AdminChangeDetails_Load(object sender, EventArgs e)
        {
            LoadCurrentDetails();
        }

        private void LoadCurrentDetails()
        {
            string query = "SELECT name, age, number FROM tbl_admin WHERE admin_id = @adminId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@adminId", adminId);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        nameTextBox.Text = reader["name"].ToString();
                        ageTextBox.Text = reader["age"].ToString();
                        numberTextBox.Text = reader["number"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Admin details not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching admin details: " + ex.Message);
                }
            }
        }

        private void updateDetailsButton_Click(object sender, EventArgs e)
        {
            string newName = nameTextBox.Text;
            string newAge = ageTextBox.Text;
            string newNumber = numberTextBox.Text;
            string query = "UPDATE tbl_admin SET name = @name, age = @age, number = @number WHERE admin_id = @adminId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@name", newName);
                    command.Parameters.AddWithValue("@age", newAge);
                    command.Parameters.AddWithValue("@number", newNumber);
                    command.Parameters.AddWithValue("@adminId", adminId);

                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Details updated successfully.");
                        this.Close();
                        adminProfileForm.LoadAdminProfile();
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

