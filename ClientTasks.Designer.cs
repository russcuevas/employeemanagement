namespace EmployeeManagement
{
    partial class ClientTasks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientTasks));
            MainToolstrip = new ToolStrip();
            HomeMenu = new ToolStripButton();
            TasksMenu = new ToolStripButton();
            InquiriesMenu = new ToolStripButton();
            ProfileMenu = new ToolStripButton();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            completedTasks = new DataGridView();
            upcomingTask = new DataGridView();
            todayTasks = new DataGridView();
            MainToolstrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)completedTasks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)upcomingTask).BeginInit();
            ((System.ComponentModel.ISupportInitialize)todayTasks).BeginInit();
            SuspendLayout();
            // 
            // MainToolstrip
            // 
            MainToolstrip.ImageScalingSize = new Size(20, 20);
            MainToolstrip.Items.AddRange(new ToolStripItem[] { HomeMenu, TasksMenu, InquiriesMenu, ProfileMenu });
            MainToolstrip.Location = new Point(0, 0);
            MainToolstrip.Name = "MainToolstrip";
            MainToolstrip.Size = new Size(1428, 27);
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
            label3.Size = new Size(144, 62);
            label3.TabIndex = 6;
            label3.Text = "Tasks";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightCoral;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(93, 145);
            label1.Name = "label1";
            label1.Size = new Size(187, 50);
            label1.TabIndex = 9;
            label1.Text = "Past Tasks";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightCoral;
            label2.Font = new Font("Segoe UI", 22.2F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(93, 521);
            label2.Name = "label2";
            label2.Size = new Size(239, 50);
            label2.TabIndex = 10;
            label2.Text = "Today's Tasks";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightCoral;
            label4.Font = new Font("Segoe UI", 22.2F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(776, 145);
            label4.Name = "label4";
            label4.Size = new Size(283, 50);
            label4.TabIndex = 11;
            label4.Text = "Upcoming Tasks";
            // 
            // completedTasks
            // 
            completedTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            completedTasks.Location = new Point(93, 212);
            completedTasks.Name = "completedTasks";
            completedTasks.RowHeadersWidth = 51;
            completedTasks.RowTemplate.Height = 29;
            completedTasks.Size = new Size(656, 284);
            completedTasks.TabIndex = 16;
            // 
            // upcomingTask
            // 
            upcomingTask.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            upcomingTask.Location = new Point(776, 212);
            upcomingTask.Name = "upcomingTask";
            upcomingTask.RowHeadersWidth = 51;
            upcomingTask.RowTemplate.Height = 29;
            upcomingTask.Size = new Size(590, 284);
            upcomingTask.TabIndex = 17;
            // 
            // todayTasks
            // 
            todayTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            todayTasks.Location = new Point(93, 594);
            todayTasks.Name = "todayTasks";
            todayTasks.RowHeadersWidth = 51;
            todayTasks.RowTemplate.Height = 29;
            todayTasks.Size = new Size(684, 287);
            todayTasks.TabIndex = 18;
            // 
            // ClientTasks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(1428, 874);
            Controls.Add(todayTasks);
            Controls.Add(upcomingTask);
            Controls.Add(completedTasks);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(MainToolstrip);
            Name = "ClientTasks";
            Text = "ClientTasks";
            MainToolstrip.ResumeLayout(false);
            MainToolstrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)completedTasks).EndInit();
            ((System.ComponentModel.ISupportInitialize)upcomingTask).EndInit();
            ((System.ComponentModel.ISupportInitialize)todayTasks).EndInit();
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
        private Label label4;
        private DataGridView completedTasks;
        private DataGridView upcomingTask;
        private DataGridView todayTasks;
    }
}