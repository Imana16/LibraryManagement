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
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();
        }

        private void btnUploadImag_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp",
                Title = "Select a Book Image"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxBookImage.ImageLocation = openFileDialog.FileName; // Display the image in PictureBox
            }

        }

        private void btncancel_Click(object sender, EventArgs e)
        {

        }

        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void Publisher_Click(object sender, EventArgs e)
        {

        }

        private void textBoxpublisher_TextChanged(object sender, EventArgs e)
        {

        }

        private void CopiesAvailable_Click(object sender, EventArgs e)
        {

        }

        private void textBoxcopies_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxtitle.Text) ||
        string.IsNullOrWhiteSpace(textBoxauthor.Text) ||
        string.IsNullOrWhiteSpace(textBoxpublisher.Text) ||
        string.IsNullOrWhiteSpace(textBoxgenre.Text) ||
        string.IsNullOrWhiteSpace(textBoxcopies.Text) ||
        string.IsNullOrWhiteSpace(textBoxyear.Text))
            {
                MessageBox.Show("Please fill all the fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a new Book object
            BookModel newBook = new BookModel
            {
                Title = textBoxtitle.Text.Trim(),
                Author = textBoxauthor.Text.Trim(),
                Publisher = textBoxpublisher.Text.Trim(),
                Genre = textBoxgenre.Text.Trim(),
                CopiesAvailable = int.Parse(textBoxcopies.Text.Trim()),
                Year = int.Parse(textBoxyear.Text.Trim()),
                BookImage = pictureBoxBookImage.ImageLocation // Ensure you set the path when uploading an image
            };

            // Use BookController to add the book
            BookController bookController = new BookController();
            bool isAdded = bookController.AddBook(newBook);

            if (isAdded)
            {
                MessageBox.Show("Book added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Close the form after saving
            }
            else
            {
                MessageBox.Show("Failed to add the book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {

        }
    }
}
