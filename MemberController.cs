using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using LibraryManagement.Controllers;
namespace LibraryManagement
{
    public class MemberController
    { 
    
        private string connectionString = "server=localhost;database=librarydb;uid=root;pwd=;";

        public List<Member> GetAllMembers()
        {
            List<Member> members = new List<Member>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM members";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        members.Add(new Member
                        {
                            MemberID = reader.GetInt32("MemberID"),
                            Name = reader.GetString("Name"),
                            Email = reader.GetString("Email"),
                            Password = reader.GetString("Password"),
                            DateJoined = reader.GetDateTime("DateJoined")
                        });
                    }
                }
            }

            return members;
        }




        // Connection string should be defined, replace this with actual connection string
        

        public void AddMember(string name, string email, string password)
        {
            string query = "INSERT INTO members (Name, Email, Password) VALUES (@Name, @Email, @Password)";

            using (MySqlConnection conn = new MySqlConnection(connectionString))  // Use the correct connection string
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteMember(int memberId)
        {
            // Define the query to delete the member by MemberID
            string query = "DELETE FROM members WHERE MemberID = @MemberID";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MemberID", memberId);

                conn.Open();
                cmd.ExecuteNonQuery();  // Execute the delete query
            }
        }
        public List<Member> GetMembersBySearch(string column, string searchText)
        {
            List<Member> members = new List<Member>();

            string query = "SELECT * FROM members WHERE " + column + " LIKE @SearchText";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SearchText", "%" + searchText + "%"); // Use % for partial matches

                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Member member = new Member
                    {
                        MemberID = reader.GetInt32("MemberID"),
                        Name = reader.GetString("Name"),
                        Email = reader.GetString("Email"),
                        Password = reader.GetString("Password"),
                        DateJoined = reader.GetDateTime("DateJoined")
                    };
                    members.Add(member);
                }
            }

            return members;
        }

    }
}

