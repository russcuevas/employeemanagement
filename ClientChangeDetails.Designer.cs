namespace EmployeeManagement
{
    partial class ClientChangeDetails
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox nameTextBox;
        private TextBox ageTextBox;
        private TextBox numberTextBox;
        private Button updateDetailsButton;
        private Label nameLabel;
        private Label ageLabel;
        private Label numberLabel;
        private Label titleLabel;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            nameTextBox = new TextBox();
            ageTextBox = new TextBox();
            numberTextBox = new TextBox();
            updateDetailsButton = new Button();
            nameLabel = new Label();
            ageLabel = new Label();
            numberLabel = new Label();
            titleLabel = new Label();
            SuspendLayout();

            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(160, 60);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(200, 27);
            nameTextBox.TabIndex = 0;

            // 
            // ageTextBox
            // 
            ageTextBox.Location = new Point(160, 110);
            ageTextBox.Name = "ageTextBox";
            ageTextBox.Size = new Size(200, 27);
            ageTextBox.TabIndex = 1;

            // 
            // numberTextBox
            // 
            numberTextBox.Location = new Point(160, 160);
            numberTextBox.Name = "numberTextBox";
            numberTextBox.Size = new Size(200, 27);
            numberTextBox.TabIndex = 2;

            // 
            // updateDetailsButton
            // 
            updateDetailsButton.Location = new Point(160, 210);
            updateDetailsButton.Name = "updateDetailsButton";
            updateDetailsButton.Size = new Size(200, 30);
            updateDetailsButton.TabIndex = 3;
            updateDetailsButton.Text = "Update Details";
            updateDetailsButton.UseVisualStyleBackColor = true;
            updateDetailsButton.Click += updateDetailsButton_Click;

            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(50, 60);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(49, 20);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Name";

            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new Point(50, 110);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(36, 20);
            ageLabel.TabIndex = 5;
            ageLabel.Text = "Age";

            // 
            // numberLabel
            // 
            numberLabel.AutoSize = true;
            numberLabel.Location = new Point(50, 160);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new Size(50, 20);
            numberLabel.TabIndex = 6;
            numberLabel.Text = "Phone";

            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            titleLabel.Location = new Point(50, 9);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(177, 29);
            titleLabel.TabIndex = 7;
            titleLabel.Text = "Change Details";

            // 
            // ClientChangeDetails
            // 
            ClientSize = new Size(400, 280);
            Controls.Add(titleLabel);
            Controls.Add(numberLabel);
            Controls.Add(ageLabel);
            Controls.Add(nameLabel);
            Controls.Add(updateDetailsButton);
            Controls.Add(numberTextBox);
            Controls.Add(ageTextBox);
            Controls.Add(nameTextBox);
            Name = "ClientChangeDetails";
            Text = "Change Details";
            Load += ClientChangeDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
