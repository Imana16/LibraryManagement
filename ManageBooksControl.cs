using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagement.Controllers;
using LibraryManagement.Modelclass;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace LibraryManagement
{
    public partial class ManageBooksControl : UserControl
    {
        private object booksearchCombo;

        public ManageBooksControl()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }
        private void LoadBooks()
        {
            BookController bookController = new BookController();
            List<BookModel> books = bookController.GetAllBooks();

            flowBooksPanel.Controls.Clear(); // Clear existing books

            foreach (BookModel book in books)
            {
                Panel bookPanel = new Panel
                {
                    Width = 150,
                    Height = 200,
                    Margin = new Padding(10),
                    BorderStyle = BorderStyle.FixedSingle
                };

                PictureBox bookImage = new PictureBox
                {
                    Width = 140,
                    Height = 120,
                    ImageLocation = book.BookImage, // Ensure the path is correct
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Dock = DockStyle.Top
                };

                Label title = new Label
                {
                    Text = book.Title,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    Dock = DockStyle.Top,
                    TextAlign = ContentAlignment.MiddleCenter
                };

                Label author = new Label
                {
                    Text = $"By {book.Author}",
                    Font = new Font("Segoe UI", 8),
                    Dock = DockStyle.Top,
                    TextAlign = ContentAlignment.MiddleCenter
                };

                bookPanel.Click += BookPanel_Click;

                bookPanel.Controls.Add(bookImage);
                bookPanel.Controls.Add(title);
                bookPanel.Controls.Add(author);
                bookPanel.Tag = book;
                bookPanel.Click += (s, e) => SelectBook(bookPanel);
                flowBooksPanel.Controls.Add(bookPanel);
            }
        }
        private void DisplayBooks(List<BookModel> books)
        {
            flowBooksPanel.Controls.Clear(); // Clear existing books

            foreach (BookModel book in books)
            {
                Panel bookPanel = new Panel
                {
                    Width = 150,
                    Height = 200,
                    Margin = new Padding(10),
                    BorderStyle = BorderStyle.FixedSingle
                };

                PictureBox bookImage = new PictureBox
                {
                    Width = 140,
                    Height = 120,
                    ImageLocation = book.BookImage, // Path to the image
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Dock = DockStyle.Top
                };

                Label title = new Label
                {
                    Text = book.Title,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    Dock = DockStyle.Top,
                    TextAlign = ContentAlignment.MiddleCenter
                };

                Label author = new Label
                {
                    Text = $"By {book.Author}",
                    Font = new Font("Segoe UI", 8),
                    Dock = DockStyle.Top,
                    TextAlign = ContentAlignment.MiddleCenter
                };
                bookPanel.Click += BookPanel_Click;

                bookPanel.Controls.Add(bookImage);
                bookPanel.Controls.Add(title);
                bookPanel.Controls.Add(author);
                bookPanel.Tag = book;
                bookPanel.Click += (s, e) => SelectBook(bookPanel);
                flowBooksPanel.Controls.Add(bookPanel);
            }
        }


        private void ManageBooksControl_Load(object sender, EventArgs e)
        {
            LoadBooks();

            // Populate the search combo box
            booksearchcombo.Items.Add("Title");
            booksearchcombo.Items.Add("Author");
            booksearchcombo.Items.Add("Publisher");
            booksearchcombo.Items.Add("Genre");
            booksearchcombo.SelectedIndex = 0; // Default selection

            // Load and display all books initially
            BookController bookController = new BookController();
            List<BookModel> allBooks = bookController.GetAllBooks();
            DisplayBooks(allBooks);

        }

        private void SelectBook(Panel selectedPanel)
        {
            foreach (Control control in flowBooksPanel.Controls)
            {
                if (control is Panel panel)
                {
                    panel.BorderStyle = BorderStyle.FixedSingle; // Deselect
                }
            }
            selectedPanel.BorderStyle = BorderStyle.Fixed3D; // Highlight selected
        }
        private void BookPanel_Click(object sender, EventArgs e)
        {
            // Deselect all other panels
            foreach (Control control in flowBooksPanel.Controls)
            {
                if (control is Panel panel)
                {
                    panel.BorderStyle = BorderStyle.FixedSingle; // Reset style
                }
            }

            // Highlight the selected panel
            Panel selectedPanel = sender as Panel;
            if (selectedPanel != null)
            {
                selectedPanel.BorderStyle = BorderStyle.Fixed3D; // Highlight style
            }
        }
        private BookModel GetSelectedBook()
        {
            foreach (Control control in flowBooksPanel.Controls)
            {
                if (control is Panel bookPanel && bookPanel.BorderStyle == BorderStyle.Fixed3D)
                {
                    return bookPanel.Tag as BookModel; // Retrieve the book from the panel's Tag
                }
            }
            return null; // No book selected
        }









        private void flowBooksPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnaddbook_Click(object sender, EventArgs e)
        {
            AddBookForm addBookForm = new AddBookForm();
            addBookForm.FormClosed += (s, args) => LoadBooks(); // Refresh the books after closing the form
            addBookForm.ShowDialog();

        }

        private void btneditbook_Click(object sender, EventArgs e)
        {
            BookModel selectedBook = GetSelectedBook();

            if (selectedBook == null)
            {
                MessageBox.Show("Please select a book to edit.", "No Book Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Open the EditBook form
            EditBook editBook = new EditBook(selectedBook);
            if (editBook.ShowDialog() == DialogResult.OK)
            {
                // Refresh the books list after editing
                LoadBooks();
            }
        }

        private void btndeletebook_Click(object sender, EventArgs e)
        {
            // Get the selected book from the flow panel
            BookModel selectedBook = GetSelectedBook();

            if (selectedBook == null)
            {
                MessageBox.Show("Please select a book to delete.", "No Book Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ask for confirmation before deletion
            var result = MessageBox.Show("Are you sure you want to delete this book?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Call the controller to delete the book
                BookController bookController = new BookController();
                bookController.DeleteBook(selectedBook.BookID);

                // Refresh the list after deletion
                LoadBooks();

                MessageBox.Show("Book deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            



        }

        private void booksearchcombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string filter = booksearchcombo.SelectedItem.ToString().Trim();
            // Get selected filter (e.g., Title)
            string searchText = searchtextBox.Text.Trim(); // Get user input

            // Call the controller to fetch the filtered books
            BookController bookController = new BookController();
            List<BookModel> filteredBooks = bookController.SearchBooks(filter, searchText);

            // Update the flow panel with the filtered books
            DisplayBooks(filteredBooks);





        }
    }
    
}
