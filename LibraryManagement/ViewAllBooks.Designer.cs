namespace LibraryManagement
{
    partial class ViewAllBooks
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
            dgvViewAllBooks = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvViewAllBooks).BeginInit();
            SuspendLayout();
            // 
            // dgvViewAllBooks
            // 
            dgvViewAllBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvViewAllBooks.Location = new Point(0, 0);
            dgvViewAllBooks.Name = "dgvViewAllBooks";
            dgvViewAllBooks.RowHeadersWidth = 51;
            dgvViewAllBooks.Size = new Size(767, 580);
            dgvViewAllBooks.TabIndex = 0;
            // 
            // ViewAllBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvViewAllBooks);
            Name = "ViewAllBooks";
            Size = new Size(767, 583);
            Load += ViewAllBooks_Load;
            ((System.ComponentModel.ISupportInitialize)dgvViewAllBooks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvViewAllBooks;
    }
}
