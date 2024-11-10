namespace EmployeeManagement
{
    partial class AdminInquiries
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminInquiries));
            listReportGridView = new DataGridView();
            label3 = new Label();
            label1 = new Label();
            AdminMainToolstrip = new ToolStrip();
            AdminHomeMenu = new ToolStripButton();
            AdminTasksMenu = new ToolStripButton();
            AdminOverviewMenu = new ToolStripButton();
            AdminProfileMenu = new ToolStripButton();
            AdminInquiriesMenu = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)listReportGridView).BeginInit();
            AdminMainToolstrip.SuspendLayout();
            SuspendLayout();
            // 
            // listReportGridView
            // 
            listReportGridView.ColumnHeadersHeight = 29;
            listReportGridView.Location = new Point(132, 207);
            listReportGridView.Name = "listReportGridView";
            listReportGridView.RowHeadersWidth = 51;
            listReportGridView.Size = new Size(993, 413);
            listReportGridView.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightCoral;
            label3.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(0, 27);
            label3.Name = "label3";
            label3.Size = new Size(218, 62);
            label3.TabIndex = 34;
            label3.Text = "Inquiries";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightCoral;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(132, 137);
            label1.Name = "label1";
            label1.Size = new Size(265, 50);
            label1.TabIndex = 35;
            label1.Text = "List of Inquiries";
            // 
            // AdminMainToolstrip
            // 
            AdminMainToolstrip.ImageScalingSize = new Size(20, 20);
            AdminMainToolstrip.Items.AddRange(new ToolStripItem[] { AdminHomeMenu, AdminTasksMenu, AdminOverviewMenu, AdminProfileMenu, AdminInquiriesMenu });
            AdminMainToolstrip.Location = new Point(0, 0);
            AdminMainToolstrip.Name = "AdminMainToolstrip";
            AdminMainToolstrip.Size = new Size(1494, 27);
            AdminMainToolstrip.TabIndex = 36;
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
            // AdminInquiries
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(1494, 687);
            Controls.Add(AdminMainToolstrip);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(listReportGridView);
            Name = "AdminInquiries";
            Text = "AdminInquiries";
            ((System.ComponentModel.ISupportInitialize)listReportGridView).EndInit();
            AdminMainToolstrip.ResumeLayout(false);
            AdminMainToolstrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView listReportGridView;
        private Label label3;
        private Label label1;
        private ToolStrip AdminMainToolstrip;
        private ToolStripButton AdminHomeMenu;
        private ToolStripButton AdminTasksMenu;
        private ToolStripButton AdminOverviewMenu;
        private ToolStripButton AdminProfileMenu;
        private ToolStripButton AdminInquiriesMenu;
    }
}