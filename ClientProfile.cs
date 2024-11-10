using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class ClientProfile : Form
    {
        private string connectionString = "Server=LAPTOP-AEP37085\\SQLEXPRESS;Database=EmployeeManagement;Integrated Security=True;";
        private int employeeId;

        public ClientProfile(int employeeId)
        {
            InitializeComponent();
            this.employeeId = employeeId;
            this.Load += new EventHandler(this.EmployeeProfile_Load);
        }

        private void EmployeeProfile_Load(object sender, EventArgs e)
        {
            LoadEmployeeProfile();
        }

        public void LoadEmployeeProfile()
        {
            string query = "SELECT name, age, email, number, position FROM tbl_employees WHERE employees_id = @employeeId";

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
                        nameLabel.Text = "Name: " + reader["name"].ToString();
                        ageLabel.Text = "Age: " + reader["age"].ToString();
                        emailLabel.Text = "Email: " + reader["email"].ToString();
                        numberLabel.Text = "Phone: " + reader["number"].ToString();
                        positionLabel.Text = "Position: " + reader["position"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Employee profile not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching employee profile: " + ex.Message);
                }
            }
        }

        private void MainToolstrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name == "HomeMenu")
            {
                ClientHome clientHomeForm = new ClientHome(employeeId);
                clientHomeForm.WindowState = FormWindowState.Maximized;
                clientHomeForm.Show();
                this.Hide();
            }
            else if (e.ClickedItem.Name == "TasksMenu")
            {
                ClientTasks clientTasksForm = new ClientTasks(employeeId);
                clientTasksForm.WindowState = FormWindowState.Maximized;
                clientTasksForm.Show();
                this.Hide();
            }
            else if (e.ClickedItem.Name == "InquiriesMenu")
            {
                ClientInquiries clientInquiriesForm = new ClientInquiries(employeeId);
                clientInquiriesForm.WindowState = FormWindowState.Maximized;
                clientInquiriesForm.Show();
                this.Hide();
            }
            else if (e.ClickedItem.Name == "ProfileMenu")
            {
                MessageBox.Show("You are already on the Profile Page.");
            }
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            ClientChangePassword clientChangePasswordForm = new ClientChangePassword(employeeId, this);
            clientChangePasswordForm.ShowDialog();
        }

        private void changeEmailButton_Click(object sender, EventArgs e)
        {
            ClientChangeEmail clientChangeEmailForm = new ClientChangeEmail(employeeId, this);
            clientChangeEmailForm.ShowDialog();
        }

        private void changeDetailsButton_Click(object sender, EventArgs e)
        {
            ClientChangeDetails clientChangeDetailsForm = new ClientChangeDetails(employeeId, this);
            clientChangeDetailsForm.ShowDialog();
        }

    }
}
