using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class AdminOverview : Form
    {
        private string connectionString = "Server=LAPTOP-AEP37085\\SQLEXPRESS;Database=EmployeeManagement;Integrated Security=True;";
        private int adminId;

        public AdminOverview(int adminId)
        {
            InitializeComponent();
            this.adminId = adminId;
            this.Load += new EventHandler(this.AdminOverview_Load);
            AdminMainToolstrip.ItemClicked += AdminMainToolstrip_ItemClicked;
        }

        private void AdminOverview_Load(object sender, EventArgs e)
        {
            LoadEmployeeData();
        }

        private void LoadEmployeeData()
        {
            string query = "SELECT employees_id, username, password, name, age, email, number, status, position FROM tbl_employees";
            string countQuery = "SELECT COUNT(*) FROM tbl_employees";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand countCommand = new SqlCommand(countQuery, connection);
                    int employeeCount = (int)countCommand.ExecuteScalar();
                    numberEmployees.Text = $"{employeeCount} Employees";

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable employeeDataTable = new DataTable();
                    dataAdapter.Fill(employeeDataTable);

                    if (employeeDataTable.Rows.Count > 0)
                    {
                        listEmployeeGridView.DataSource = employeeDataTable;

                        listEmployeeGridView.Columns["username"].HeaderText = "Access User";
                        listEmployeeGridView.Columns["name"].HeaderText = "Employee Name";
                        listEmployeeGridView.Columns["email"].HeaderText = "Employee Email";
                        listEmployeeGridView.Columns["number"].HeaderText = "Employee Number";
                        listEmployeeGridView.Columns["status"].HeaderText = "Employee Status";
                        listEmployeeGridView.Columns["position"].HeaderText = "Employee Position";

                        listEmployeeGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        listEmployeeGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    }
                    else
                    {
                        MessageBox.Show("No data found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching data: " + ex.Message);
                }
            }
        }

        private void AdminMainToolstrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name == "AdminHomeMenu")
            {
                AdminHome adminHomeForm = new AdminHome(adminId); // Pass adminId here
                adminHomeForm.WindowState = FormWindowState.Maximized;
                adminHomeForm.Show();
                this.Hide();
            }
            else if (e.ClickedItem.Name == "AdminOverviewMenu")
            {
                MessageBox.Show("You are already on the Admin Overview page.");
            }
            else if (e.ClickedItem.Name == "AdminProfileMenu")
            {
                AdminProfile adminProfileForm = new AdminProfile(adminId); // Pass adminId here
                adminProfileForm.WindowState = FormWindowState.Maximized;
                adminProfileForm.Show();
                this.Hide();
            }
            else if (e.ClickedItem.Name == "AdminTasksMenu")
            {
                AdminTasks adminTasksForm = new AdminTasks(adminId); // Pass adminId here
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
    }
}
