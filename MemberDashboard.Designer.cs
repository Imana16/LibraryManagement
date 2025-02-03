namespace LibraryManagement
{
    partial class MemberDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberDashboard));
            btnViewProfile = new Button();
            btnEditProfile = new Button();
            btnReserveBooks = new Button();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnBorrowReturnBooks = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            panelRight = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnViewProfile
            // 
            btnViewProfile.BackColor = SystemColors.GradientActiveCaption;
            btnViewProfile.ForeColor = SystemColors.ActiveCaptionText;
            btnViewProfile.Location = new Point(29, 124);
            btnViewProfile.Name = "btnViewProfile";
            btnViewProfile.Size = new Size(175, 45);
            btnViewProfile.TabIndex = 0;
            btnViewProfile.Text = "View Profile";
            btnViewProfile.UseVisualStyleBackColor = false;
            btnViewProfile.Click += btnViewProfile_Click;
            // 
            // btnEditProfile
            // 
            btnEditProfile.BackColor = SystemColors.GradientActiveCaption;
            btnEditProfile.Location = new Point(29, 175);
            btnEditProfile.Name = "btnEditProfile";
            btnEditProfile.Size = new Size(175, 48);
            btnEditProfile.TabIndex = 1;
            btnEditProfile.Text = "Edit Profile";
            btnEditProfile.UseVisualStyleBackColor = false;
            btnEditProfile.Click += btnEditProfile_Click;
            // 
            // btnReserveBooks
            // 
            btnReserveBooks.BackColor = SystemColors.GradientActiveCaption;
            btnReserveBooks.Location = new Point(29, 229);
            btnReserveBooks.Name = "btnReserveBooks";
            btnReserveBooks.Size = new Size(175, 41);
            btnReserveBooks.TabIndex = 2;
            btnReserveBooks.Text = "Reserve Books";
            btnReserveBooks.UseVisualStyleBackColor = false;
            btnReserveBooks.Click += btnReserveBooks_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.profile_icon_design_free_vector;
            pictureBox2.Location = new Point(12, 28);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(47, 57);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnBorrowReturnBooks);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btnReserveBooks);
            panel1.Controls.Add(btnEditProfile);
            panel1.Controls.Add(btnViewProfile);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(248, 717);
            panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.Center;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 507);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(248, 210);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 332);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(245, 181);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnBorrowReturnBooks
            // 
            btnBorrowReturnBooks.BackColor = SystemColors.GradientActiveCaption;
            btnBorrowReturnBooks.Location = new Point(29, 276);
            btnBorrowReturnBooks.Name = "btnBorrowReturnBooks";
            btnBorrowReturnBooks.Size = new Size(175, 42);
            btnBorrowReturnBooks.TabIndex = 7;
            btnBorrowReturnBooks.Text = "Borrow /Return Books";
            btnBorrowReturnBooks.UseVisualStyleBackColor = false;
            btnBorrowReturnBooks.Click += btnBorrowReturnBooks_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(245, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(0, 0);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(248, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 717);
            panel3.TabIndex = 1;
            panel3.Paint += panel3_Paint;
            // 
            // panelRight
            // 
            panelRight.Location = new Point(254, 0);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(917, 717);
            panelRight.TabIndex = 2;
            panelRight.Paint += panelRight_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(63, 43);
            label1.Name = "label1";
            label1.Size = new Size(179, 28);
            label1.TabIndex = 10;
            label1.Text = "Welcome Member\r\n";
            label1.Click += label1_Click;
            // 
            // MemberDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 717);
            Controls.Add(panelRight);
            Controls.Add(panel3);
            Controls.Add(panel1);
            MinimumSize = new Size(1, 0);
            Name = "MemberDashboard";
            Text = "MemberDashboard";
            Load += MemberDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnViewProfile;
        private Button btnEditProfile;
        private Button btnReserveBooks;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panelRight;
        private Button btnBorrowReturnBooks;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Label label1;
    }
}