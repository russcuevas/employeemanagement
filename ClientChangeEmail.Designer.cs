namespace EmployeeManagement
{
    partial class ClientChangeEmail
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox newEmailTextBox;
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
            newEmailTextBox = new TextBox();
            updateEmailButton = new Button();
            currentEmailLabel = new Label();
            titleLabel = new Label();
            SuspendLayout();
            // 
            // newEmailTextBox
            // 
            newEmailTextBox.Location = new Point(36, 100);
            newEmailTextBox.Name = "newEmailTextBox";
            newEmailTextBox.Size = new Size(300, 27);
            newEmailTextBox.TabIndex = 0;
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
            // ClientChangeEmail
            // 
            ClientSize = new Size(465, 246);
            Controls.Add(titleLabel);
            Controls.Add(currentEmailLabel);
            Controls.Add(updateEmailButton);
            Controls.Add(newEmailTextBox);
            Name = "ClientChangeEmail";
            Text = "Client Change Email";
            Load += ClientChangeEmail_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
