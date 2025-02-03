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

namespace LibraryManagement
{
    public partial class EditBook : Form

    {
        private BookModel book;

        private BookModel bookToEdit;

        public EditBook(BookModel selectedBook)
        {
            InitializeComponent();
            bookToEdit = selectedBook;

            // Populate fields with book details
            txtTitle.Text = bookToEdit.Title;
            txtAuthor.Text = bookToEdit.Author;
            txtPublisher.Text = bookToEdit.Publisher;
            txtYear.Text = bookToEdit.Year.ToString();
            txtGenre.Text = bookToEdit.Genre;
            txtCopies.Text = bookToEdit.CopiesAvailable.ToString();
            BookImage.ImageLocation = bookToEdit.BookImage;
            textImagepath.Text = bookToEdit.BookImage; // Set initial image path
        }


        private void EditBook_Load(object sender, EventArgs e)
        {

        }

        private void CopiesAvailable_Click(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            // Update book properties
            bookToEdit.Title = txtTitle.Text;
            bookToEdit.Author = txtAuthor.Text;
            bookToEdit.Publisher = txtPublisher.Text;
            bookToEdit.Year = int.Parse(txtYear.Text);
            bookToEdit.Genre = txtGenre.Text;
            bookToEdit.CopiesAvailable = int.Parse(txtCopies.Text);
            bookToEdit.BookImage = textImagepath.Text.Trim(); // Save image path

            // Call controller to save changes
            BookController bookController = new BookController();
            bookController.UpdateBook(bookToEdit); // Use bookToEdit to update the database
            MessageBox.Show("Book updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK; // Close the form

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnUploadImag_Click(object sender, EventArgs e)
        {
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                    openFileDialog.Title = "Select a Book Image";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Display the selected image in the PictureBox
                        BookImage.ImageLocation = openFileDialog.FileName;
                        BookImage.Load();

                        // Save the image path in the TextBox
                        textImagepath.Text = openFileDialog.FileName;
                    }
                }
            }
        }
        private void BookImage_Click(object sender, EventArgs e)
        {

        }
    }
}
