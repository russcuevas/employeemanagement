using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class ClientAddReports : Form
    {
        private int employeeId;
        private string connectionString = "Server=LAPTOP-AEP37085\\SQLEXPRESS;Database=EmployeeManagement;Integrated Security=True;";

        public ClientAddReports(int employeeId)
        {
            this.employeeId = employeeId;
            InitializeComponent();
        }

        private void addReportButton_Click(object sender, EventArgs e)
        {
            string issue = reportTextBox.Text.Trim();

            if (string.IsNullOrEmpty(issue))
            {
                MessageBox.Show("Please enter an issue before submitting.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            InsertReport(issue);
            reportTextBox.Clear();
        }

        private void InsertReport(string issue)
        {
            try
            {
                string query = "INSERT INTO tbl_reports (employees_id, issue, status) VALUES (@employees_id, @issue, @status)";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@employees_id", employeeId);
                    command.Parameters.AddWithValue("@issue", issue);
                    command.Parameters.AddWithValue("@status", "Not Addressed");

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Report submitted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("An error occurred while submitting the report.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                ClientProfile clientProfileForm = new ClientProfile(employeeId);
                clientProfileForm.WindowState = FormWindowState.Maximized;
                clientProfileForm.Show();
                this.Hide();
            }
        }
    }
}
