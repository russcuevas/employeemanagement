using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class ClientChangePassword : Form
    {
        private string connectionString = "Server=LAPTOP-AEP37085\\SQLEXPRESS;Database=EmployeeManagement;Integrated Security=True;";
        private int employeeId;
        private ClientProfile clientProfileForm;

        public ClientChangePassword(int employeeId, ClientProfile clientProfileForm)
        {
            InitializeComponent();
            this.employeeId = employeeId;
            this.clientProfileForm = clientProfileForm;
        }

        private void ClientChangePassword_Load(object sender, EventArgs e)
        {
            // Any additional loading logic for the client password change form can go here
        }

        private void updatePasswordButton_Click(object sender, EventArgs e)
        {
            string newPassword = newPasswordTextBox.Text;
            string confirmPassword = confirmPasswordTextBox.Text;

            // Check if the passwords match
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please try again.");
                return;
            }

            // Check if the password is not empty
            if (string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("Password cannot be empty.");
                return;
            }

            // Attempt to update the password in the database
            bool success = UpdatePasswordInDatabase(employeeId, newPassword);

            if (success)
            {
                MessageBox.Show("Password updated successfully.");
                this.Close();  // Close the change password form
                clientProfileForm.LoadEmployeeProfile();  // Reload the client profile with updated information
            }
            else
            {
                MessageBox.Show("Failed to update password. Please try again.");
            }
        }

        private bool UpdatePasswordInDatabase(int employeeId, string newPassword)
        {
            string query = "UPDATE tbl_employees SET password = @newPassword WHERE employees_id = @employeeId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@newPassword", newPassword);
                    command.Parameters.AddWithValue("@employeeId", employeeId);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;  // Return true if the password was updated
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating password: " + ex.Message);
                    return false;  // Return false if there was an error
                }
            }
        }
    }
}
