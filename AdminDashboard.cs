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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void btnViewAllMembers_Click(object sender, EventArgs e)
        {
            ViewAllMembers viewAllMembersControl = new ViewAllMembers();
            panel3.Controls.Clear();
            panel3.Controls.Add(viewAllMembersControl);
            viewAllMembersControl.Dock = DockStyle.Fill;
        }

        private void btnViewAllBooks_Click(object sender, EventArgs e)
        {
            ViewAllBooks viewAllBooksControl = new ViewAllBooks();
            panel3.Controls.Clear();
            panel3.Controls.Add(viewAllBooksControl);
            viewAllBooksControl.Dock = DockStyle.Fill;
        }

        private void btnGenerateReports_Click(object sender, EventArgs e)
        {
            GenerateReports GenerateReportsControl = new GenerateReports();
            panel3.Controls.Clear();
            panel3.Controls.Add(GenerateReportsControl);
            GenerateReportsControl.Dock = DockStyle.Fill;

        }
    }
}
