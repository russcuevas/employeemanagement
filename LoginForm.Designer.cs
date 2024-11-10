namespace EmployeeManagement
{
    partial class LoginForm
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
            usernameTextbox = new TextBox();
            passwordTextbox = new TextBox();
            label1 = new Label();
            loginButton = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // usernameTextbox
            // 
            usernameTextbox.Location = new Point(311, 165);
            usernameTextbox.Name = "usernameTextbox";
            usernameTextbox.Size = new Size(384, 27);
            usernameTextbox.TabIndex = 0;
            // 
            // passwordTextbox
            // 
            passwordTextbox.Location = new Point(311, 214);
            passwordTextbox.Name = "passwordTextbox";
            passwordTextbox.Size = new Size(384, 27);
            passwordTextbox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightCoral;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(154, 164);
            label1.Name = "label1";
            label1.Size = new Size(96, 25);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.LightCoral;
            loginButton.Location = new Point(154, 279);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(186, 62);
            loginButton.TabIndex = 3;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightCoral;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(154, 216);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightCoral;
            label3.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(154, 57);
            label3.Name = "label3";
            label3.Size = new Size(615, 50);
            label3.TabIndex = 5;
            label3.Text = "EMPLOYER'S TASK DISTRIBUTION";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(964, 414);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(loginButton);
            Controls.Add(label1);
            Controls.Add(passwordTextbox);
            Controls.Add(usernameTextbox);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameTextbox;
        private TextBox passwordTextbox;
        private Label label1;
        private Button loginButton;
        private Label label2;
        private Label label3;
    }
}