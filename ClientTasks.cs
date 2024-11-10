using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class ClientTasks : Form
    {
        private string connectionString = "Server=LAPTOP-AEP37085\\SQLEXPRESS;Database=EmployeeManagement;Integrated Security=True;";
        private int employeeId;

        public ClientTasks(int employeeId)
        {
            InitializeComponent();
            this.Load += new EventHandler(this.ClientTasks_Load);
            this.employeeId = employeeId;
            todayTasks.CellContentClick += todayTasks_CellContentClick;
        }

        private void ClientTasks_Load(object sender, EventArgs e)
        {
            LoadUpcomingTasks();
            LoadTodayTasks();
            LoadCompletedTasks(); // Load completed tasks when the form loads
        }

        private void LoadTodayTasks()
        {
            string query = @"
            SELECT 
                t.tasks_name AS TaskName,
                t.tasks_date AS TaskDate,
                ts.status AS TaskStatus,
                t.tasks_id AS TaskId
            FROM 
                tbl_employees e
            INNER JOIN 
                tbl_tasks t ON e.employees_id = t.employees_id
            LEFT JOIN 
                tbl_tasks_status ts ON t.tasks_id = ts.tasks_id
            WHERE
                e.employees_id = @employeeId
                AND t.tasks_date <= GETDATE()
            ORDER BY 
                t.tasks_date DESC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@employeeId", employeeId);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    todayTasks.DataSource = dataTable;

                    todayTasks.ReadOnly = true;

                    if (!todayTasks.Columns.Contains("CompleteButton"))
                    {
                        DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn
                        {
                            Name = "CompleteButton",
                            HeaderText = "Update",
                            Text = "Complete",
                            UseColumnTextForButtonValue = true
                        };
                        todayTasks.Columns.Add(buttonColumn);
                    }

                    CustomizeButtonColumn();

                    todayTasks.Columns["TaskId"].Visible = false;

                    todayTasks.Columns["TaskName"].HeaderText = "Tasks";
                    todayTasks.Columns["TaskDate"].HeaderText = "Date Distribute";
                    todayTasks.Columns["TaskStatus"].HeaderText = "Status";

                    // Set AutoSizeColumnsMode for fitting columns to data
                    todayTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    // Manually adjust the width of some columns
                    todayTasks.Columns["TaskName"].Width = 250;
                    todayTasks.Columns["TaskDate"].Width = 150;
                    todayTasks.Columns["TaskStatus"].Width = 120;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading tasks: " + ex.Message);
                }
            }
        }

        private void CustomizeButtonColumn()
        {
            DataGridViewButtonColumn buttonColumn = todayTasks.Columns["CompleteButton"] as DataGridViewButtonColumn;
            if (buttonColumn != null)
            {
                buttonColumn.DefaultCellStyle.ForeColor = Color.White;
                buttonColumn.DefaultCellStyle.BackColor = Color.Green;
                buttonColumn.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);

                buttonColumn.Width = 100;
                buttonColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                todayTasks.CellMouseEnter += (sender, e) =>
                {
                    if (e.RowIndex >= 0 && e.ColumnIndex == todayTasks.Columns["CompleteButton"].Index)
                    {
                        todayTasks.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.DarkGreen;
                    }
                };

                todayTasks.CellMouseLeave += (sender, e) =>
                {
                    if (e.RowIndex >= 0 && e.ColumnIndex == todayTasks.Columns["CompleteButton"].Index)
                    {
                        todayTasks.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Green;
                    }
                };
            }
        }

        private void todayTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == todayTasks.Columns["CompleteButton"].Index && e.RowIndex >= 0)
            {
                var taskIdCell = todayTasks.Rows[e.RowIndex].Cells["TaskId"].Value;

                if (taskIdCell == null || taskIdCell == DBNull.Value)
                {
                    MessageBox.Show("No task ID selected. Please try again.");
                    return;
                }

                int taskId;
                if (!int.TryParse(taskIdCell.ToString(), out taskId))
                {
                    MessageBox.Show("Invalid task ID. Please try again.");
                    return;
                }

                UpdateTaskStatus(taskId);
            }
        }




        private void UpdateTaskStatus(int taskId)
        {
            string updateQuery = @"
            UPDATE tbl_tasks_status 
            SET status = 'Completed',
                date_completed = GETDATE()
            WHERE tasks_id = @taskId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(updateQuery, connection);
                    command.Parameters.AddWithValue("@taskId", taskId);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Task status updated to 'Completed'.");
                        LoadTodayTasks();
                        LoadCompletedTasks();
                    }
                    else
                    {
                        MessageBox.Show("Error updating task status.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating task status: " + ex.Message);
                }
            }
        }

        private void LoadUpcomingTasks()
        {
            string query = @"
            SELECT 
                t.tasks_name AS TaskName,
                t.tasks_date AS TaskDate,
                t.tasks_id AS TaskId
            FROM 
                tbl_employees e
            INNER JOIN 
                tbl_tasks t ON e.employees_id = t.employees_id
            LEFT JOIN 
                tbl_tasks_status ts ON t.tasks_id = ts.tasks_id
            WHERE
                e.employees_id = @employeeId
                AND t.tasks_date > GETDATE()
            ORDER BY 
                t.tasks_date ASC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@employeeId", employeeId);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    upcomingTask.DataSource = dataTable;
                    upcomingTask.Columns["TaskName"].HeaderText = "Upcoming Tasks";
                    upcomingTask.Columns["TaskDate"].HeaderText = "Assigned Date";
                    upcomingTask.Columns["TaskId"].Visible = false;
                    upcomingTask.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    upcomingTask.Columns["TaskName"].Width = 250;
                    upcomingTask.Columns["TaskDate"].Width = 150;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading upcoming tasks: " + ex.Message);
                }
            }
        }

        private void LoadCompletedTasks()
        {
            string query = @"
            SELECT 
                t.tasks_name AS TaskName,
                t.tasks_date AS TaskDate,
                ts.status AS TaskStatus,
                ts.date_completed AS DateCompleted
            FROM 
                tbl_employees e
            INNER JOIN 
                tbl_tasks t ON e.employees_id = t.employees_id
            LEFT JOIN 
                tbl_tasks_status ts ON t.tasks_id = ts.tasks_id
            WHERE
                e.employees_id = @employeeId
                AND ts.status = 'Completed'
            ORDER BY 
                ts.date_completed DESC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@employeeId", employeeId);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    completedTasks.DataSource = dataTable;
                    completedTasks.Columns["TaskName"].HeaderText = "Tasks";
                    completedTasks.Columns["TaskDate"].HeaderText = "Date Distribute";
                    completedTasks.Columns["TaskStatus"].HeaderText = "Status";
                    completedTasks.Columns["DateCompleted"].HeaderText = "Date Completed";
                    completedTasks.Columns["DateCompleted"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";

                    completedTasks.Columns["TaskName"].Width = 250;
                    completedTasks.Columns["TaskDate"].Width = 150;
                    completedTasks.Columns["TaskStatus"].Width = 120;
                    completedTasks.Columns["DateCompleted"].Width = 180;

                    completedTasks.RowTemplate.Height = 40;
                    completedTasks.ReadOnly = true;
                    completedTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    completedTasks.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading completed tasks: " + ex.Message);
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
                MessageBox.Show("You are already on the Tasks Page.");
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
