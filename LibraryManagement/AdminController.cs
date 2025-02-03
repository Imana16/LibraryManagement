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
    public class AdminController
    {
        private Database db = new Database();

        // Method to get all members (you may use this in the View All Members functionality)
        public List<Member> GetAllMembers()
        {
            List<Member> members = new List<Member>();
            string query = "SELECT MemberID, Name, Email, Role,DateJoined FROM members";

            using (var conn = db.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        members.Add(new Member
                        {
                            MemberID = reader.GetInt32("MemberID"),
                            Name = reader.GetString("Name"),
                            Email = reader.GetString("Email"),
                            Role = reader.GetString("Role"),
                            DateJoined = reader.GetDateTime("DateJoined")
                        });
                    }
                }
            }

            return members;
        }

        public List<BookModel> GetAllBooks()
        {
            List<BookModel> books = new List<BookModel>();

            string query = "SELECT BookID, Title, Author, Publisher, CopiesAvailable,Year,Genre,BookImage FROM books"; // Adjust columns as needed

            using (var conn = db.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        books.Add(new BookModel
                        {
                            BookID = reader.GetInt32("BookID"),
                            Title = reader.GetString("Title"),
                            Author = reader.GetString("Author"),
                            Publisher = reader.GetString("Publisher"),
                            CopiesAvailable = reader.GetInt32("CopiesAvailable"),
                            Year = reader.GetInt32("Year"),
                            Genre = reader.GetString("Genre"),
                            BookImage = reader.GetString("BookImage")
                        });
                    }
                }
            }
            return books;
        }
    }
}