namespace LibraryManagement
{
    partial class loginform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginform));
            Email = new Label();
            password = new Label();
            role = new Label();
            btnlogin = new Button();
            txtemail = new TextBox();
            txtpassword = new TextBox();
            comborole = new ComboBox();
            labellms = new Label();
            SuspendLayout();
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.BackColor = SystemColors.InactiveCaption;
            Email.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Email.ForeColor = SystemColors.WindowFrame;
            Email.Location = new Point(22, 209);
            Email.Name = "Email";
            Email.Size = new Size(64, 28);
            Email.TabIndex = 0;
            Email.Text = "Email";
            Email.Click += email_Click;
            // 
            // password
            // 
            password.AutoSize = true;
            password.BackColor = SystemColors.InactiveCaption;
            password.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            password.ForeColor = SystemColors.WindowFrame;
            password.Location = new Point(22, 264);
            password.Name = "password";
            password.Size = new Size(101, 28);
            password.TabIndex = 1;
            password.Text = "Password";
            // 
            // role
            // 
            role.AutoSize = true;
            role.BackColor = SystemColors.InactiveCaption;
            role.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            role.ForeColor = SystemColors.WindowFrame;
            role.Location = new Point(22, 316);
            role.Name = "role";
            role.Size = new Size(54, 28);
            role.TabIndex = 2;
            role.Text = "Role";
            // 
            // btnlogin
            // 
            btnlogin.BackColor = SystemColors.InactiveCaption;
            btnlogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogin.ForeColor = SystemColors.WindowFrame;
            btnlogin.Location = new Point(183, 376);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(94, 42);
            btnlogin.TabIndex = 3;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // txtemail
            // 
            txtemail.BackColor = SystemColors.InactiveCaption;
            txtemail.Location = new Point(146, 209);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(284, 27);
            txtemail.TabIndex = 4;
            txtemail.TextChanged += txtname_TextChanged;
            // 
            // txtpassword
            // 
            txtpassword.BackColor = SystemColors.InactiveCaption;
            txtpassword.Location = new Point(146, 268);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(284, 27);
            txtpassword.TabIndex = 5;
            // 
            // comborole
            // 
            comborole.BackColor = SystemColors.InactiveCaption;
            comborole.FormattingEnabled = true;
            comborole.Location = new Point(148, 316);
            comborole.Name = "comborole";
            comborole.Size = new Size(151, 28);
            comborole.TabIndex = 6;
            // 
            // labellms
            // 
            labellms.AutoSize = true;
            labellms.BackColor = SystemColors.Info;
            labellms.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labellms.ForeColor = SystemColors.ControlDarkDark;
            labellms.Location = new Point(173, 60);
            labellms.Name = "labellms";
            labellms.Size = new Size(476, 46);
            labellms.TabIndex = 7;
            labellms.Text = "Library Management System";
            // 
            // loginform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(labellms);
            Controls.Add(comborole);
            Controls.Add(txtpassword);
            Controls.Add(txtemail);
            Controls.Add(btnlogin);
            Controls.Add(role);
            Controls.Add(password);
            Controls.Add(Email);
            Name = "loginform";
            Text = "loginform";
            Load += loginform_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Email;
        private Label password;
        private Label role;
        private Button btnlogin;
        private TextBox txtemail;
        private TextBox txtpassword;
        private ComboBox comborole;
        private Label labellms;
    }
}