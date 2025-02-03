using System.Data;
using MySql.Data.MySqlClient;

namespace LibraryManagement
{

    public class Database
    {
        private string connectionString = "server=localhost;database=librarydb;uid=root;pwd=;";

        // Method to establish the MySQL connection
        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        // Validate login credentials from the 'login' table
        public bool ValidateLogin(string Email, string password, string role)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();

                string query = "SELECT * FROM login WHERE Email = @Email AND Password = @password AND Role = @role";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@role", role);

                MySqlDataReader reader = cmd.ExecuteReader();
                return reader.HasRows; // Returns true if the user is found
            }
        }

        // Validate member credentials from the 'members' table
        public int ValidateMember(string Email, string password)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();

                string query = "SELECT MemberID FROM members WHERE Email = @Email AND Password = @password";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@password", password);

                MySqlDataReader reader = cmd.ExecuteReader();

                // If a record is found, return the MemberID
                if (reader.HasRows)
                {
                    reader.Read();
                    return reader.GetInt32("MemberID"); // Return MemberID
                }

                return 0; // Return 0 if no member is found
            }
        }



        // This method retrieves the profile details from the database using the email.
        public bool AuthenticateUser(string Email, string password, string role)
        {
            

            using (MySqlConnection conn = GetConnection())
            {
                string query = "SELECT * FROM Login WHERE Email = @Email AND Password = @Password AND Role = @role";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@role", role);

                MySqlDataReader reader = cmd.ExecuteReader();

                return reader.HasRows; // Returns true if the user is found
            }
        }

        public DataTable GetMemberProfileByMemberID(int memberID)
        {
            using (MySqlConnection conn = GetConnection())
            {
                string query = "SELECT * FROM members WHERE MemberID = @MemberID";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MemberID", memberID);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable profileData = new DataTable();
                adapter.Fill(profileData);

                return profileData;
            }
        }

        public bool UpdateMemberProfile(int memberID, string newName, string newEmail, string newPassword)
        {
            // Validate if the new email already exists
            using (MySqlConnection conn = GetConnection())
            {
                string checkEmailQuery = "SELECT COUNT(*) FROM members WHERE Email = @NewEmail AND MemberID != @MemberID";
                MySqlCommand checkEmailCmd = new MySqlCommand(checkEmailQuery, conn);
                checkEmailCmd.Parameters.AddWithValue("@NewEmail", newEmail);
                checkEmailCmd.Parameters.AddWithValue("@MemberID", memberID);
                conn.Open();

                int emailCount = Convert.ToInt32(checkEmailCmd.ExecuteScalar());
                if (emailCount > 0)
                {
                    MessageBox.Show("Email already exists.");
                    return false;  // Prevent update if email is taken
                }

                // Proceed with the update
                string query = "UPDATE members SET Name = @NewName, Email = @NewEmail, Password = @NewPassword WHERE MemberID = @MemberID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NewName", newName);
                cmd.Parameters.AddWithValue("@NewEmail", newEmail);
                cmd.Parameters.AddWithValue("@NewPassword", newPassword);
                cmd.Parameters.AddWithValue("@MemberID", memberID);  // Use the MemberID for the update

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;  // Return true if update was successful
            }
        }




    }



}

       
        


    




