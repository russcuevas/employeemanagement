using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class AdminChangePassword : Form
    {
        private string connectionString = "Server=LAPTOP-AEP37085\\SQLEXPRESS;Database=EmployeeManagement;Integrated Security=True;";
        private int adminId;
        private AdminProfile adminProfileForm;

        public AdminChangePassword(int adminId, AdminProfile adminProfileForm)
        {
            InitializeComponent();
            this.adminId = adminId;
            this.adminProfileForm = adminProfileForm;
        }

        private void AdminChangePassword_Load(object sender, EventArgs e)
        {
            
        }

        private void updatePasswordButton_Click(object sender, EventArgs e)
        {
            string newPassword = newPasswordTextBox.Text;
            string confirmPassword = confirmPasswordTextBox.Text;

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please try again.");
                return;
            }

            if (string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("Password cannot be empty.");
                return;
            }

            bool success = UpdatePasswordInDatabase(adminId, newPassword);

            if (success)
            {
                MessageBox.Show("Password updated successfully.");
                this.Close();
                adminProfileForm.LoadAdminProfile();
            }
            else
            {
                MessageBox.Show("Failed to update password. Please try again.");
            }
        }

        private bool UpdatePasswordInDatabase(int adminId, string newPassword)
        {
            string query = "UPDATE tbl_admin SET password = @newPassword WHERE admin_id = @adminId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@newPassword", newPassword);
                    command.Parameters.AddWithValue("@adminId", adminId);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating password: " + ex.Message);
                    return false;
                }
            }
        }
    }
}
