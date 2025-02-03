namespace LibraryManagement
{
    partial class BorrowBooksUserControl
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
            btnBorrowBook = new Button();
            dgvBorrowedBooks = new DataGridView();
            cmbBooksAvailable = new ComboBox();
            selectingBooks = new Label();
            btnReturn = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowedBooks).BeginInit();
            SuspendLayout();
            // 
            // btnBorrowBook
            // 
            btnBorrowBook.Location = new Point(13, 116);
            btnBorrowBook.Name = "btnBorrowBook";
            btnBorrowBook.Size = new Size(154, 29);
            btnBorrowBook.TabIndex = 2;
            btnBorrowBook.Text = "Borrow Books";
            btnBorrowBook.UseVisualStyleBackColor = true;
            btnBorrowBook.Click += btnBorrowBook_Click;
            // 
            // dgvBorrowedBooks
            // 
            dgvBorrowedBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrowedBooks.Location = new Point(3, 183);
            dgvBorrowedBooks.Name = "dgvBorrowedBooks";
            dgvBorrowedBooks.RowHeadersWidth = 51;
            dgvBorrowedBooks.Size = new Size(976, 525);
            dgvBorrowedBooks.TabIndex = 3;
            dgvBorrowedBooks.CellContentClick += dgvBorrowedBooks_CellContentClick;
            // 
            // cmbBooksAvailable
            // 
            cmbBooksAvailable.FormattingEnabled = true;
            cmbBooksAvailable.Location = new Point(147, 35);
            cmbBooksAvailable.Name = "cmbBooksAvailable";
            cmbBooksAvailable.Size = new Size(151, 28);
            cmbBooksAvailable.TabIndex = 4;
            // 
            // selectingBooks
            // 
            selectingBooks.AutoSize = true;
            selectingBooks.Location = new Point(13, 38);
            selectingBooks.Name = "selectingBooks";
            selectingBooks.Size = new Size(114, 20);
            selectingBooks.TabIndex = 5;
            selectingBooks.Text = "Selecting Books";
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(214, 116);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(146, 29);
            btnReturn.TabIndex = 6;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // BorrowBooksUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnReturn);
            Controls.Add(selectingBooks);
            Controls.Add(cmbBooksAvailable);
            Controls.Add(dgvBorrowedBooks);
            Controls.Add(btnBorrowBook);
            Name = "BorrowBooksUserControl";
            Size = new Size(831, 711);
            Load += BorrowBooksUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBorrowedBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button btnBorrowBook;
        private Button button1;
        private DataGridView dgvBorrowedBooks;
        private ComboBox cmbBooksAvailable;
        private Label selectingBooks;
        private Button btnReturn;
    }
}
