using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class AdminChangeEmail : Form
    {
        private string connectionString = "Server=LAPTOP-AEP37085\\SQLEXPRESS;Database=EmployeeManagement;Integrated Security=True;";
        private int adminId;
        private AdminProfile adminProfileForm;

        public AdminChangeEmail(int adminId, AdminProfile adminProfileForm)
        {
            InitializeComponent();
            this.adminId = adminId;
            this.adminProfileForm = adminProfileForm;
        }

        private void AdminChangeEmail_Load(object sender, EventArgs e)
        {
            LoadCurrentEmail();
        }

        private void LoadCurrentEmail()
        {
            string query = "SELECT email FROM tbl_admin WHERE admin_id = @adminId";
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
                        emailTextBox.Text = reader["email"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Admin not found.");
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
            string newEmail = emailTextBox.Text;
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

            string query = "UPDATE tbl_admin SET email = @newEmail WHERE admin_id = @adminId";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@newEmail", newEmail);
                    command.Parameters.AddWithValue("@adminId", adminId);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Email updated successfully!");
                        this.Close();
                        adminProfileForm.LoadAdminProfile();
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

        private bool IsValidEmail(string email)
        {
            try
            {
                var mailAddress = new System.Net.Mail.MailAddress(email);
                return mailAddress.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
