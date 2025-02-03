using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LibraryManagement
{
    public partial class EditMemberForm : Form
    {
        public int memberId; // Store the Member ID for updating
        public EditMemberForm(string name, string email, string password, int memberId)
        {
            InitializeComponent();

            // Set TextBox values based on the passed data
            txtName.Text = name;
            txtEmail.Text = email;
            txtPassword.Text = password;

            // Store the memberId for updating
            this.memberId = memberId;
        }

        private void EditMemberForm_Load(object sender, EventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            // Get the updated values from the textboxes
            string updatedName = txtName.Text;
            string updatedEmail = txtEmail.Text;
            string updatedPassword = txtPassword.Text;

            // Define the SQL query to update the member's details
            string query = "UPDATE members SET Name = @Name, Email = @Email, Password = @Password WHERE MemberID = @MemberID";

            // Set up the connection string (make sure this is correct for your project)
            string connectionString = "server=localhost;database=librarydb;uid=root;pwd=;";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    // Open the connection to the database
                    conn.Open();

                    // Create the MySqlCommand with the query and connection
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // Add parameters to the query to prevent SQL injection
                    cmd.Parameters.AddWithValue("@Name", updatedName);
                    cmd.Parameters.AddWithValue("@Email", updatedEmail);
                    cmd.Parameters.AddWithValue("@Password", updatedPassword);
                    cmd.Parameters.AddWithValue("@MemberID", memberId); // memberId will be the ID from the selected row

                    // Execute the update command
                    cmd.ExecuteNonQuery();

                    // Show success message
                    MessageBox.Show("Member details updated successfully.");
                }
            }
            catch (Exception ex)
            {
                // Handle any errors (e.g., database connection issues)
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            // Close the form after saving the changes
            this.Close();
        
    }
    }
}
