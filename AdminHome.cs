using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class AdminHome : Form
    {
        private string connectionString = "Server=LAPTOP-AEP37085\\SQLEXPRESS;Database=EmployeeManagement;Integrated Security=True;";
        private int adminId;

        public AdminHome(int adminId)
        {
            InitializeComponent();
            this.Load += new EventHandler(this.AdminHome_Load);
            this.adminId = adminId;
            AdminMainToolstrip.ItemClicked += AdminMainToolstrip_ItemClicked;
        }

        private void LoadNewEmployees()
        {
            string query = "SELECT name, position, status FROM tbl_employees WHERE status = 'New'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    newEmployees.DataSource = dataTable;

                    newEmployees.Columns["name"].HeaderText = "Employee Name";
                    newEmployees.Columns["position"].HeaderText = "Employee Position";
                    newEmployees.Columns["status"].HeaderText = "Employee Status";

                    newEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    newEmployees.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                    newEmployees.ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading new employees: " + ex.Message);
                }
            }
        }

        private void LoadTotalEmployees()
        {
            string query = "SELECT COUNT(*) FROM tbl_employees";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    int totalEmployees = (int)command.ExecuteScalar();
                    totalEmployee.Text = "Total Employees: " + totalEmployees.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading total employees: " + ex.Message);
                }
            }
        }

        private void LoadTotalTasks()
        {
            string query = "SELECT COUNT(*) FROM tbl_tasks";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    int totalTasks = (int)command.ExecuteScalar();
                    totalTasksLabel.Text = "Total Tasks: " + totalTasks.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading total tasks: " + ex.Message);
                }
            }
        }

        private void LoadTotalInquiries()
        {
            string query = "SELECT COUNT(*) FROM tbl_reports";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    int totalInquiries = (int)command.ExecuteScalar();
                    totalInquiriesLabel.Text = "Total Inquiries: " + totalInquiries.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading total inquiries: " + ex.Message);
                }
            }
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            LoadNewEmployees();
            LoadTotalEmployees();
            LoadTotalTasks();
            LoadTotalInquiries();
        }

        private void AdminMainToolstrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name == "AdminHomeMenu")
            {
                MessageBox.Show("You are already on the Admin Home page.");
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
                AdminProfile adminProfileForm = new AdminProfile(adminId);
                adminProfileForm.WindowState = FormWindowState.Maximized;
                adminProfileForm.Show();
                this.Hide();
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

        private void totalEmployee_Click(object sender, EventArgs e)
        {

        }
    }
}
