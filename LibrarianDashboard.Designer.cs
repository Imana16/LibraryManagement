namespace LibraryManagement
{
    partial class LibrarianDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibrarianDashboard));
            fileSystemWatcher1 = new FileSystemWatcher();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            LibrarianName = new Label();
            pictureBox1 = new PictureBox();
            ManageBooks = new Button();
            ManageMembers = new Button();
            ManageReservations = new Button();
            ManageBorrowing = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            contentPanel = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.WhiteSmoke;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(ManageBooks);
            flowLayoutPanel1.Controls.Add(ManageMembers);
            flowLayoutPanel1.Controls.Add(ManageBorrowing);
            flowLayoutPanel1.Controls.Add(ManageReservations);
            flowLayoutPanel1.Controls.Add(pictureBox2);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.MaximumSize = new Size(200, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(200, 633);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint_1;
            // 
            // panel1
            // 
            panel1.Controls.Add(LibrarianName);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(3, 3);
            panel1.MaximumSize = new Size(500, 500);
            panel1.Name = "panel1";
            panel1.Size = new Size(199, 88);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // LibrarianName
            // 
            LibrarianName.AutoSize = true;
            LibrarianName.Location = new Point(62, 28);
            LibrarianName.MaximumSize = new Size(200, 200);
            LibrarianName.Name = "LibrarianName";
            LibrarianName.Size = new Size(0, 20);
            LibrarianName.TabIndex = 1;
            LibrarianName.TextAlign = ContentAlignment.MiddleLeft;
            LibrarianName.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(9, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // ManageBooks
            // 
            ManageBooks.BackColor = Color.LightBlue;
            ManageBooks.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ManageBooks.Location = new Point(10, 99);
            ManageBooks.Margin = new Padding(10, 5, 10, 5);
            ManageBooks.Name = "ManageBooks";
            ManageBooks.Size = new Size(180, 70);
            ManageBooks.TabIndex = 1;
            ManageBooks.Text = "Manage Books";
            ManageBooks.UseVisualStyleBackColor = false;
            ManageBooks.Click += ManageBooks_Click;
            // 
            // ManageMembers
            // 
            ManageMembers.BackColor = Color.LightBlue;
            ManageMembers.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ManageMembers.Location = new Point(10, 179);
            ManageMembers.Margin = new Padding(10, 5, 10, 5);
            ManageMembers.Name = "ManageMembers";
            ManageMembers.Size = new Size(182, 60);
            ManageMembers.TabIndex = 2;
            ManageMembers.Text = "Manage Members";
            ManageMembers.UseVisualStyleBackColor = false;
            ManageMembers.Click += ManageMembers_Click;
            // 
            // ManageReservations
            // 
            ManageReservations.BackColor = Color.LightBlue;
            ManageReservations.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ManageReservations.Location = new Point(10, 323);
            ManageReservations.Margin = new Padding(10, 5, 10, 5);
            ManageReservations.Name = "ManageReservations";
            ManageReservations.Size = new Size(179, 71);
            ManageReservations.TabIndex = 3;
            ManageReservations.Text = "Manage Reservations";
            ManageReservations.UseVisualStyleBackColor = false;
            ManageReservations.Click += ManageReservations_Click;
            // 
            // ManageBorrowing
            // 
            ManageBorrowing.BackColor = Color.LightBlue;
            ManageBorrowing.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ManageBorrowing.Location = new Point(10, 249);
            ManageBorrowing.Margin = new Padding(10, 5, 10, 5);
            ManageBorrowing.Name = "ManageBorrowing";
            ManageBorrowing.Size = new Size(182, 64);
            ManageBorrowing.TabIndex = 4;
            ManageBorrowing.Text = "Manage Borrowing";
            ManageBorrowing.UseVisualStyleBackColor = false;
            ManageBorrowing.Click += ManageBorrowing_Click;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(200, 0);
            panel2.MaximumSize = new Size(2, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(2, 633);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(contentPanel);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(202, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(965, 633);
            panel3.TabIndex = 2;
            // 
            // contentPanel
            // 
            contentPanel.BackColor = SystemColors.ControlLightLight;
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(0, 0);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(965, 633);
            contentPanel.TabIndex = 3;
            contentPanel.Paint += contentPanel_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(232, 137);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 2;
            label1.Click += label1_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(3, 402);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(197, 231);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // LibrarianDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 633);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(flowLayoutPanel1);
            Name = "LibrarianDashboard";
            Text = "LibrarianDashboard";
            Load += LibrarianDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private FileSystemWatcher fileSystemWatcher1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button ManageBooks;
        private Button ManageMembers;
        private Button ManageReservations;
        private Button ManageBorrowing;
        private Panel panel3;
        private Panel panel2;
        private Label label1;
        private Label LibrarianName;
        private Panel contentPanel;
        private PictureBox pictureBox2;
    }
}