using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagement.Modelclass;
using MySql.Data.MySqlClient;



namespace LibraryManagement
{
    public class BorrowBookController
    {
        private Database db = new Database(); // Database helper
        private string connectionString = "server=localhost;database=librarydb;uid=root;pwd=;";

        // Borrow a Book (after checking availability)
        public bool BorrowBook(int memberID, int bookID)
        {
            using (var conn = db.GetConnection())  // Establish database connection
            {
                conn.Open();

                // Check if the member exists in the members table
                string checkMemberQuery = "SELECT COUNT(*) FROM members WHERE MemberID = @MemberID";
                MySqlCommand checkMemberCmd = new MySqlCommand(checkMemberQuery, conn);
                checkMemberCmd.Parameters.AddWithValue("@MemberID", memberID);
                int memberCount = Convert.ToInt32(checkMemberCmd.ExecuteScalar());

                if (memberCount == 0)
                {
                    // MemberID does not exist in members table
                    MessageBox.Show("Member not found.");
                    return false;
                }

                // Check if the book is available
                string checkQuery = "SELECT CopiesAvailable FROM books WHERE BookID = @BookID";
                MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@BookID", bookID);
                object result = checkCmd.ExecuteScalar();

                if (result != null && Convert.ToInt32(result) > 0)  // Book is available
                {
                    // Set the due date (e.g., 7 days from now)
                    DateTime dueDate = DateTime.Now.AddDays(7);

                    // Insert the borrowing record into borrowedbooks table
                    string borrowQuery = "INSERT INTO borrowedbooks (MemberID, BookID, BorrowDate, DueDate, Fine, PaymentStatus) " +
                                         "VALUES (@MemberID, @BookID, @BorrowDate, @DueDate, @Fine, @PaymentStatus)";
                    MySqlCommand borrowCmd = new MySqlCommand(borrowQuery, conn);
                    borrowCmd.Parameters.AddWithValue("@MemberID", memberID);
                    borrowCmd.Parameters.AddWithValue("@BookID", bookID);
                    borrowCmd.Parameters.AddWithValue("@BorrowDate", DateTime.Now);
                    borrowCmd.Parameters.AddWithValue("@DueDate", dueDate);
                    borrowCmd.Parameters.AddWithValue("@Fine", 0); // Set initial fine to 0
                    borrowCmd.Parameters.AddWithValue("@PaymentStatus", "Unpaid"); // Set payment status to unpaid

                    borrowCmd.ExecuteNonQuery();

                    // Update the available copies of the book
                    string updateQuery = "UPDATE books SET CopiesAvailable = CopiesAvailable - 1 WHERE BookID = @BookID";
                    MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@BookID", bookID);
                    updateCmd.ExecuteNonQuery();

                    return true; // Successfully borrowed
                }
                else
                {
                    return false; // Book is not available
                }
            }
        }
        public bool ReturnBook(int borrowedBookID)
        {
            int bookID = 0;
            DateTime dueDate = DateTime.MinValue;
            DateTime returnDate = DateTime.Now;
            decimal fine = 0;

            // Step 1: Get BookID and DueDate for the borrowed book
            using (var conn = db.GetConnection())
            {
                conn.Open();
                string getQuery = "SELECT BookID, DueDate FROM borrowedbooks WHERE BorrowedBookID = @BorrowedBookID";
                using (MySqlCommand getCmd = new MySqlCommand(getQuery, conn))
                {
                    getCmd.Parameters.AddWithValue("@BorrowedBookID", borrowedBookID);

                    using (MySqlDataReader reader = getCmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            bookID = reader.GetInt32("BookID");
                            dueDate = reader.GetDateTime("DueDate");
                        }
                        else
                        {
                            return false; // Record not found
                        }
                    } // DataReader is now closed
                }
            } // Connection is closed

            // Step 2: Calculate fine if returned after the due date
            if (returnDate > dueDate)
            {
                TimeSpan overdueDays = returnDate - dueDate;
                fine = overdueDays.Days * 50; // 50 rupees per day fine
            }

