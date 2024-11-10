namespace EmployeeManagement
{
    partial class ClientInquiries
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientInquiries));
            MainToolstrip = new ToolStrip();
            HomeMenu = new ToolStripButton();
            TasksMenu = new ToolStripButton();
            InquiriesMenu = new ToolStripButton();
            ProfileMenu = new ToolStripButton();
            label3 = new Label();
            reportButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            MainToolstrip.SuspendLayout();
            SuspendLayout();
            // 
            // MainToolstrip
            // 
            MainToolstrip.ImageScalingSize = new Size(20, 20);
            MainToolstrip.Items.AddRange(new ToolStripItem[] { HomeMenu, TasksMenu, InquiriesMenu, ProfileMenu });
            MainToolstrip.Location = new Point(0, 0);
            MainToolstrip.Name = "MainToolstrip";
            MainToolstrip.Size = new Size(1316, 27);
            MainToolstrip.TabIndex = 7;
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
            label3.Size = new Size(218, 62);
            label3.TabIndex = 8;
            label3.Text = "Inquiries";
            // 
            // reportButton
            // 
            reportButton.BackColor = Color.LightCoral;
            reportButton.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            reportButton.Location = new Point(84, 130);
            reportButton.Name = "reportButton";
            reportButton.Size = new Size(399, 82);
            reportButton.TabIndex = 9;
            reportButton.Text = "Report Issues";
            reportButton.UseVisualStyleBackColor = false;
            reportButton.Click += reportButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightCoral;
            label1.Font = new Font("Segoe UI Semilight", 28.2F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(12, 348);
            label1.Name = "label1";
            label1.Size = new Size(271, 62);
            label1.TabIndex = 10;
            label1.Text = "Information:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightCoral;
            label2.Font = new Font("Segoe UI Semilight", 28.2F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(84, 429);
            label2.Name = "label2";
            label2.Size = new Size(210, 62);
            label2.TabIndex = 11;
            label2.Text = "09*******";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightCoral;
            label4.Font = new Font("Segoe UI Semilight", 28.2F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(84, 517);
            label4.Name = "label4";
            label4.Size = new Size(478, 62);
            label4.TabIndex = 12;
            label4.Text = "adminako@gmail.com";
            // 
            // ClientInquiries
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(1316, 646);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(reportButton);
            Controls.Add(MainToolstrip);
            Controls.Add(label3);
            Name = "ClientInquiries";
            Text = "ClientInquiries";
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
        private Button reportButton;
        private Label label1;
        private Label label2;
        private Label label4;
    }
}