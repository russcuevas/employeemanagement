using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class AdminTasks : Form
    {
        private string connectionString = "Server=LAPTOP-AEP37085\\SQLEXPRESS;Database=EmployeeManagement;Integrated Security=True;";
        private int adminId;
        public AdminTasks(int adminId)
        {
            InitializeComponent();
            this.adminId = adminId;
            this.Load += new EventHandler(this.AdminTasks_Load);
            AdminMainToolstrip.ItemClicked += AdminMainToolstrip_ItemClicked;
        }

        private void AdminTasks_Load(object sender, EventArgs e)
        {
            LoadAssignedTasks();
            LoadTaskStatusSummary();
        }

        private void LoadAssignedTasks()
        {
            string query = @"
        SELECT 
            e.name AS EmployeeName,
            t.tasks_name AS TaskName,
            t.tasks_date AS TaskDate
        FROM 
            tbl_employees e
        INNER JOIN 
            tbl_tasks t ON e.employees_id = t.employees_id
        ORDER BY 
            t.tasks_date DESC;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable tasksDataTable = new DataTable();
                    dataAdapter.Fill(tasksDataTable);


                    tasksDataTable.Columns.Add("TaskStatus", typeof(string));
                    foreach (DataRow row in tasksDataTable.Rows)
                    {
                        DateTime taskDate = Convert.ToDateTime(row["TaskDate"]);

                        if (taskDate.Date == DateTime.Today)
                        {
                            row["TaskStatus"] = "Today's Task";
                        }
                        else if (taskDate.Date > DateTime.Today)
                        {
                            row["TaskStatus"] = "Upcoming Task";
                        }
                        else
                        {
                            row["TaskStatus"] = "Past Task";
                        }
                    }

                    assignedTaskView.DataSource = tasksDataTable;
                    assignedTaskView.Columns["EmployeeName"].HeaderText = "Employee Name";
                    assignedTaskView.Columns["TaskName"].HeaderText = "Task Name";
                    assignedTaskView.Columns["TaskDate"].HeaderText = "Assigned Date";
                    assignedTaskView.Columns["TaskStatus"].HeaderText = "When";

                    assignedTaskView.Columns["EmployeeName"].Width = 150;
                    assignedTaskView.Columns["TaskName"].Width = 200;
                    assignedTaskView.Columns["TaskDate"].Width = 150;
                    assignedTaskView.Columns["TaskStatus"].Width = 120;
                    assignedTaskView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    assignedTaskView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                    assignedTaskView.ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching assigned tasks: " + ex.Message);
                }
            }
        }



        private void LoadTaskStatusSummary()
        {
            string query = @"
        SELECT 
            e.name AS EmployeeName,
            e.position AS EmployeePosition,
            t.tasks_name AS TaskName,
            t.tasks_date AS TaskDate,
            ts.status AS TaskStatus
        FROM 
            tbl_tasks t
        INNER JOIN 
            tbl_employees e ON t.employees_id = e.employees_id
        LEFT JOIN 
            tbl_tasks_status ts ON t.tasks_id = ts.tasks_id
        WHERE 
            t.tasks_date <= GETDATE()  -- Only tasks that are due before or on today's date
        ORDER BY 
            t.tasks_date DESC;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable taskSummaryDataTable = new DataTable();
                    dataAdapter.Fill(taskSummaryDataTable);

                    summaryView.DataSource = taskSummaryDataTable;
                    summaryView.Columns["EmployeeName"].HeaderText = "Employee Name";
                    summaryView.Columns["EmployeePosition"].HeaderText = "Position";
                    summaryView.Columns["TaskName"].HeaderText = "Task Name";
                    summaryView.Columns["TaskDate"].HeaderText = "Assigned Date";
                    summaryView.Columns["TaskStatus"].HeaderText = "Status";

                    summaryView.Columns["EmployeeName"].Width = 150;
                    summaryView.Columns["EmployeePosition"].Width = 120;
                    summaryView.Columns["TaskName"].Width = 200;
                    summaryView.Columns["TaskDate"].Width = 150;
                    summaryView.Columns["TaskStatus"].Width = 100;
                    summaryView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching task summary: " + ex.Message);
                }
            }
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
                AdminProfile adminProfileForm = new AdminProfile(adminId);
                adminProfileForm.WindowState = FormWindowState.Maximized;
                adminProfileForm.Show();
                this.Hide();
            }
            else if (e.ClickedItem.Name == "AdminTasksMenu")
            {
                MessageBox.Show("You are already on the Admin Tasks page.");
            }
            else if (e.ClickedItem.Name == "AdminInquiriesMenu")
            {
                AdminInquiries adminInquiriesForm = new AdminInquiries(adminId);
                adminInquiriesForm.WindowState = FormWindowState.Maximized;
                adminInquiriesForm.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminAddTasks adminAddTaskForm = new AdminAddTasks(adminId);
            adminAddTaskForm.WindowState = FormWindowState.Maximized;
            adminAddTaskForm.Show();
            this.Hide();
        }
    }
}
