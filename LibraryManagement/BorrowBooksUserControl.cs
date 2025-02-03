using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagement.Modelclass;
using LibraryManagement.Controllers;

namespace LibraryManagement
{
    public partial class BorrowBooksUserControl : UserControl
    {
        private int currentMemberID;
        private BorrowBookController borrowController = new BorrowBookController();
        public BorrowBooksUserControl()
        {
            InitializeComponent();

        }
        public BorrowBooksUserControl(int memberID)
        {
            InitializeComponent();
            currentMemberID = memberID;
            LoadBorrowedBooks();// Store the correct logged-in memberID
        }
        
        private void LoadAvailableBooks()
        {
            var availableBooks = BorrowBookController.GetAvailableBooks();
            cmbBooksAvailable.DataSource = availableBooks;
            cmbBooksAvailable.DisplayMember = "Title"; // Display book title
            cmbBooksAvailable.ValueMember = "BookID";  // Store book ID as value
        }
       


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblNoBooksAvailable_Click(object sender, EventArgs e)
        {

        }

        private void BorrowBooksUserControl_Load(object sender, EventArgs e)
        {
            var availableBooks = BorrowBookController.GetAvailableBooks();
            cmbBooksAvailable.DataSource = availableBooks;
            cmbBooksAvailable.DisplayMember = "Title";
            cmbBooksAvailable.ValueMember = "BookID";

            // Load borrowed books
            UpdateBorrowedBooksGrid(); // Use BookID as value for selection
        }
        private void LoadBorrowedBooks()
        {
            var borrowBookController = new BorrowBookController(); // Instantiate the controller
            var borrowedBooks = borrowBookController.GetMemberBorrowingHistory(currentMemberID);
            dgvBorrowedBooks.DataSource = borrowedBooks; // Set data source for DataGridView// Set data source for DataGridView
        }


        private void btnBorrowBook_Click(object sender, EventArgs e)
        {
            int bookID = (int)cmbBooksAvailable.SelectedValue;

            if (borrowController.BorrowBook(currentMemberID, bookID))
            {
                MessageBox.Show("Book borrowed successfully!");
                UpdateBorrowedBooksGrid();
            }
            else
            {
                MessageBox.Show("Book borrowing failed. It may not be available.");
            }

        }
    

    

        private void UpdateBorrowedBooksGrid()
        {
            var borrowedBooks = borrowController.GetMemberBorrowingHistory(currentMemberID);
            dgvBorrowedBooks.DataSource = borrowedBooks;

        }

        private void dgvBorrowedBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            // Ensure a book is selected to return
            if (dgvBorrowedBooks.SelectedRows.Count > 0)
            {
                int borrowedBookID = Convert.ToInt32(dgvBorrowedBooks.SelectedRows[0].Cells[0].Value);

                if (borrowController.ReturnBook(borrowedBookID))
                {
                    MessageBox.Show("Book returned successfully!");
                    UpdateBorrowedBooksGrid();
                }
                else
                {
                    MessageBox.Show("Error in returning the book.");
                }
            }
            else
            {
                MessageBox.Show("Please select a book to return.");
            }

        }
    }
}