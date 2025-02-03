namespace LibraryManagement
{
    partial class EditMemberForm
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
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            name = new Label();
            email = new Label();
            Password = new Label();
            btnSave = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(230, 131);
            txtName.Name = "txtName";
            txtName.Size = new Size(259, 27);
            txtName.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(230, 183);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(259, 27);
            txtEmail.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(230, 239);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(259, 27);
            txtPassword.TabIndex = 3;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(92, 138);
            name.Name = "name";
            name.Size = new Size(49, 20);
            name.TabIndex = 8;
            name.Text = "Name";
            // 
            // email
            // 
            email.AutoSize = true;
            email.Location = new Point(95, 190);
            email.Name = "email";
            email.Size = new Size(46, 20);
            email.TabIndex = 9;
            email.Text = "Email";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(95, 246);
            Password.Name = "Password";
            Password.Size = new Size(70, 20);
            Password.TabIndex = 10;
            Password.Text = "Password";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(142, 339);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 37);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // EditMemberForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(Password);
            Controls.Add(email);
            Controls.Add(name);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Name = "EditMemberForm";
            Text = "EditMemberForm";
            Load += EditMemberForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Label name;
        private Label email;
        private Label Password;
        private Button btnSave;
    }
}