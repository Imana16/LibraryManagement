using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using LibraryManagement.Modelclass;
using LibraryManagement;

namespace LibraryManagement.Controllers  
{



    public class BookController
    {
        private string connectionString = "server=localhost;database=librarydb;uid=root;pwd=;";

        // Method to get all books
        public List<BookModel> GetAllBooks()
        {
            List<BookModel> books = new List<BookModel>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM books";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        books.Add(new BookModel  
                        {
                            BookID = !reader.IsDBNull(reader.GetOrdinal("BookID")) ? reader.GetInt32("BookID") : 0,
                            Title = !reader.IsDBNull(reader.GetOrdinal("Title")) ? reader.GetString("Title") : "Unknown Title",
                            Author = !reader.IsDBNull(reader.GetOrdinal("Author")) ? reader.GetString("Author") : "Unknown Author",
                            Publisher = !reader.IsDBNull(reader.GetOrdinal("Publisher")) ? reader.GetString("Publisher") : "Unknown Publisher",
                            Year = !reader.IsDBNull(reader.GetOrdinal("Year")) ? reader.GetInt32("Year") : 0,
                            Genre = !reader.IsDBNull(reader.GetOrdinal("Genre")) ? reader.GetString("Genre") : "Unknown Genre",
                            CopiesAvailable = !reader.IsDBNull(reader.GetOrdinal("CopiesAvailable")) ? reader.GetInt32("CopiesAvailable") : 0,
                            BookImage = !reader.IsDBNull(reader.GetOrdinal("BookImage")) ? reader.GetString("BookImage") : null
                        });
                    }
                }
            }

            return books;
        }
        public List<BookModel> SearchBooks(string filter, string searchText)
        {
            List<BookModel> books = new List<BookModel>();

            // Whitelist for valid column names
            string[] validFilters = { "Title", "Author", "Publisher", "Genre" };
            if (!validFilters.Contains(filter))
            {
                throw new ArgumentException("Invalid filter value.");
            }

            string query = $"SELECT * FROM books WHERE {filter} LIKE @searchText";

            using (MySqlConnection conn = new Database().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@searchText", $"%{searchText}%");

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            books.Add(new BookModel
                            {
                                BookID = reader.GetInt32("BookID"),
                                Title = reader.GetString("Title"),
                                Author = reader.GetString("Author"),
                                Publisher = reader.GetString("Publisher"),
                                Year = reader.GetInt32("Year"),
                                Genre = reader.GetString("Genre"),
                                CopiesAvailable = reader.GetInt32("CopiesAvailable"),
                                BookImage = reader.GetString("BookImage")
                            });
                        }
                    }
                }
            }

            return books;
        }
        public bool AddBook(BookModel newBook)
        {
            try
            {
                using (MySqlConnection conn = new Database().GetConnection())
                {
                    string query = "INSERT INTO books (Title, Author, Publisher, Year, Genre, CopiesAvailable, BookImage) " +
                                   "VALUES (@Title, @Author, @Publisher, @Year, @Genre, @CopiesAvailable, @BookImage)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@Title", newBook.Title);
                    cmd.Parameters.AddWithValue("@Author", newBook.Author);
                    cmd.Parameters.AddWithValue("@Publisher", newBook.Publisher);
                    cmd.Parameters.AddWithValue("@Year", newBook.Year);
                    cmd.Parameters.AddWithValue("@Genre", newBook.Genre);
                    cmd.Parameters.AddWithValue("@CopiesAvailable", newBook.CopiesAvailable);
                    cmd.Parameters.AddWithValue("@BookImage", newBook.BookImage);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0; // Return true if a row was inserted
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding book: {ex.Message}");
                return false;
            }
        }

        public void UpdateBook(BookModel book)
        {
            using (MySqlConnection conn = new Database().GetConnection())
            {
                conn.Open();
                string query = "UPDATE books SET Title = @Title, Author = @Author, Publisher = @Publisher, " +
                               "Year = @Year, Genre = @Genre, CopiesAvailable = @CopiesAvailable, BookImage = @BookImage " +
                               "WHERE BookID = @BookID";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Title", book.Title);
                    cmd.Parameters.AddWithValue("@Author", book.Author);
                    cmd.Parameters.AddWithValue("@Publisher", book.Publisher);
                    cmd.Parameters.AddWithValue("@Year", book.Year);
                    cmd.Parameters.AddWithValue("@Genre", book.Genre);
                    cmd.Parameters.AddWithValue("@CopiesAvailable", book.CopiesAvailable);
                    cmd.Parameters.AddWithValue("@BookImage", book.BookImage); // Save image path
                    cmd.Parameters.AddWithValue("@BookID", book.BookID);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteBook(int bookID)
        {
            using (MySqlConnection conn = new Database().GetConnection())
            {
                string query = "DELETE FROM books WHERE BookID = @BookID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@BookID", bookID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        




    }

}


 

    


