namespace EmployeeManagement
{
    partial class AdminAddTasks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAddTasks));
            label3 = new Label();
            employeeComboBox = new ComboBox();
            assignTaskTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            addTaskButton = new Button();
            chooseDateTextBox = new DateTimePicker();
            AdminMainToolstrip = new ToolStrip();
            AdminHomeMenu = new ToolStripButton();
            AdminTasksMenu = new ToolStripButton();
            AdminOverviewMenu = new ToolStripButton();
            AdminProfileMenu = new ToolStripButton();
            AdminInquiriesMenu = new ToolStripButton();
            AdminMainToolstrip.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightCoral;
            label3.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(0, 27);
            label3.Name = "label3";
            label3.Size = new Size(248, 62);
            label3.TabIndex = 27;
            label3.Text = "Add Tasks";
            // 
            // employeeComboBox
            // 
            employeeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            employeeComboBox.FormattingEnabled = true;
            employeeComboBox.Location = new Point(245, 178);
            employeeComboBox.Name = "employeeComboBox";
            employeeComboBox.Size = new Size(351, 28);
            employeeComboBox.TabIndex = 28;
            employeeComboBox.SelectedIndexChanged += employeeComboBox_SelectedIndexChanged;
            // 
            // assignTaskTextBox
            // 
            assignTaskTextBox.Location = new Point(245, 251);
            assignTaskTextBox.Name = "assignTaskTextBox";
            assignTaskTextBox.Size = new Size(351, 27);
            assignTaskTextBox.TabIndex = 29;
            assignTaskTextBox.TextChanged += assignTaskTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightCoral;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(65, 181);
            label1.Name = "label1";
            label1.Size = new Size(157, 25);
            label1.TabIndex = 31;
            label1.Text = "Choose Employee";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightCoral;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(64, 253);
            label2.Name = "label2";
            label2.Size = new Size(118, 25);
            label2.TabIndex = 32;
            label2.Text = "Assign tasks";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightCoral;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(65, 324);
            label4.Name = "label4";
            label4.Size = new Size(117, 25);
            label4.TabIndex = 33;
            label4.Text = "Choose Date";
            // 
            // addTaskButton
            // 
            addTaskButton.BackColor = Color.LightCoral;
            addTaskButton.Location = new Point(431, 393);
            addTaskButton.Name = "addTaskButton";
            addTaskButton.Size = new Size(165, 57);
            addTaskButton.TabIndex = 34;
            addTaskButton.Text = "Submit";
            addTaskButton.UseVisualStyleBackColor = false;
            addTaskButton.Click += addTaskButton_Click;
            // 
            // chooseDateTextBox
            // 
            chooseDateTextBox.Location = new Point(245, 324);
            chooseDateTextBox.Name = "chooseDateTextBox";
            chooseDateTextBox.Size = new Size(351, 27);
            chooseDateTextBox.TabIndex = 36;
            chooseDateTextBox.ValueChanged += chooseDateTextBox_ValueChanged;
            // 
            // AdminMainToolstrip
            // 
            AdminMainToolstrip.ImageScalingSize = new Size(20, 20);
            AdminMainToolstrip.Items.AddRange(new ToolStripItem[] { AdminHomeMenu, AdminTasksMenu, AdminOverviewMenu, AdminProfileMenu, AdminInquiriesMenu });
            AdminMainToolstrip.Location = new Point(0, 0);
            AdminMainToolstrip.Name = "AdminMainToolstrip";
            AdminMainToolstrip.Size = new Size(1567, 27);
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
            // AdminAddTasks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(1567, 930);
            Controls.Add(AdminMainToolstrip);
            Controls.Add(chooseDateTextBox);
            Controls.Add(addTaskButton);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(assignTaskTextBox);
            Controls.Add(employeeComboBox);
            Controls.Add(label3);
            Name = "AdminAddTasks";
            Text = "AdminAddTasks";
            AdminMainToolstrip.ResumeLayout(false);
            AdminMainToolstrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private ComboBox employeeComboBox;
        private TextBox assignTaskTextBox;
        private Label label1;
        private Label label2;
        private Label label4;
        private Button addTaskButton;
        private DateTimePicker chooseDateTextBox;
        private ToolStrip AdminMainToolstrip;
        private ToolStripButton AdminHomeMenu;
        private ToolStripButton AdminTasksMenu;
        private ToolStripButton AdminOverviewMenu;
        private ToolStripButton AdminProfileMenu;
        private ToolStripButton AdminInquiriesMenu;
    }
}