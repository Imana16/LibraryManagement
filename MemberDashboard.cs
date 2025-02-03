using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LibraryManagement
{
    public partial class MemberDashboard : Form

    {
        private string Email;
        private int currentMemberID;



        public MemberDashboard()
        {
            InitializeComponent();
        }
        public MemberDashboard(string email)
        {
            InitializeComponent();
            this.Email = email;
            LoadProfile();
        }
        public MemberDashboard(int memberID)
        {
            InitializeComponent();
            this.currentMemberID = memberID; // Store the member ID for use in this dashboard
        }
        private void LoadProfile()
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MemberDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            ViewProfile profileControl = new ViewProfile(currentMemberID);  // Pass the email to ViewProfile
            panelRight.Controls.Clear();
            panelRight.Controls.Add(profileControl);

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            EditProfile editProfileControl = new EditProfile(currentMemberID);  // Pass the logged-in user's email
            panelRight.Controls.Clear();  // Clear the existing controls
            panelRight.Controls.Add(editProfileControl);
        }

        private void panelRight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBorrowBooks_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrowReturnBooks_Click(object sender, EventArgs e)
        {
            BorrowBooksUserControl borrowBooksUserControl = new BorrowBooksUserControl(currentMemberID);

            // Clear the current panel and add the BorrowBooksUserControl
            panelRight.Controls.Clear(); // This removes the current content of the panel
            panelRight.Controls.Add(borrowBooksUserControl); // Add the borrowBooksUserControl to the panel

            // Optionally, set the size and location of the new control if needed
            borrowBooksUserControl.Dock = DockStyle.Fill;
        }

        private void btnReserveBooks_Click(object sender, EventArgs e)
        {
            // Create instance of the ReserveBooks UserControl
            ReserveBooks reserveBooks = new ReserveBooks(currentMemberID);
            // Clear the content panel and add the ReserveBooks control
            panelRight.Controls.Clear();
            panelRight.Controls.Add(reserveBooks);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
