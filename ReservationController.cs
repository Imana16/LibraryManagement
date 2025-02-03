using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagement.Modelclass;
using MySql.Data.MySqlClient;

namespace LibraryManagement
{
    public class ReservationController
    {
        private Database db = new Database();

        // Add a reservation
        
        
            public bool AddReservation(int memberID, int bookID)
            {
                string checkAvailabilityQuery = "SELECT CopiesAvailable FROM books WHERE BookID = @BookID";
                int availableCopies = 0;

                using (var conn = db.GetConnection())
                {
                    conn.Open();
                    MySqlCommand checkCmd = new MySqlCommand(checkAvailabilityQuery, conn);
                    checkCmd.Parameters.AddWithValue("@BookID", bookID);
                    availableCopies = Convert.ToInt32(checkCmd.ExecuteScalar());
                }

                if (availableCopies == 0)
                {
                    // If no copies are available, proceed with reservation and show success
                    string query = "INSERT INTO reservations (MemberID, BookID, ReservationDate, Status) " +
                                   "VALUES (@MemberID, @BookID, @ReservationDate, 'Pending')";
                    using (var conn = db.GetConnection())
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@MemberID", memberID);
                        cmd.Parameters.AddWithValue("@BookID", bookID);
                        cmd.Parameters.AddWithValue("@ReservationDate", DateTime.Now);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        // If reservation is successful, update the book availability
                        if (rowsAffected > 0)
                        {
                            string updateBookQuery = "UPDATE books SET CopiesAvailable = CopiesAvailable - 1 WHERE BookID = @BookID";
                            MySqlCommand updateCmd = new MySqlCommand(updateBookQuery, conn);
                            updateCmd.Parameters.AddWithValue("@BookID", bookID);
                            updateCmd.ExecuteNonQuery();
                        }

                        return rowsAffected > 0;
                    }
                }
                else
                {
                    // If copies are available, show message saying book can't be reserved
                    MessageBox.Show("Copies are available, book can't be reserved.");
                    return false;
                }
            }
        

    


    // Get all reservations for a member
    public List<ReservationModel> GetReservationsByMember(int memberID)
        {
            List<ReservationModel> reservations = new List<ReservationModel>();
            string query = "SELECT * FROM reservations WHERE MemberID = @MemberID";

            using (var conn = db.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MemberID", memberID);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        reservations.Add(new ReservationModel
                        {
                            ReservationID = reader.GetInt32("ReservationID"),
                            MemberID = reader.GetInt32("MemberID"),
                            BookID = reader.GetInt32("BookID"),
                            ReservationDate = reader.GetDateTime("ReservationDate"),
                            Status = reader.GetString("Status")
                        });
                    }
                }
            }

            return reservations;
        }

        // Update reservation status (Reserved or Cancelled)
        public bool UpdateReservationStatus(int reservationID, string status)
        {
            // Ensure the status is either 'Reserved' or 'Cancelled'
            if (status != "Reserved" && status != "Cancelled")
            {
                return false; // Invalid status
            }

            string query = "UPDATE reservations SET Status = @Status WHERE ReservationID = @ReservationID";

            using (var conn = db.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@ReservationID", reservationID);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        // Get available books for reservation (Books with copies > 0)
        public List<BookModel> GetAvailableBooks()
        {
            List<BookModel> availableBooks = new List<BookModel>();
            string query = "SELECT BookID, Title FROM books WHERE CopiesAvailable = 0"; // Get only books with available copies

            using (var conn = db.GetConnection())
            {
                conn.Open();
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

            return availableBooks; // Return list of books available for reservation
        }


        public List<ReservationModel> GetAllReservations()
        {
            List<ReservationModel> reservations = new List<ReservationModel>();

            string query = "SELECT * FROM reservations";

            using (MySqlConnection conn = db.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    reservations.Add(new ReservationModel
                    {
                        ReservationID = reader.GetInt32("ReservationID"),
                        MemberID = reader.GetInt32("MemberID"),
                        BookID = reader.GetInt32("BookID"),
                        ReservationDate = reader.GetDateTime("ReservationDate"),
                        Status = reader.GetString("Status")
                    });
                }
            }

            return reservations;
        }

        // Cancel the reservation
        public bool CancelReservation(int reservationID)
        {
            string query = "UPDATE reservations SET Status = 'Canceled' WHERE ReservationID = @ReservationID";

            using (MySqlConnection conn = db.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ReservationID", reservationID);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        // Fulfill the reservation
        public bool FulfillReservation(int reservationID)
        {
            string query = "UPDATE reservations SET Status = 'Fulfilled' WHERE ReservationID = @ReservationID";

            using (MySqlConnection conn = db.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ReservationID", reservationID);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }
}


