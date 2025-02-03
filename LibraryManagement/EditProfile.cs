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
    public partial class EditProfile : UserControl
    {
        private int currentMemberID;
        private string Email;
        private Database db = new Database(); // Instance of Database class to fetch data

        public EditProfile()
        {
            InitializeComponent();
        }
        public EditProfile(int currentMemberID)
        {
            InitializeComponent();
            this.currentMemberID = currentMemberID; // Set the currentMemberID
            LoadProfileData(); // Load profile data when the form is created
        }
        private void LoadProfileData()
        {
            // Use the currentMemberID to load the profile
            DataTable profileData = db.GetMemberProfileByMemberID(currentMemberID); // Use MemberID instead of Email

            if (profileData.Rows.Count > 0)
            {
                // Populate the textboxes with current data
                txtName.Text = profileData.Rows[0]["Name"].ToString();
                txtEmail.Text = profileData.Rows[0]["Email"].ToString();
                txtPassword.Text = profileData.Rows[0]["Password"].ToString();
            }
            else
            {
                MessageBox.Show("Profile not found.");
            }
        }
        private void EditProfile_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string newName = txtName.Text;
            string newEmail = txtEmail.Text;
            string newPassword = txtPassword.Text;

            using (var conn = db.GetConnection())
            {
                conn.Open();
                string query = "UPDATE members SET Name = @Name, Email = @Email, Password = @Password WHERE MemberID = @MemberID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", newName);
                cmd.Parameters.AddWithValue("@Email", newEmail);
                cmd.Parameters.AddWithValue("@Password", newPassword);
                cmd.Parameters.AddWithValue("@MemberID", currentMemberID);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Profile updated successfully!");
                }
                else
                {
                    MessageBox.Show("Profile update failed.");
                }



            }
        }
    }
}
