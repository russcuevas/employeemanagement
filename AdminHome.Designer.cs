namespace EmployeeManagement
{
    partial class AdminHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHome));
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            newEmployees = new DataGridView();
            AdminMainToolstrip = new ToolStrip();
            AdminHomeMenu = new ToolStripButton();
            AdminTasksMenu = new ToolStripButton();
            AdminOverviewMenu = new ToolStripButton();
            AdminProfileMenu = new ToolStripButton();
            AdminInquiriesMenu = new ToolStripButton();
            totalEmployee = new Label();
            totalTasksLabel = new Label();
            totalInquiriesLabel = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)newEmployees).BeginInit();
            AdminMainToolstrip.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightCoral;
            label1.Font = new Font("Segoe UI Semilight", 28.2F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(227, 139);
            label1.Name = "label1";
            label1.Size = new Size(337, 62);
            label1.TabIndex = 9;
            label1.Text = "New Employees";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightCoral;
            label3.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(0, 27);
            label3.Name = "label3";
            label3.Size = new Size(160, 62);
            label3.TabIndex = 10;
            label3.Text = "Home";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightCoral;
            label2.Font = new Font("Segoe UI Semilight", 28.2F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(1086, 139);
            label2.Name = "label2";
            label2.Size = new Size(245, 62);
            label2.TabIndex = 11;
            label2.Text = "Dashboard";
            // 
            // newEmployees
            // 
            newEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            newEmployees.Location = new Point(74, 232);
            newEmployees.Name = "newEmployees";
            newEmployees.RowHeadersWidth = 51;
            newEmployees.RowTemplate.Height = 29;
            newEmployees.Size = new Size(700, 374);
            newEmployees.TabIndex = 17;
            // 
            // AdminMainToolstrip
            // 
            AdminMainToolstrip.ImageScalingSize = new Size(20, 20);
            AdminMainToolstrip.Items.AddRange(new ToolStripItem[] { AdminHomeMenu, AdminTasksMenu, AdminOverviewMenu, AdminProfileMenu, AdminInquiriesMenu });
            AdminMainToolstrip.Location = new Point(0, 0);
            AdminMainToolstrip.Name = "AdminMainToolstrip";
            AdminMainToolstrip.Size = new Size(1512, 27);
            AdminMainToolstrip.TabIndex = 32;
            AdminMainToolstrip.Text = "toolStrip1";
            // 
            // AdminHomeMenu
            // 
            AdminHomeMenu.DisplayStyle = ToolStripItemDisplayStyle.Text;
            AdminHomeMenu.Image = (Image)resources.GetObject("AdminHomeMenu.Image");
            AdminHomeMenu.ImageTransparentColor = Color.Magenta;
            AdminHomeMenu.Name = "AdminHomeMenu";
            AdminHomeMenu.Size = new Size(54, 24);
            AdminHomeMenu.Text = "Home";
            // 
            // AdminTasksMenu
            // 
            AdminTasksMenu.DisplayStyle = ToolStripItemDisplayStyle.Text;
            AdminTasksMenu.Image = (Image)resources.GetObject("AdminTasksMenu.Image");
            AdminTasksMenu.ImageTransparentColor = Color.Magenta;
            AdminTasksMenu.Name = "AdminTasksMenu";
            AdminTasksMenu.Size = new Size(46, 24);
            AdminTasksMenu.Text = "Tasks";
            // 
            // AdminOverviewMenu
            // 
            AdminOverviewMenu.DisplayStyle = ToolStripItemDisplayStyle.Text;
            AdminOverviewMenu.Image = (Image)resources.GetObject("AdminOverviewMenu.Image");
            AdminOverviewMenu.ImageTransparentColor = Color.Magenta;
            AdminOverviewMenu.Name = "AdminOverviewMenu";
            AdminOverviewMenu.Size = new Size(74, 24);
            AdminOverviewMenu.Text = "Overview";
            // 
            // AdminProfileMenu
            // 
            AdminProfileMenu.DisplayStyle = ToolStripItemDisplayStyle.Text;
            AdminProfileMenu.Image = (Image)resources.GetObject("AdminProfileMenu.Image");
            AdminProfileMenu.ImageTransparentColor = Color.Magenta;
            AdminProfileMenu.Name = "AdminProfileMenu";
            AdminProfileMenu.Size = new Size(56, 24);
            AdminProfileMenu.Text = "Profile";
            // 
            // AdminInquiriesMenu
            // 
            AdminInquiriesMenu.DisplayStyle = ToolStripItemDisplayStyle.Text;
            AdminInquiriesMenu.Image = (Image)resources.GetObject("AdminInquiriesMenu.Image");
            AdminInquiriesMenu.ImageTransparentColor = Color.Magenta;
            AdminInquiriesMenu.Name = "AdminInquiriesMenu";
            AdminInquiriesMenu.Size = new Size(69, 24);
            AdminInquiriesMenu.Text = "Inquiries";
            // 
            // totalEmployee
            // 
            totalEmployee.AutoSize = true;
            totalEmployee.BackColor = Color.LightCoral;
            totalEmployee.Font = new Font("Segoe UI Semilight", 28.2F, FontStyle.Italic, GraphicsUnit.Point);
            totalEmployee.Location = new Point(917, 232);
            totalEmployee.Name = "totalEmployee";
            totalEmployee.Size = new Size(245, 62);
            totalEmployee.TabIndex = 33;
            totalEmployee.Text = "Dashboard";
            totalEmployee.Click += totalEmployee_Click;
            // 
            // totalTasksLabel
            // 
            totalTasksLabel.AutoSize = true;
            totalTasksLabel.BackColor = Color.LightCoral;
            totalTasksLabel.Font = new Font("Segoe UI Semilight", 28.2F, FontStyle.Italic, GraphicsUnit.Point);
            totalTasksLabel.Location = new Point(917, 389);
            totalTasksLabel.Name = "totalTasksLabel";
            totalTasksLabel.Size = new Size(245, 62);
            totalTasksLabel.TabIndex = 34;
            totalTasksLabel.Text = "Dashboard";
            // 
            // totalInquiriesLabel
            // 
            totalInquiriesLabel.AutoSize = true;
            totalInquiriesLabel.BackColor = Color.LightCoral;
            totalInquiriesLabel.Font = new Font("Segoe UI Semilight", 28.2F, FontStyle.Italic, GraphicsUnit.Point);
            totalInquiriesLabel.Location = new Point(917, 554);
            totalInquiriesLabel.Name = "totalInquiriesLabel";
            totalInquiriesLabel.Size = new Size(245, 62);
            totalInquiriesLabel.TabIndex = 35;
            totalInquiriesLabel.Text = "Dashboard";
            // 
            // AdminHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(1512, 840);
            Controls.Add(totalInquiriesLabel);
            Controls.Add(totalTasksLabel);
            Controls.Add(totalEmployee);
            Controls.Add(AdminMainToolstrip);
            Controls.Add(newEmployees);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "AdminHome";
            Text = "AdminHome";
            ((System.ComponentModel.ISupportInitialize)newEmployees).EndInit();
            AdminMainToolstrip.ResumeLayout(false);
            AdminMainToolstrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label3;
        private Label label2;
        private DataGridView newEmployees;
        private ToolStrip AdminMainToolstrip;
        private ToolStripButton AdminHomeMenu;
        private ToolStripButton AdminTasksMenu;
        private ToolStripButton AdminOverviewMenu;
        private ToolStripButton AdminProfileMenu;
        private ToolStripButton AdminInquiriesMenu;
        private Label totalEmployee;
        private Label totalTasksLabel;
        private Label totalInquiriesLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}