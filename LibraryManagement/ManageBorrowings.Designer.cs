namespace LibraryManagement
{
    partial class ManageBorrowings
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
            dgvBorrowingHistory = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowingHistory).BeginInit();
            SuspendLayout();
            // 
            // dgvBorrowingHistory
            // 
            dgvBorrowingHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrowingHistory.Location = new Point(0, 89);
            dgvBorrowingHistory.Name = "dgvBorrowingHistory";
            dgvBorrowingHistory.RowHeadersWidth = 51;
            dgvBorrowingHistory.Size = new Size(857, 534);
            dgvBorrowingHistory.TabIndex = 0;
            dgvBorrowingHistory.CellContentClick += dgvBorrowingHistory_CellContentClick;
            // 
            // ManageBorrowings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvBorrowingHistory);
            Name = "ManageBorrowings";
            Size = new Size(857, 626);
            Load += ManageBorrowings_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBorrowingHistory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvBorrowingHistory;
    }
}
