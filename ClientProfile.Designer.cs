namespace EmployeeManagement
{
    partial class ClientProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientProfile));
            MainToolstrip = new ToolStrip();
            HomeMenu = new ToolStripButton();
            TasksMenu = new ToolStripButton();
            InquiriesMenu = new ToolStripButton();
            ProfileMenu = new ToolStripButton();
            label3 = new Label();
            nameLabel = new Label();
            ageLabel = new Label();
            emailLabel = new Label();
            numberLabel = new Label();
            label6 = new Label();
            changePasswordButton = new Button();
            changeEmailButton = new Button();
            changeDetailsButton = new Button();
            positionLabel = new Label();
            MainToolstrip.SuspendLayout();
            SuspendLayout();
            // 
            // MainToolstrip
            // 
            MainToolstrip.ImageScalingSize = new Size(20, 20);
            MainToolstrip.Items.AddRange(new ToolStripItem[] { HomeMenu, TasksMenu, InquiriesMenu, ProfileMenu });
            MainToolstrip.Location = new Point(0, 0);
            MainToolstrip.Name = "MainToolstrip";
            MainToolstrip.Size = new Size(1403, 27);
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
            label3.Size = new Size(172, 62);
            label3.TabIndex = 8;
            label3.Text = "Profile";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = Color.LightCoral;
            nameLabel.Font = new Font("Segoe UI", 22.2F, FontStyle.Italic, GraphicsUnit.Point);
            nameLabel.Location = new Point(12, 127);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(128, 50);
            nameLabel.TabIndex = 11;
            nameLabel.Text = "Name:";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.BackColor = Color.LightCoral;
            ageLabel.Font = new Font("Segoe UI", 22.2F, FontStyle.Italic, GraphicsUnit.Point);
            ageLabel.Location = new Point(12, 227);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(91, 50);
            ageLabel.TabIndex = 12;
            ageLabel.Text = "Age:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = Color.LightCoral;
            emailLabel.Font = new Font("Segoe UI", 22.2F, FontStyle.Italic, GraphicsUnit.Point);
            emailLabel.Location = new Point(12, 323);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(120, 50);
            emailLabel.TabIndex = 13;
            emailLabel.Text = "Email:";
            // 
            // numberLabel
            // 
            numberLabel.AutoSize = true;
            numberLabel.BackColor = Color.LightCoral;
            numberLabel.Font = new Font("Segoe UI", 22.2F, FontStyle.Italic, GraphicsUnit.Point);
            numberLabel.Location = new Point(12, 433);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new Size(162, 50);
            numberLabel.TabIndex = 14;
            numberLabel.Text = "Number:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.LightCoral;
            label6.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(60, 538);
            label6.Name = "label6";
            label6.Size = new Size(391, 62);
            label6.TabIndex = 15;
            label6.Text = "Security Options";
            // 
            // changePasswordButton
            // 
            changePasswordButton.BackColor = Color.LightCoral;
            changePasswordButton.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            changePasswordButton.Location = new Point(60, 678);
            changePasswordButton.Name = "changePasswordButton";
            changePasswordButton.Size = new Size(327, 71);
            changePasswordButton.TabIndex = 16;
            changePasswordButton.Text = "Change Password";
            changePasswordButton.UseVisualStyleBackColor = false;
            changePasswordButton.Click += changePasswordButton_Click;
            // 
            // changeEmailButton
            // 
            changeEmailButton.BackColor = Color.LightCoral;
            changeEmailButton.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            changeEmailButton.Location = new Point(509, 678);
            changeEmailButton.Name = "changeEmailButton";
            changeEmailButton.Size = new Size(327, 71);
            changeEmailButton.TabIndex = 17;
            changeEmailButton.Text = "Change Email ";
            changeEmailButton.UseVisualStyleBackColor = false;
            changeEmailButton.Click += changeEmailButton_Click;
            // 
            // changeDetailsButton
            // 
            changeDetailsButton.BackColor = Color.LightCoral;
            changeDetailsButton.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            changeDetailsButton.Location = new Point(994, 678);
            changeDetailsButton.Name = "changeDetailsButton";
            changeDetailsButton.Size = new Size(327, 71);
            changeDetailsButton.TabIndex = 18;
            changeDetailsButton.Text = "Change Details";
            changeDetailsButton.UseVisualStyleBackColor = false;
            changeDetailsButton.Click += changeDetailsButton_Click;
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.BackColor = Color.LightCoral;
            positionLabel.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            positionLabel.Location = new Point(860, 91);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new Size(219, 62);
            positionLabel.TabIndex = 19;
            positionLabel.Text = "Position:";
            // 
            // ClientProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(1403, 789);
            Controls.Add(positionLabel);
            Controls.Add(changeDetailsButton);
            Controls.Add(changeEmailButton);
            Controls.Add(changePasswordButton);
            Controls.Add(label6);
            Controls.Add(numberLabel);
            Controls.Add(emailLabel);
            Controls.Add(ageLabel);
            Controls.Add(nameLabel);
            Controls.Add(MainToolstrip);
            Controls.Add(label3);
            Name = "ClientProfile";
            Text = "ClientProfile";
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
        private Label nameLabel;
        private Label ageLabel;
        private Label emailLabel;
        private Label numberLabel;
        private Label label6;
        private Button changePasswordButton;
        private Button changeEmailButton;
        private Button changeDetailsButton;
        private Label positionLabel;
    }
}