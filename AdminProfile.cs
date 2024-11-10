using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class AdminProfile : Form
    {
        private string connectionString = "Server=LAPTOP-AEP37085\\SQLEXPRESS;Database=EmployeeManagement;Integrated Security=True;";
        private int adminId;

        public AdminProfile(int adminId)
        {
            InitializeComponent();
            this.adminId = adminId;
            this.Load += new EventHandler(this.AdminProfile_Load);
            AdminMainToolstrip.ItemClicked += AdminMainToolstrip_ItemClicked;
        }

        public void LoadAdminProfile()
        {
            string query = "SELECT name, age, email, number, position FROM tbl_admin WHERE admin_id = @adminId";

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
                        nameLabel.Text = "Name: " + reader["name"].ToString();
                        ageLabel.Text = "Age: " + reader["age"].ToString();
                        emailLabel.Text = "Email: " + reader["email"].ToString();
                        numberLabel.Text = "Phone: " + reader["number"].ToString();
                        positionLabel.Text = "Position: " + reader["position"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Admin profile not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching admin profile: " + ex.Message);
                }
            }
        }

        private void AdminProfile_Load(object sender, EventArgs e)
        {
            LoadAdminProfile();
        }

        private void AdminMainToolstrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name == "AdminHomeMenu")
            {
                AdminHome adminHomeForm = new AdminHome(adminId);
                adminHomeForm.WindowState = FormWindowState.Maximized;
                adminHomeForm.Show();
                this.Hide();
            }
            else if (e.ClickedItem.Name == "AdminOverviewMenu")
            {
                AdminOverview adminOverviewForm = new AdminOverview(adminId);
                adminOverviewForm.WindowState = FormWindowState.Maximized;
                adminOverviewForm.Show();
                this.Hide();
            }
            else if (e.ClickedItem.Name == "AdminProfileMenu")
            {
                MessageBox.Show("You are already on the Admin Profile page.");
            }
            else if (e.ClickedItem.Name == "AdminTasksMenu")
            {
                AdminTasks adminTasksForm = new AdminTasks(adminId);
                adminTasksForm.WindowState = FormWindowState.Maximized;
                adminTasksForm.Show();
                this.Hide();
            }
            else if (e.ClickedItem.Name == "AdminInquiriesMenu")
            {
                AdminInquiries adminInquiriesForm = new AdminInquiries(adminId);
                adminInquiriesForm.WindowState = FormWindowState.Maximized;
                adminInquiriesForm.Show();
                this.Hide();
            }
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            AdminChangePassword adminChangePasswordForm = new AdminChangePassword(adminId, this);
            adminChangePasswordForm.ShowDialog();
        }

        private void changeEmailButton_Click(object sender, EventArgs e)
        {
            AdminChangeEmail adminChangeEmailForm = new AdminChangeEmail(adminId, this);
            adminChangeEmailForm.ShowDialog();
        }

        private void changeDetailsButton_Click(object sender, EventArgs e)
        {
            AdminChangeDetails adminChangeDetailsForm = new AdminChangeDetails(adminId, this);
            adminChangeDetailsForm.ShowDialog();
        }
    }
}
