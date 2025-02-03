namespace LibraryManagement
{
    partial class ManageBooksControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowBooksPanel = new FlowLayoutPanel();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            btnaddbook = new Button();
            btneditbook = new Button();
            btndeletebook = new Button();
            booksearchcombo = new ComboBox();
            btnsearch = new Button();
            searchtextBox = new TextBox();
            SuspendLayout();
            // 
            // flowBooksPanel
            // 
            flowBooksPanel.AutoScroll = true;
            flowBooksPanel.BackColor = SystemColors.ControlLightLight;
            flowBooksPanel.BorderStyle = BorderStyle.FixedSingle;
            flowBooksPanel.Location = new Point(0, 84);
            flowBooksPanel.Name = "flowBooksPanel";
            flowBooksPanel.Size = new Size(661, 497);
            flowBooksPanel.TabIndex = 0;
            flowBooksPanel.Paint += flowBooksPanel_Paint;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // btnaddbook
            // 
            btnaddbook.Location = new Point(20, 49);
            btnaddbook.Name = "btnaddbook";
            btnaddbook.Size = new Size(98, 29);
            btnaddbook.TabIndex = 1;
            btnaddbook.Text = "Add Book";
            btnaddbook.UseVisualStyleBackColor = true;
            btnaddbook.Click += btnaddbook_Click;
            // 
            // btneditbook
            // 
            btneditbook.Location = new Point(140, 49);
            btneditbook.Name = "btneditbook";
            btneditbook.Size = new Size(98, 29);
            btneditbook.TabIndex = 2;
            btneditbook.Text = "Edit Books";
            btneditbook.UseVisualStyleBackColor = true;
            btneditbook.Click += btneditbook_Click;
            // 
            // btndeletebook
            // 
            btndeletebook.Location = new Point(266, 49);
            btndeletebook.Name = "btndeletebook";
            btndeletebook.Size = new Size(104, 29);
            btndeletebook.TabIndex = 3;
            btndeletebook.Text = "Delete Books";
            btndeletebook.UseVisualStyleBackColor = true;
            btndeletebook.Click += btndeletebook_Click;
            // 
            // booksearchcombo
            // 
            booksearchcombo.FormattingEnabled = true;
            booksearchcombo.Location = new Point(342, 10);
            booksearchcombo.Name = "booksearchcombo";
            booksearchcombo.Size = new Size(151, 28);
            booksearchcombo.TabIndex = 5;
            booksearchcombo.SelectedIndexChanged += booksearchcombo_SelectedIndexChanged;
            // 
            // btnsearch
            // 
            btnsearch.Location = new Point(512, 12);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(94, 29);
            btnsearch.TabIndex = 6;
            btnsearch.Text = "Search";
            btnsearch.UseVisualStyleBackColor = true;
            btnsearch.Click += btnsearch_Click;
            // 
            // searchtextBox
            // 
            searchtextBox.Location = new Point(140, 11);
            searchtextBox.Name = "searchtextBox";
            searchtextBox.Size = new Size(181, 27);
            searchtextBox.TabIndex = 7;
            // 
            // ManageBooksControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            Controls.Add(searchtextBox);
            Controls.Add(btnsearch);
            Controls.Add(booksearchcombo);
            Controls.Add(btndeletebook);
            Controls.Add(btneditbook);
            Controls.Add(btnaddbook);
            Controls.Add(flowBooksPanel);
            Name = "ManageBooksControl";
            Size = new Size(626, 581);
            Load += ManageBooksControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowBooksPanel;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Button btnaddbook;
        private Button btneditbook;
        private Button btndeletebook;
        private ComboBox booksearchcombo;
        private Button btnsearch;
        private TextBox searchtextBox;
    }
}
