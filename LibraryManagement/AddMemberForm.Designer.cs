namespace LibraryManagement
{
    partial class AddMemberForm
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
            email = new Label();
            Password = new Label();
            btnSave = new Button();
            name = new Label();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(120, 69);
            txtName.Name = "txtName";
            txtName.Size = new Size(259, 27);
            txtName.TabIndex = 0;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(120, 133);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(259, 27);
            txtEmail.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(120, 200);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(259, 27);
            txtPassword.TabIndex = 2;
            // 
            // email
            // 
            email.AutoSize = true;
            email.Location = new Point(25, 136);
            email.Name = "email";
            email.Size = new Size(46, 20);
            email.TabIndex = 4;
            email.Text = "Email";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(31, 200);
            Password.Name = "Password";
            Password.Size = new Size(70, 20);
            Password.TabIndex = 5;
            Password.Text = "Password";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(117, 313);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(30, 68);
            name.Name = "name";
            name.Size = new Size(49, 20);
            name.TabIndex = 7;
            name.Text = "Name";
            name.Click += name_Click;
            // 
            // AddMemberForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(name);
            Controls.Add(btnSave);
            Controls.Add(Password);
            Controls.Add(email);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Name = "AddMemberForm";
            Text = "AddMemberForm";
            Load += AddMemberForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Label namelabel;
        private Label email;
        private Label Password;
        private Button btnSave;
        private Label name;
    }
}