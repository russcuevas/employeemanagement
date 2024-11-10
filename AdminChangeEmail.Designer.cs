namespace EmployeeManagement
{
    partial class AdminChangeEmail
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox emailTextBox;
        private Button updateEmailButton;
        private Label currentEmailLabel;
        private Label titleLabel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            emailTextBox = new TextBox();
            updateEmailButton = new Button();
            currentEmailLabel = new Label();
            titleLabel = new Label();
            SuspendLayout();
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(36, 100);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(300, 27);
            emailTextBox.TabIndex = 0;
            // 
            // updateEmailButton
            // 
            updateEmailButton.Location = new Point(164, 147);
            updateEmailButton.Name = "updateEmailButton";
            updateEmailButton.Size = new Size(172, 32);
            updateEmailButton.TabIndex = 1;
            updateEmailButton.Text = "Update Email";
            updateEmailButton.UseVisualStyleBackColor = true;
            updateEmailButton.Click += updateEmailButton_Click;
            // 
            // currentEmailLabel
            // 
            currentEmailLabel.AutoSize = true;
            currentEmailLabel.Location = new Point(36, 77);
            currentEmailLabel.Name = "currentEmailLabel";
            currentEmailLabel.Size = new Size(118, 20);
            currentEmailLabel.TabIndex = 2;
            currentEmailLabel.Text = "Enter new email:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            titleLabel.Location = new Point(36, 26);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(164, 29);
            titleLabel.TabIndex = 3;
            titleLabel.Text = "Change Email";
            // 
            // AdminChangeEmail
            // 
            ClientSize = new Size(465, 246);
            Controls.Add(titleLabel);
            Controls.Add(currentEmailLabel);
            Controls.Add(updateEmailButton);
            Controls.Add(emailTextBox);
            Name = "AdminChangeEmail";
            Text = "Admin Change Email";
            Load += AdminChangeEmail_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
