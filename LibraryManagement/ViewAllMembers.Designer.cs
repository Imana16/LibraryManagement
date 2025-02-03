namespace LibraryManagement
{
    partial class ViewAllMembers
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
            dgvViewAllMembers = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvViewAllMembers).BeginInit();
            SuspendLayout();
            // 
            // dgvViewAllMembers
            // 
            dgvViewAllMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvViewAllMembers.Location = new Point(0, 0);
            dgvViewAllMembers.Name = "dgvViewAllMembers";
            dgvViewAllMembers.RowHeadersWidth = 51;
            dgvViewAllMembers.Size = new Size(901, 651);
            dgvViewAllMembers.TabIndex = 0;
            // 
            // ViewAllMembers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvViewAllMembers);
            Name = "ViewAllMembers";
            Size = new Size(901, 651);
            Load += ViewAllMembers_Load;
            ((System.ComponentModel.ISupportInitialize)dgvViewAllMembers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvViewAllMembers;
    }
}
