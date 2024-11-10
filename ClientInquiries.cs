using System;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class ClientInquiries : Form
    {
        private string connectionString = "Server=LAPTOP-AEP37085\\SQLEXPRESS;Database=EmployeeManagement;Integrated Security=True;";
        private int employeeId;
        public ClientInquiries(int employeeId)
        {
            this.employeeId = employeeId;
            InitializeComponent();
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
                MessageBox.Show("You are already on the Inquiries Page.");
            }
            else if (e.ClickedItem.Name == "ProfileMenu")
            {
                ClientProfile clientProfileForm = new ClientProfile(employeeId);
                clientProfileForm.WindowState = FormWindowState.Maximized;
                clientProfileForm.Show();
                this.Hide();
            }
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            // Instantiate the ClientAddReports form and pass the employeeId to the constructor
            ClientAddReports clientAddReportsForm = new ClientAddReports(employeeId);

            // Set the new form to be maximized
            clientAddReportsForm.WindowState = FormWindowState.Maximized;

            // Show the ClientAddReports form
            clientAddReportsForm.Show();

            // Hide the current form (ClientInquiries)
            this.Hide();
        }

    }
}
