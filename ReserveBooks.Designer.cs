namespace LibraryManagement
{
    partial class ReserveBooks
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
            btnReserveBook = new Button();
            cmbBooksAvailable = new ComboBox();
            SelectBooks = new Label();
            dgvReservations = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvReservations).BeginInit();
            SuspendLayout();
            // 
            // btnReserveBook
            // 
            btnReserveBook.Location = new Point(37, 119);
            btnReserveBook.Name = "btnReserveBook";
            btnReserveBook.Size = new Size(139, 29);
            btnReserveBook.TabIndex = 0;
            btnReserveBook.Text = "Reserve Books";
            btnReserveBook.UseVisualStyleBackColor = true;
            btnReserveBook.Click += btnReserve_Click;
            // 
            // cmbBooksAvailable
            // 
            cmbBooksAvailable.FormattingEnabled = true;
            cmbBooksAvailable.Location = new Point(154, 38);
            cmbBooksAvailable.Name = "cmbBooksAvailable";
            cmbBooksAvailable.Size = new Size(266, 28);
            cmbBooksAvailable.TabIndex = 1;
            cmbBooksAvailable.SelectedIndexChanged += cmbBooksAvailable_SelectedIndexChanged;
            // 
            // SelectBooks
            // 
            SelectBooks.AutoSize = true;
            SelectBooks.Location = new Point(24, 41);
            SelectBooks.Name = "SelectBooks";
            SelectBooks.Size = new Size(93, 20);
            SelectBooks.TabIndex = 2;
            SelectBooks.Text = "Select Books";
            // 
            // dgvReservations
            // 
            dgvReservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservations.Location = new Point(0, 188);
            dgvReservations.Name = "dgvReservations";
            dgvReservations.RowHeadersWidth = 51;
            dgvReservations.Size = new Size(763, 480);
            dgvReservations.TabIndex = 3;
            dgvReservations.CellContentClick += dgvReservations_CellContentClick;
            // 
            // ReserveBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvReservations);
            Controls.Add(SelectBooks);
            Controls.Add(cmbBooksAvailable);
            Controls.Add(btnReserveBook);
            Name = "ReserveBooks";
            Size = new Size(763, 671);
            Load += ReserveBooks_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReservations).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnReserveBook;
        private ComboBox cmbBooksAvailable;
        private Label SelectBooks;
        private DataGridView dgvReservations;
    }
}
