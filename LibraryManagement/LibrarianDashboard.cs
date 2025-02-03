using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class LibrarianDashboard : Form
    {
        private string librarianName;

        public LibrarianDashboard(string name)
        {
            InitializeComponent();
            librarianName = name;
        }




        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LibrarianDashboard_Load(object sender, EventArgs e)
        {
            LibrarianName.Text = $" {librarianName}";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void ManageBooks_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Clear(); 
            ManageBooksControl manageBooksControl = new ManageBooksControl(); 
            contentPanel.Controls.Add(manageBooksControl); 
            manageBooksControl.Dock = DockStyle.Fill;
        }

        private void ManageMembers_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Clear();
            ManageMembersControl manageMembersControl = new ManageMembersControl();
            contentPanel.Controls.Add(manageMembersControl);
            manageMembersControl.Dock = DockStyle.Fill;
        }

        private void contentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void ManageReservations_Click(object sender, EventArgs e)
        {
            ManageReservations managereservations = new ManageReservations();
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(managereservations);
            managereservations.Dock = DockStyle.Fill;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ManageBorrowing_Click(object sender, EventArgs e)
        {
            ManageBorrowings manageBorrowing = new ManageBorrowings();
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(manageBorrowing);
            manageBorrowing.Dock = DockStyle.Fill;
        }
    }
}












