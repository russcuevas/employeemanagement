namespace EmployeeManagement
{
    partial class AdminTasks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminTasks));
            summaryView = new DataGridView();
            assignedTaskView = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            button1 = new Button();
            AdminMainToolstrip = new ToolStrip();
            AdminHomeMenu = new ToolStripButton();
            AdminTasksMenu = new ToolStripButton();
            AdminOverviewMenu = new ToolStripButton();
            AdminProfileMenu = new ToolStripButton();
            AdminInquiriesMenu = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)summaryView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)assignedTaskView).BeginInit();
            AdminMainToolstrip.SuspendLayout();
            SuspendLayout();
            // 
            // summaryView
            // 
            summaryView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            summaryView.Location = new Point(891, 322);
            summaryView.Name = "summaryView";
            summaryView.RowHeadersWidth = 51;
            summaryView.RowTemplate.Height = 29;
            summaryView.Size = new Size(807, 374);
            summaryView.TabIndex = 22;
            // 
            // assignedTaskView
            // 
            assignedTaskView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            assignedTaskView.Location = new Point(73, 322);
            assignedTaskView.Name = "assignedTaskView";
            assignedTaskView.RowHeadersWidth = 51;
            assignedTaskView.RowTemplate.Height = 29;
            assignedTaskView.Size = new Size(742, 374);
            assignedTaskView.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightCoral;
            label2.Font = new Font("Segoe UI Semilight", 28.2F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(1040, 229);
            label2.Name = "label2";
            label2.Size = new Size(398, 62);
            label2.TabIndex = 20;
            label2.Text = "Progress Summary";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightCoral;
            label1.Font = new Font("Segoe UI Semilight", 28.2F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(287, 229);
            label1.Name = "label1";
            label1.Size = new Size(321, 62);
            label1.TabIndex = 19;
            label1.Text = "Assigned Tasks";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightCoral;
            label3.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(0, 27);
            label3.Name = "label3";
            label3.Size = new Size(144, 62);
            label3.TabIndex = 18;
            label3.Text = "Tasks";
            // 
            // button1
            // 
            button1.BackColor = Color.LightCoral;
            button1.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(138, 119);
            button1.Name = "button1";
            button1.Size = new Size(219, 59);
            button1.TabIndex = 23;
            button1.Text = "Add Tasks +";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // AdminMainToolstrip
            // 
            AdminMainToolstrip.ImageScalingSize = new Size(20, 20);
            AdminMainToolstrip.Items.AddRange(new ToolStripItem[] { AdminHomeMenu, AdminTasksMenu, AdminOverviewMenu, AdminProfileMenu, AdminInquiriesMenu });
            AdminMainToolstrip.Location = new Point(0, 0);
            AdminMainToolstrip.Name = "AdminMainToolstrip";
            AdminMainToolstrip.Size = new Size(1710, 27);
            AdminMainToolstrip.TabIndex = 39;
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
            // AdminTasks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(1710, 1055);
            Controls.Add(AdminMainToolstrip);
            Controls.Add(button1);
            Controls.Add(summaryView);
            Controls.Add(assignedTaskView);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Name = "AdminTasks";
            Text = "AdminTasks";
            ((System.ComponentModel.ISupportInitialize)summaryView).EndInit();
            ((System.ComponentModel.ISupportInitialize)assignedTaskView).EndInit();
            AdminMainToolstrip.ResumeLayout(false);
            AdminMainToolstrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView summaryView;
        private DataGridView assignedTaskView;
        private Label label2;
        private Label label1;
        private Label label3;
        private Button button1;
        private ToolStrip AdminMainToolstrip;
        private ToolStripButton AdminHomeMenu;
        private ToolStripButton AdminTasksMenu;
        private ToolStripButton AdminOverviewMenu;
        private ToolStripButton AdminProfileMenu;
        private ToolStripButton AdminInquiriesMenu;
    }
}