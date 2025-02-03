using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace LibraryManagement
{
    public partial class loginform : Form
    {
        private LoginController loginController = new LoginController();
        public loginform()
        {
            InitializeComponent();
        }

        private void loginform_Load(object sender, EventArgs e)
        {
            // Populate the role dropdown with available roles
            comborole.Items.Add("Admin");
            comborole.Items.Add("Librarian");
            comborole.Items.Add("Member");

            // Set default value for role selection (optional)
            comborole.SelectedIndex = 0;  // Default is "Admin"
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string email = txtemail.Text;
            string password = txtpassword.Text;
            string role = comborole.SelectedItem.ToString();  // Get the selected role from combo box

            int currentMemberID = 0;  // Variable to store MemberID

            // Authenticate the user based on the role and pass the reference for MemberID if it's a member
            bool isValidUser = loginController.AuthenticateUser(email, password, role, ref currentMemberID);

            if (isValidUser)
            {
                if (role == "Admin")
                {
                    // Navigate to Admin Dashboard
                    AdminDashboard adminDashboard = new AdminDashboard();
                    adminDashboard.Show();
                    this.Hide();
                }
                else if (role == "Librarian")
                {
                    // Navigate to Librarian Dashboard
                    LibrarianDashboard librarianDashboard = new LibrarianDashboard("librarianName");
                    librarianDashboard.Show();
                    this.Hide();
                }
                else if (role == "Member")
                {
                    // Pass MemberID to Member Dashboard
                    MemberDashboard memberDashboard = new MemberDashboard(currentMemberID);
                    memberDashboard.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Invalid login credentials. Please try again.");
            }
        }
        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_Click(object sender, EventArgs e)
        {

        }
    }
}
