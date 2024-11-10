namespace EmployeeManagement
{
    partial class ClientHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientHome));
            MainToolstrip = new ToolStrip();
            HomeMenu = new ToolStripButton();
            TasksMenu = new ToolStripButton();
            InquiriesMenu = new ToolStripButton();
            ProfileMenu = new ToolStripButton();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            taskToday = new DataGridView();
            completedTask = new DataGridView();
            MainToolstrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)taskToday).BeginInit();
            ((System.ComponentModel.ISupportInitialize)completedTask).BeginInit();
            SuspendLayout();
            // 
            // MainToolstrip
            // 
            MainToolstrip.ImageScalingSize = new Size(20, 20);
            MainToolstrip.Items.AddRange(new ToolStripItem[] { HomeMenu, TasksMenu, InquiriesMenu, ProfileMenu });
            MainToolstrip.Location = new Point(0, 0);
            MainToolstrip.Name = "MainToolstrip";
            MainToolstrip.Size = new Size(1644, 27);
            MainToolstrip.TabIndex = 0;
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
            label3.Size = new Size(160, 62);
            label3.TabIndex = 7;
            label3.Text = "Home";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightCoral;
            label1.Font = new Font("Segoe UI Semilight", 28.2F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(157, 134);
            label1.Name = "label1";
            label1.Size = new Size(344, 62);
            label1.TabIndex = 8;
            label1.Text = "Tasks For Today";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightCoral;
            label2.Font = new Font("Segoe UI Semilight", 28.2F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(891, 134);
            label2.Name = "label2";
            label2.Size = new Size(344, 62);
            label2.TabIndex = 9;
            label2.Text = "Completed Task";
            // 
            // taskToday
            // 
            taskToday.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            taskToday.Location = new Point(38, 234);
            taskToday.Name = "taskToday";
            taskToday.RowHeadersWidth = 51;
            taskToday.RowTemplate.Height = 29;
            taskToday.Size = new Size(625, 374);
            taskToday.TabIndex = 15;
            // 
            // completedTask
            // 
            completedTask.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            completedTask.Location = new Point(787, 234);
            completedTask.Name = "completedTask";
            completedTask.RowHeadersWidth = 51;
            completedTask.RowTemplate.Height = 29;
            completedTask.Size = new Size(752, 374);
            completedTask.TabIndex = 16;
            // 
            // ClientHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(1644, 1055);
            Controls.Add(completedTask);
            Controls.Add(taskToday);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(MainToolstrip);
            Name = "ClientHome";
            Text = "ClientHome";
            MainToolstrip.ResumeLayout(false);
            MainToolstrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)taskToday).EndInit();
            ((System.ComponentModel.ISupportInitialize)completedTask).EndInit();
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
        private Label label1;
        private Label label2;
        private DataGridView taskToday;
        private DataGridView completedTask;
    }
}