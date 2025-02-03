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
using MySql.Data.MySqlClient;


namespace LibraryManagement
{
    public partial class ManageBorrowings : UserControl
    {
        public ManageBorrowings()
        {
            InitializeComponent();
        }
        private void LoadBorrowedBooks()
        {
            BorrowBookController controller = new BorrowBookController();
            List<BorrowedBook> borrowedBooks = controller.GetAllBorrowingBooks();
            dgvBorrowingHistory.DataSource = borrowedBooks;
        }
        private void ManageBorrowings_Load(object sender, EventArgs e)
        {
            LoadBorrowedBooks();
        }

        private void dgvBorrowingHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
