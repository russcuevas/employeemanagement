namespace EmployeeManagement
{
    partial class AdminChangePassword
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox newPasswordTextBox;
        private TextBox confirmPasswordTextBox;
        private Button updatePasswordButton;
        private Label label1;
        private Label label2;

        private void InitializeComponent()
        {
            newPasswordTextBox = new TextBox();
            confirmPasswordTextBox = new TextBox();
            updatePasswordButton = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // newPasswordTextBox
            // 
            newPasswordTextBox.Location = new Point(160, 46);
            newPasswordTextBox.Name = "newPasswordTextBox";
            newPasswordTextBox.PasswordChar = '*';
            newPasswordTextBox.Size = new Size(200, 27);
            newPasswordTextBox.TabIndex = 0;
            // 
            // confirmPasswordTextBox
            // 
            confirmPasswordTextBox.Location = new Point(217, 96);
            confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            confirmPasswordTextBox.PasswordChar = '*';
            confirmPasswordTextBox.Size = new Size(200, 27);
            confirmPasswordTextBox.TabIndex = 1;
            // 
            // updatePasswordButton
            // 
            updatePasswordButton.Location = new Point(217, 151);
            updatePasswordButton.Name = "updatePasswordButton";
            updatePasswordButton.Size = new Size(200, 30);
            updatePasswordButton.TabIndex = 2;
            updatePasswordButton.Text = "Update Password";
            updatePasswordButton.UseVisualStyleBackColor = true;
            updatePasswordButton.Click += updatePasswordButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 53);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 3;
            label1.Text = "New Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 103);
            label2.Name = "label2";
            label2.Size = new Size(161, 20);
            label2.TabIndex = 4;
            label2.Text = "Confirm New Password";
            // 
            // AdminChangePassword
            // 
            ClientSize = new Size(504, 270);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(updatePasswordButton);
            Controls.Add(confirmPasswordTextBox);
            Controls.Add(newPasswordTextBox);
            Name = "AdminChangePassword";
            Text = "Change Password";
            Load += AdminChangePassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
