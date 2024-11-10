namespace EmployeeManagement
{
    partial class ClientAddReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientAddReports));
            MainToolstrip = new ToolStrip();
            HomeMenu = new ToolStripButton();
            TasksMenu = new ToolStripButton();
            InquiriesMenu = new ToolStripButton();
            ProfileMenu = new ToolStripButton();
            label3 = new Label();
            reportTextBox = new TextBox();
            addReportButton = new Button();
            label2 = new Label();
            MainToolstrip.SuspendLayout();
            SuspendLayout();
            // 
            // MainToolstrip
            // 
            MainToolstrip.ImageScalingSize = new Size(20, 20);
            MainToolstrip.Items.AddRange(new ToolStripItem[] { HomeMenu, TasksMenu, InquiriesMenu, ProfileMenu });
            MainToolstrip.Location = new Point(0, 0);
            MainToolstrip.Name = "MainToolstrip";
            MainToolstrip.Size = new Size(1122, 27);
            MainToolstrip.TabIndex = 1;
            MainToolstrip.Text = "toolStrip1";
            MainToolstrip.ItemClicked += MainToolstrip_ItemClicked;
            // 
            // HomeMenu
            // 
            HomeMenu.DisplayStyle = ToolStripItemDisplayStyle.Text;
            HomeMenu.Image = (Image)resources.GetObject("HomeMenu.Image");
            HomeMenu.ImageTransparentColor = Color.Magenta;
            HomeMenu.Name = "HomeMenu";
            HomeMenu.Size = new Size(54, 24);
            HomeMenu.Text = "Home";
            // 
            // TasksMenu
            // 
            TasksMenu.DisplayStyle = ToolStripItemDisplayStyle.Text;
            TasksMenu.Image = (Image)resources.GetObject("TasksMenu.Image");
            TasksMenu.ImageTransparentColor = Color.Magenta;
            TasksMenu.Name = "TasksMenu";
            TasksMenu.Size = new Size(46, 24);
            TasksMenu.Text = "Tasks";
            // 
            // InquiriesMenu
            // 
            InquiriesMenu.DisplayStyle = ToolStripItemDisplayStyle.Text;
            InquiriesMenu.Image = (Image)resources.GetObject("InquiriesMenu.Image");
            InquiriesMenu.ImageTransparentColor = Color.Magenta;
            InquiriesMenu.Name = "InquiriesMenu";
            InquiriesMenu.Size = new Size(69, 24);
            InquiriesMenu.Text = "Inquiries";
            // 
            // ProfileMenu
            // 
            ProfileMenu.DisplayStyle = ToolStripItemDisplayStyle.Text;
            ProfileMenu.Image = (Image)resources.GetObject("ProfileMenu.Image");
            ProfileMenu.ImageTransparentColor = Color.Magenta;
            ProfileMenu.Name = "ProfileMenu";
            ProfileMenu.Size = new Size(56, 24);
            ProfileMenu.Text = "Profile";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightCoral;
            label3.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(0, 27);
            label3.Name = "label3";
            label3.Size = new Size(303, 62);
            label3.TabIndex = 28;
            label3.Text = "Add Reports";
            // 
            // reportTextBox
            // 
            reportTextBox.Location = new Point(234, 180);
            reportTextBox.Name = "reportTextBox";
            reportTextBox.Size = new Size(351, 27);
            reportTextBox.TabIndex = 30;
            // 
            // addReportButton
            // 
            addReportButton.BackColor = Color.LightCoral;
            addReportButton.Location = new Point(420, 241);
            addReportButton.Name = "addReportButton";
            addReportButton.Size = new Size(165, 57);
            addReportButton.TabIndex = 35;
            addReportButton.Text = "Submit";
            addReportButton.UseVisualStyleBackColor = false;
            addReportButton.Click += addReportButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightCoral;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(102, 182);
            label2.Name = "label2";
            label2.Size = new Size(126, 25);
            label2.TabIndex = 36;
            label2.Text = "Address issue";
            // 
            // ClientAddReports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(1122, 458);
            Controls.Add(label2);
            Controls.Add(addReportButton);
            Controls.Add(reportTextBox);
            Controls.Add(label3);
            Controls.Add(MainToolstrip);
            Name = "ClientAddReports";
            Text = "ClientAddReports";
            MainToolstrip.ResumeLayout(false);
            MainToolstrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip MainToolstrip;
        private ToolStripButton HomeMenu;
        private ToolStripButton TasksMenu;
        private ToolStripButton InquiriesMenu;
        private ToolStripButton ProfileMenu;
        private Label label3;
        private TextBox assignTaskTextBox;
        private Button addTaskButton;
        private Label label2;
        private TextBox reportTextBox;
        private Button addReportButton;
    }
}