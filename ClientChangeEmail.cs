using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class ClientChangeEmail : Form
    {
        private string connectionString = "Server=LAPTOP-AEP37085\\SQLEXPRESS;Database=EmployeeManagement;Integrated Security=True;";
        private int employeeId;
        private ClientProfile clientProfileForm;

        public ClientChangeEmail(int employeeId, ClientProfile clientProfileForm)
        {
            InitializeComponent();
            this.employeeId = employeeId;
            this.clientProfileForm = clientProfileForm;
        }

        private void ClientChangeEmail_Load(object sender, EventArgs e)
        {
            LoadCurrentEmail();
        }

        private void LoadCurrentEmail()
        {
            string query = "SELECT email FROM tbl_employees WHERE employees_id = @employeeId";
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
                        newEmailTextBox.Text = reader["email"].ToString(); // Display current email in textbox
                    }
                    else
                    {
                        MessageBox.Show("Employee not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading email: " + ex.Message);
                }
            }
        }

        private void updateEmailButton_Click(object sender, EventArgs e)
        {
            string newEmail = newEmailTextBox.Text;

            // Validate the new email
            if (string.IsNullOrEmpty(newEmail))
            {
                MessageBox.Show("Please enter a new email address.");
                return;
            }
            else if (!IsValidEmail(newEmail))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            // Update the email in the database
            string query = "UPDATE tbl_employees SET email = @newEmail WHERE employees_id = @employeeId";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@newEmail", newEmail);
                    command.Parameters.AddWithValue("@employeeId", employeeId);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Email updated successfully!");
                        this.Close();  // Close the form after successful update
                        clientProfileForm.LoadEmployeeProfile();  // Reload the profile to reflect updated email
                    }
                    else
                    {
                        MessageBox.Show("Error updating email.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating email: " + ex.Message);
                }
            }
        }

        // Helper method to validate email format
        private bool IsValidEmail(string email)
        {
            try
            {
                var mailAddress = new System.Net.Mail.MailAddress(email);
                return mailAddress.Address == email;
            }
            catch
            {
                return false;  // Invalid email format
            }
        }
    }
}
