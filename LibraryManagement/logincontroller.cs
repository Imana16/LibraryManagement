using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace LibraryManagement
{
    public class LoginController
    {
        private Database db = new Database();


        public bool AuthenticateUser(string email, string password, string role, ref int currentMemberID)
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                conn.Open();

                // For Admin and Librarian: No need for MemberID
                if (role == "Admin" || role == "Librarian")
                {
                    string query = "SELECT * FROM login WHERE Email = @Email AND Password = @Password AND Role = @Role";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Role", role);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    return reader.HasRows; // Returns true if found
                }
                else if (role == "Member") // For Member, we need to check in the members table
                {
                    string query = "SELECT MemberID FROM members WHERE Email = @Email AND Password = @Password";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        currentMemberID = Convert.ToInt32(result); // Fetch MemberID
                        return true; // Successful authentication
                    }
                }

                return false; // Invalid credentials for all roles
            }
        }


        // Fetch the librarian name using email
       
    
    }
}







