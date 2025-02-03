using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LibraryManagement
{
    public partial class ViewProfile : UserControl
    {
        private int currentMemberID;
        private string Email;
        

        private Database db = new Database();
        public ViewProfile()
        {
            InitializeComponent();
        }
        public ViewProfile(int currentMemberID)
        {
            InitializeComponent();
            this.currentMemberID = currentMemberID; // Set the currentMemberID
            LoadProfile(); // Load profile data when the form is created
        }
        private void LoadProfile()
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT Name, Email, Password FROM members WHERE MemberID = @MemberID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MemberID", currentMemberID);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtName.Text = reader["Name"].ToString();
                    txtEmail.Text = reader["Email"].ToString();
                    txtPassword.Text = reader["Password"].ToString();
                }
            }
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void ViewProfile_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }
    }
}
