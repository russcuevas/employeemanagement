using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class ClientHome : Form
    {
        private string connectionString = "Server=LAPTOP-AEP37085\\SQLEXPRESS;Database=EmployeeManagement;Integrated Security=True;";
        private int employeeId;

        public ClientHome(int employeeId)
        {
            InitializeComponent();
            this.employeeId = employeeId;
            this.Load += new EventHandler(this.ClientHome_Load);
            taskToday.CellContentClick += TaskToday_CellContentClick;
        }

        private void ClientHome_Load(object sender, EventArgs e)
        {
            LoadTodayTasks();
            LoadCompletedTasks();
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

                    taskToday.DataSource = dataTable;

                    taskToday.ReadOnly = true;

                    if (!taskToday.Columns.Contains("CompleteButton"))
                    {
                        DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn
                        {
                            Name = "CompleteButton",
                            HeaderText = "Update",
                            Text = "Complete",
                            UseColumnTextForButtonValue = true
                        };
                        taskToday.Columns.Add(buttonColumn);
                    }

                    CustomizeButtonColumn();

                    taskToday.Columns["TaskId"].Visible = false;

                    taskToday.Columns["TaskName"].HeaderText = "Tasks";
                    taskToday.Columns["TaskDate"].HeaderText = "Date Distribute";
                    taskToday.Columns["TaskStatus"].HeaderText = "Status";

                    AdjustColumnAndRowSizes();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading tasks: " + ex.Message);
                }
            }
        }

        private void AdjustColumnAndRowSizes()
        {
            taskToday.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            taskToday.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


            taskToday.Columns["TaskName"].Width = 200;
            taskToday.Columns["TaskDate"].Width = 150;
            taskToday.Columns["TaskStatus"].Width = 100;
            taskToday.RowTemplate.Height = 40;
        }

        private void CustomizeButtonColumn()
        {
            DataGridViewButtonColumn buttonColumn = taskToday.Columns["CompleteButton"] as DataGridViewButtonColumn;
            if (buttonColumn != null)
            {
                buttonColumn.DefaultCellStyle.ForeColor = Color.White;
                buttonColumn.DefaultCellStyle.BackColor = Color.Green;
                buttonColumn.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);

                buttonColumn.Width = 100;
                buttonColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                taskToday.CellMouseEnter += (sender, e) =>
                {
                    if (e.RowIndex >= 0 && e.ColumnIndex == taskToday.Columns["CompleteButton"].Index)
                    {
                        taskToday.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.DarkGreen;
                    }
                };

                taskToday.CellMouseLeave += (sender, e) =>
                {
                    if (e.RowIndex >= 0 && e.ColumnIndex == taskToday.Columns["CompleteButton"].Index)
                    {
                        taskToday.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Green;
                    }
                };
            }
        }

        private void TaskToday_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == taskToday.Columns["CompleteButton"].Index && e.RowIndex >= 0)
            {
                var taskIdCell = taskToday.Rows[e.RowIndex].Cells["TaskId"].Value;

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
                        MessageBox.Show("Task status updated to Completed.");
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

                    completedTask.DataSource = dataTable;

                    completedTask.Columns["TaskName"].HeaderText = "Tasks";
                    completedTask.Columns["TaskDate"].HeaderText = "Date Distribute";
                    completedTask.Columns["TaskStatus"].HeaderText = "Status";
                    completedTask.Columns["DateCompleted"].HeaderText = "Date Completed";
                    completedTask.Columns["DateCompleted"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
                    completedTask.Columns["TaskName"].Width = 250;
                    completedTask.Columns["TaskDate"].Width = 150;
                    completedTask.Columns["TaskStatus"].Width = 120;
                    completedTask.Columns["DateCompleted"].Width = 180;
                    completedTask.RowTemplate.Height = 40;
                    completedTask.ReadOnly = true;
                    completedTask.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                    completedTask.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

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
                MessageBox.Show("You are already on the Home Page.");
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
