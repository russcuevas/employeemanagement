using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class AdminInquiries : Form
    {
        private string connectionString = "Server=LAPTOP-AEP37085\\SQLEXPRESS;Database=EmployeeManagement;Integrated Security=True;";
        private int adminId;

        public AdminInquiries(int adminId)
        {
            InitializeComponent();
            this.Load += new EventHandler(this.AdminInquiries_Load);
            this.adminId = adminId;
            AdminMainToolstrip.ItemClicked += AdminMainToolstrip_ItemClicked;
            listReportGridView.CellContentClick += listReportGridView_CellContentClick;
        }

        private void AdminInquiries_Load(object sender, EventArgs e)
        {
            LoadReports();
        }

        private void LoadReports()
        {
            string query = @"
        SELECT r.reports_id, e.name AS employee_name, r.issue, r.status
        FROM tbl_reports r
        INNER JOIN tbl_employees e ON r.employees_id = e.employees_id;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    listReportGridView.DataSource = dataTable;

                    listReportGridView.Columns["reports_id"].Visible = false;

                    listReportGridView.Columns["employee_name"].HeaderText = "Employee Name";
                    listReportGridView.Columns["issue"].HeaderText = "Issue Description";
                    listReportGridView.Columns["status"].HeaderText = "Status";

                    listReportGridView.Columns["employee_name"].Width = 200;
                    listReportGridView.Columns["issue"].Width = 300;
                    listReportGridView.Columns["status"].Width = 150;

                    listReportGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    listReportGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    listReportGridView.RowTemplate.Height = 40;

                    listReportGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

                    if (!listReportGridView.Columns.Contains("Update"))
                    {
                        DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn
                        {
                            Name = "Update",
                            HeaderText = "Update",
                            Text = "Addressed ✔",
                            UseColumnTextForButtonValue = true
                        };

                        listReportGridView.Columns.Add(btnColumn);
                        btnColumn.DefaultCellStyle.BackColor = Color.Green;
                        btnColumn.DefaultCellStyle.ForeColor = Color.White;
                        btnColumn.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
                        btnColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        foreach (DataGridViewRow row in listReportGridView.Rows)
                        {
                            row.Cells["Update"].ToolTipText = "Mark this report as addressed.";
                        }
                    }

                    listReportGridView.ReadOnly = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading reports: " + ex.Message);
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
                AdminTasks adminTasksForm = new AdminTasks(adminId);
                adminTasksForm.WindowState = FormWindowState.Maximized;
                adminTasksForm.Show();
                this.Hide();
            }
            else if (e.ClickedItem.Name == "AdminInquiriesMenu")
            {
                if (Application.OpenForms["AdminInquiries"] != null)
                {
                    MessageBox.Show("You are already on the Admin Inquiries page.");
                }
                else
                {
                    AdminInquiries adminInquiriesForm = new AdminInquiries(adminId);
                    adminInquiriesForm.WindowState = FormWindowState.Maximized;
                    adminInquiriesForm.Show();
                    this.Hide();
                }
            }
        }

        private void listReportGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == listReportGridView.Columns["Update"].Index && e.RowIndex >= 0)
            {
                var reportIdCell = listReportGridView.Rows[e.RowIndex].Cells["reports_id"];
                if (reportIdCell != null && reportIdCell.Value != DBNull.Value)
                {
                    int reportId;
                    bool isValidId = int.TryParse(reportIdCell.Value.ToString(), out reportId);

                    if (isValidId)
                    {
                        UpdateReportStatus(reportId);
                        LoadReports();
                    }
                    else
                    {
                        MessageBox.Show("Invalid report ID selected. Please try again.");
                    }
                }
                else
                {
                    MessageBox.Show("No valid report ID selected. Please try again.");
                }
            }
            else
            {
                MessageBox.Show("Please click the button to update the report status.");
            }
        }


        private void UpdateReportStatus(int reportId)
        {
            string updateQuery = "UPDATE tbl_reports SET status = 'Already Addressed' WHERE reports_id = @ReportId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(updateQuery, connection);
                    cmd.Parameters.AddWithValue("@ReportId", reportId);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Report marked as 'Already Addressed'.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating report status: " + ex.Message);
                }
            }
        }
    }
}