            // Step 3: Update borrowedbooks and books tables
            using (var conn = db.GetConnection())
            {
                conn.Open();

                // Update borrowedbooks table
                string returnQuery = "UPDATE borrowedbooks SET ReturnDate = @ReturnDate, Fine = @Fine, PaymentStatus = 'Unpaid' WHERE BorrowedBookID = @BorrowedBookID";
                using (MySqlCommand returnCmd = new MySqlCommand(returnQuery, conn))
                {
                    returnCmd.Parameters.AddWithValue("@ReturnDate", returnDate);
                    returnCmd.Parameters.AddWithValue("@Fine", fine);
                    returnCmd.Parameters.AddWithValue("@BorrowedBookID", borrowedBookID);
                    returnCmd.ExecuteNonQuery();
                }

                // Update books table
                string updateQuery = "UPDATE books SET CopiesAvailable = CopiesAvailable + 1 WHERE BookID = @BookID";
                using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn))
                {
                    updateCmd.Parameters.AddWithValue("@BookID", bookID);
                    updateCmd.ExecuteNonQuery();
                }
            }

            return true; // Successfully returned
        }

    







    // Get the borrowing history of a member
    public List<BorrowedBook> GetMemberBorrowingHistory(int memberID)
        {
            List<BorrowedBook> borrowedBooks = new List<BorrowedBook>();

            using (var conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM borrowedbooks WHERE MemberID = @MemberID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MemberID", memberID);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        borrowedBooks.Add(new BorrowedBook
                        {
                            BorrowedBookID = reader.GetInt32("BorrowedBookID"),
                            MemberID = reader.GetInt32("MemberID"),
                            BookID = reader.GetInt32("BookID"),
                            BorrowDate = reader.GetDateTime("BorrowDate"),
                            DueDate = reader.GetDateTime("DueDate"),
                            ReturnDate = reader.IsDBNull(reader.GetOrdinal("ReturnDate")) ? (DateTime?)null : reader.GetDateTime("ReturnDate"),
                            Fine = reader.GetDecimal("Fine"),
                            PaymentStatus = reader.GetString("PaymentStatus")
                        });
                    }
                }
            }
            return borrowedBooks;
        }
        // Method to get available books
        public static List<BookModel> GetAvailableBooks()
        {
            List<BookModel> availableBooks = new List<BookModel>();

            // Define the connection string
            string connectionString = "server=localhost;database=librarydb;uid=root;pwd=;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT BookID, Title FROM books WHERE CopiesAvailable > 0"; // Query for available books
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        availableBooks.Add(new BookModel
                        {
                            BookID = reader.GetInt32("BookID"),
                            Title = reader.GetString("Title")
                        });
                    }
                }
            }

            return availableBooks; // Return the list of available books
        }
        public List<BorrowedBook> GetAllBorrowingBooks()
        {
            List<BorrowedBook> borrowedBooks = new List<BorrowedBook>();

            string query = "SELECT BorrowedBookID, BookID, MemberID, BorrowDate, DueDate, ReturnDate, Fine, PaymentStatus FROM borrowedbooks";

            using (var conn = db.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        borrowedBooks.Add(new BorrowedBook
                        {
                            BorrowedBookID = reader.GetInt32("BorrowedBookID"),
                            BookID = reader.GetInt32("BookID"),
                            MemberID = reader.GetInt32("MemberID"),
                            BorrowDate = reader.GetDateTime("BorrowDate"),
                            DueDate = reader.GetDateTime("DueDate"),
                            ReturnDate = reader.IsDBNull(reader.GetOrdinal("ReturnDate")) ? (DateTime?)null : reader.GetDateTime("ReturnDate"),
                            Fine = reader.GetDecimal("Fine"),
                            PaymentStatus = reader.GetString("PaymentStatus")
                        });
                    }
                }
            }

            return borrowedBooks;
        }



    }


}






