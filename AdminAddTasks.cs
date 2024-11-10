using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class AdminAddTasks : Form
    {
        private string connectionString = "Server=LAPTOP-AEP37085\\SQLEXPRESS;Database=EmployeeManagement;Integrated Security=True;";
        private int adminId;

        public AdminAddTasks(int adminId)
        {
            InitializeComponent();
            this.adminId = adminId; // Properly initialize adminId
            employeeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            PopulateEmployeeComboBox();
            AdminMainToolstrip.ItemClicked += AdminMainToolstrip_ItemClicked;
        }

        private void PopulateEmployeeComboBox()
        {
            string query = "SELECT employees_id, name FROM tbl_employees";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();

                        employeeComboBox.Items.Clear();

                        while (reader.Read())
                        {
                            string employeeName = reader["name"].ToString();
                            employeeComboBox.Items.Add(employeeName);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            string selectedEmployeeName = employeeComboBox.SelectedItem.ToString();
            string taskName = assignTaskTextBox.Text;
            DateTime taskDate = chooseDateTextBox.Value;

            int employeeId = GetEmployeeIdByName(selectedEmployeeName);

            if (employeeId > 0 && !string.IsNullOrEmpty(taskName))
            {
                try
                {
                    InsertTask(employeeId, taskName, taskDate);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while inserting task: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select an employee and enter a task name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private int GetEmployeeIdByName(string employeeName)
        {
            int employeeId = -1;
            string query = "SELECT employees_id FROM tbl_employees WHERE name = @name";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@name", employeeName);

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            employeeId = Convert.ToInt32(reader["employees_id"]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return employeeId;
        }

        private void InsertTask(int employeeId, string taskName, DateTime taskDate)
        {
            string insertTaskQuery = "INSERT INTO tbl_tasks (employees_id, tasks_name, tasks_date) VALUES (@employees_id, @tasks_name, @tasks_date)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(insertTaskQuery, connection))
                    {
                        command.Parameters.AddWithValue("@employees_id", employeeId);
                        command.Parameters.AddWithValue("@tasks_name", taskName);
                        command.Parameters.AddWithValue("@tasks_date", taskDate);
                        command.ExecuteNonQuery();
                        InsertTaskStatus(employeeId, taskName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void InsertTaskStatus(int employeeId, string taskName)
        {
            string getTaskIdQuery = "SELECT tasks_id FROM tbl_tasks WHERE tasks_name = @tasks_name AND employees_id = @employees_id ORDER BY tasks_date DESC";

            int taskId = -1;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(getTaskIdQuery, connection))
                    {
                        command.Parameters.AddWithValue("@tasks_name", taskName);
                        command.Parameters.AddWithValue("@employees_id", employeeId);

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            taskId = Convert.ToInt32(reader["tasks_id"]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while retrieving task ID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (taskId > 0)
            {
                string insertStatusQuery = "INSERT INTO tbl_tasks_status (tasks_id, status, date_completed) VALUES (@tasks_id, @status, @date_completed)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(insertStatusQuery, connection))
                        {
                            command.Parameters.AddWithValue("@tasks_id", taskId);
                            command.Parameters.AddWithValue("@status", "On working");
                            command.Parameters.AddWithValue("@date_completed", DBNull.Value);

                            command.ExecuteNonQuery();

                            MessageBox.Show("Task added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error while inserting task status: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void employeeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void assignTaskTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void chooseDateTextBox_ValueChanged(object sender, EventArgs e)
        {

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
    }
}
