namespace EmployeeManagement
{
    partial class AdminProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminProfile));
            positionLabel = new Label();
            changeDetailsButton = new Button();
            changeEmailButton = new Button();
            changePasswordButton = new Button();
            label6 = new Label();
            numberLabel = new Label();
            emailLabel = new Label();
            ageLabel = new Label();
            nameLabel = new Label();
            label3 = new Label();
            AdminMainToolstrip = new ToolStrip();
            AdminHomeMenu = new ToolStripButton();
            AdminTasksMenu = new ToolStripButton();
            AdminOverviewMenu = new ToolStripButton();
            AdminProfileMenu = new ToolStripButton();
            AdminInquiriesMenu = new ToolStripButton();
            AdminMainToolstrip.SuspendLayout();
            SuspendLayout();
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.BackColor = Color.LightCoral;
            positionLabel.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            positionLabel.Location = new Point(860, 91);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new Size(219, 62);
            positionLabel.TabIndex = 30;
            positionLabel.Text = "Position:";
            // 
            // changeDetailsButton
            // 
            changeDetailsButton.BackColor = Color.LightCoral;
            changeDetailsButton.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            changeDetailsButton.Location = new Point(994, 678);
            changeDetailsButton.Name = "changeDetailsButton";
            changeDetailsButton.Size = new Size(327, 71);
            changeDetailsButton.TabIndex = 29;
            changeDetailsButton.Text = "Change Details";
            changeDetailsButton.UseVisualStyleBackColor = false;
            changeDetailsButton.Click += changeDetailsButton_Click;
            // 
            // changeEmailButton
            // 
            changeEmailButton.BackColor = Color.LightCoral;
            changeEmailButton.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            changeEmailButton.Location = new Point(509, 678);
            changeEmailButton.Name = "changeEmailButton";
            changeEmailButton.Size = new Size(327, 71);
            changeEmailButton.TabIndex = 28;
            changeEmailButton.Text = "Change Email ";
            changeEmailButton.UseVisualStyleBackColor = false;
            changeEmailButton.Click += changeEmailButton_Click;
            // 
            // changePasswordButton
            // 
            changePasswordButton.BackColor = Color.LightCoral;
            changePasswordButton.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            changePasswordButton.Location = new Point(60, 678);
            changePasswordButton.Name = "changePasswordButton";
            changePasswordButton.Size = new Size(327, 71);
            changePasswordButton.TabIndex = 27;
            changePasswordButton.Text = "Change Password";
            changePasswordButton.UseVisualStyleBackColor = false;
            changePasswordButton.Click += changePasswordButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.LightCoral;
            label6.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(60, 538);
            label6.Name = "label6";
            label6.Size = new Size(391, 62);
            label6.TabIndex = 26;
            label6.Text = "Security Options";
            // 
            // numberLabel
            // 
            numberLabel.AutoSize = true;
            numberLabel.BackColor = Color.LightCoral;
            numberLabel.Font = new Font("Segoe UI", 22.2F, FontStyle.Italic, GraphicsUnit.Point);
            numberLabel.Location = new Point(12, 433);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new Size(162, 50);
            numberLabel.TabIndex = 25;
            numberLabel.Text = "Number:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = Color.LightCoral;
            emailLabel.Font = new Font("Segoe UI", 22.2F, FontStyle.Italic, GraphicsUnit.Point);
            emailLabel.Location = new Point(12, 323);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(120, 50);
            emailLabel.TabIndex = 24;
            emailLabel.Text = "Email:";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.BackColor = Color.LightCoral;
            ageLabel.Font = new Font("Segoe UI", 22.2F, FontStyle.Italic, GraphicsUnit.Point);
            ageLabel.Location = new Point(12, 227);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(91, 50);
            ageLabel.TabIndex = 23;
            ageLabel.Text = "Age:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = Color.LightCoral;
            nameLabel.Font = new Font("Segoe UI", 22.2F, FontStyle.Italic, GraphicsUnit.Point);
            nameLabel.Location = new Point(12, 127);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(128, 50);
            nameLabel.TabIndex = 22;
            nameLabel.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightCoral;
            label3.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(0, 27);
            label3.Name = "label3";
            label3.Size = new Size(172, 62);
            label3.TabIndex = 21;
            label3.Text = "Profile";
            // 
            // AdminMainToolstrip
            // 
            AdminMainToolstrip.ImageScalingSize = new Size(20, 20);
            AdminMainToolstrip.Items.AddRange(new ToolStripItem[] { AdminHomeMenu, AdminTasksMenu, AdminOverviewMenu, AdminProfileMenu, AdminInquiriesMenu });
            AdminMainToolstrip.Location = new Point(0, 0);
            AdminMainToolstrip.Name = "AdminMainToolstrip";
            AdminMainToolstrip.Size = new Size(1566, 27);
            AdminMainToolstrip.TabIndex = 38;
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
            // AdminProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(1566, 1024);
            Controls.Add(AdminMainToolstrip);
            Controls.Add(positionLabel);
            Controls.Add(changeDetailsButton);
            Controls.Add(changeEmailButton);
            Controls.Add(changePasswordButton);
            Controls.Add(label6);
            Controls.Add(numberLabel);
            Controls.Add(emailLabel);
            Controls.Add(ageLabel);
            Controls.Add(nameLabel);
            Controls.Add(label3);
            Name = "AdminProfile";
            Text = "AdminProfile";
            AdminMainToolstrip.ResumeLayout(false);
            AdminMainToolstrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label positionLabel;
        private Button changeDetailsButton;
        private Button button1;
        private Button changePasswordButton;
        private Label label6;
        private Label numberLabel;
        private Label emailLabel;
        private Label ageLabel;
        private Label nameLabel;
        private Label label3;
        private Button changeEmailButton;
        private ToolStrip AdminMainToolstrip;
        private ToolStripButton AdminHomeMenu;
        private ToolStripButton AdminTasksMenu;
        private ToolStripButton AdminOverviewMenu;
        private ToolStripButton AdminProfileMenu;
        private ToolStripButton AdminInquiriesMenu;
    }
}