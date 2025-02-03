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

namespace LibraryManagement
{
    public partial class ViewAllBooks : UserControl
    {
        public ViewAllBooks()
        {
            InitializeComponent();
        }

        
        private void LoadBooks()
        {
            AdminController adminController = new AdminController(); // Ensure you have this class
            List < BookModel> books = adminController.GetAllBooks(); // Fetch books

            // Bind the data to the DataGridView
            dgvViewAllBooks.DataSource = books;
        }
        private void ViewAllBooks_Load(object sender, EventArgs e)
        {
            LoadBooks();
        }
    }
}
