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
    public partial class ViewAllMembers : UserControl
    {
        private AdminController adminController = new AdminController();
        public ViewAllMembers()
        {
            InitializeComponent();
        }

        private void ViewAllMembers_Load(object sender, EventArgs e)
        {
            List<Member> members = adminController.GetAllMembers();

            // Bind the members to the DataGridView
            dgvViewAllMembers.DataSource = members;
        }
    }
}
