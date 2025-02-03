namespace LibraryManagement
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            btnGenerateReports = new Button();
            btnViewAllBooks = new Button();
            btnViewAllMembers = new Button();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnGenerateReports);
            panel1.Controls.Add(btnViewAllBooks);
            panel1.Controls.Add(btnViewAllMembers);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(210, 652);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(200, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 652);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(20, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(49, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnGenerateReports
            // 
            btnGenerateReports.Location = new Point(12, 233);
            btnGenerateReports.Name = "btnGenerateReports";
            btnGenerateReports.Size = new Size(158, 29);
            btnGenerateReports.TabIndex = 2;
            btnGenerateReports.Text = "Generate Reports";
            btnGenerateReports.UseVisualStyleBackColor = true;
            btnGenerateReports.Click += btnGenerateReports_Click;
            // 
            // btnViewAllBooks
            // 
            btnViewAllBooks.Location = new Point(12, 174);
            btnViewAllBooks.Name = "btnViewAllBooks";
            btnViewAllBooks.Size = new Size(158, 29);
            btnViewAllBooks.TabIndex = 1;
            btnViewAllBooks.Text = "View All Books";
            btnViewAllBooks.UseVisualStyleBackColor = true;
            btnViewAllBooks.Click += btnViewAllBooks_Click;
            // 
            // btnViewAllMembers
            // 
            btnViewAllMembers.Location = new Point(12, 116);
            btnViewAllMembers.Name = "btnViewAllMembers";
            btnViewAllMembers.Size = new Size(158, 29);
            btnViewAllMembers.TabIndex = 0;
            btnViewAllMembers.Text = "View All Members";
            btnViewAllMembers.UseVisualStyleBackColor = true;
            btnViewAllMembers.Click += btnViewAllMembers_Click;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(210, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(854, 652);
            panel3.TabIndex = 1;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 652);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnViewAllMembers;
        private Button btnGenerateReports;
        private Button btnViewAllBooks;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel3;
    }
}