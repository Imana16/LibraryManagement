namespace LibraryManagement
{
    partial class ManageMembersControl
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
            dataGridViewMembers = new DataGridView();
            btneditmember = new Button();
            btnaddmember = new Button();
            btnDeleteMember = new Button();
            txtboxsearch = new TextBox();
            searchcomboBox = new ComboBox();
            btnsearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMembers).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewMembers
            // 
            dataGridViewMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMembers.Location = new Point(0, 157);
            dataGridViewMembers.Name = "dataGridViewMembers";
            dataGridViewMembers.RowHeadersWidth = 51;
            dataGridViewMembers.Size = new Size(677, 452);
            dataGridViewMembers.TabIndex = 0;
            dataGridViewMembers.CellContentClick += dataGridViewMembers_CellContentClick;
            // 
            // btneditmember
            // 
            btneditmember.Location = new Point(194, 115);
            btneditmember.Name = "btneditmember";
            btneditmember.Size = new Size(136, 29);
            btneditmember.TabIndex = 1;
            btneditmember.Text = "Edit Member";
            btneditmember.UseVisualStyleBackColor = true;
            btneditmember.Click += btneditmember_Click;
            // 
            // btnaddmember
            // 
            btnaddmember.Location = new Point(31, 115);
            btnaddmember.Name = "btnaddmember";
            btnaddmember.Size = new Size(125, 29);
            btnaddmember.TabIndex = 2;
            btnaddmember.Text = "Add Member\n";
            btnaddmember.UseVisualStyleBackColor = true;
            btnaddmember.Click += btnaddmember_Click;
            // 
            // btnDeleteMember
            // 
            btnDeleteMember.Location = new Point(359, 115);
            btnDeleteMember.Name = "btnDeleteMember";
            btnDeleteMember.Size = new Size(159, 29);
            btnDeleteMember.TabIndex = 3;
            btnDeleteMember.Text = "Delete Member";
            btnDeleteMember.UseVisualStyleBackColor = true;
            btnDeleteMember.Click += btnDeleteMember_Click;
            // 
            // txtboxsearch
            // 
            txtboxsearch.Location = new Point(136, 21);
            txtboxsearch.Name = "txtboxsearch";
            txtboxsearch.Size = new Size(169, 27);
            txtboxsearch.TabIndex = 4;
            // 
            // searchcomboBox
            // 
            searchcomboBox.FormattingEnabled = true;
            searchcomboBox.Location = new Point(326, 21);
            searchcomboBox.Name = "searchcomboBox";
            searchcomboBox.Size = new Size(162, 28);
            searchcomboBox.TabIndex = 5;
            // 
            // btnsearch
            // 
            btnsearch.Location = new Point(512, 21);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(94, 29);
            btnsearch.TabIndex = 6;
            btnsearch.Text = "Search";
            btnsearch.UseVisualStyleBackColor = true;
            btnsearch.Click += btnsearch_Click;
            // 
            // ManageMembersControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnsearch);
            Controls.Add(searchcomboBox);
            Controls.Add(txtboxsearch);
            Controls.Add(btnDeleteMember);
            Controls.Add(btnaddmember);
            Controls.Add(btneditmember);
            Controls.Add(dataGridViewMembers);
            Name = "ManageMembersControl";
            Size = new Size(677, 612);
            Load += ManageMembersControl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMembers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewMembers;
        private Button btneditmember;
        private Button btnaddmember;
        private Button btnDeleteMember;
        private TextBox txtboxsearch;
        private ComboBox searchcomboBox;
        private Button btnsearch;
    }
}
