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
    public partial class ManageMembersControl : UserControl
    {
        public ManageMembersControl()
        {
            InitializeComponent();
            LoadMembers();
        }



        private void LoadMembers()
        {
            MemberController memberController = new MemberController();
            List<Member> members = memberController.GetAllMembers(); // Retrieve members from the database
            dataGridViewMembers.DataSource = members; // Bind the members to the DataGridView
        }

        private void LoadMembers(string column, string searchText)
        {
            MemberController memberController = new MemberController();
            List<Member> members = memberController.GetMembersBySearch(column, searchText);  // Modify to fetch filtered data

            dataGridViewMembers.DataSource = members;  // Bind the filtered data to DataGridView
        }
        private void ManageMembersControl_Load(object sender, EventArgs e)
        {
            // Add items to the ComboBox when the form is loaded
            searchcomboBox.Items.Add("Name");
            searchcomboBox.Items.Add("Email");


            // Set the default selected item (Name will be selected by default)
            searchcomboBox.SelectedIndex = 0;

        }

        private void btnaddmember_Click(object sender, EventArgs e)
        {
            AddMemberForm addForm = new AddMemberForm();
            addForm.ShowDialog();

            LoadMembers();
        }

        private void dataGridViewMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridViewMembers.Rows[e.RowIndex];

                // Retrieve member details from the selected row
                string name = selectedRow.Cells["Name"].Value.ToString();
                string email = selectedRow.Cells["Email"].Value.ToString();
                string password = selectedRow.Cells["Password"].Value.ToString();

                // Get the MemberID
                int memberId = Convert.ToInt32(selectedRow.Cells["MemberID"].Value);

                // Open the EditMemberForm with the selected member details
                EditMemberForm editForm = new EditMemberForm(name, email, password, memberId);
                editForm.ShowDialog(); // Open it as a dialog
            }

        }

        private void btneditmember_Click(object sender, EventArgs e)
        {
            if (dataGridViewMembers.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridViewMembers.SelectedRows[0];

                // Retrieve member details from the selected row
                string name = selectedRow.Cells["Name"].Value.ToString();
                string email = selectedRow.Cells["Email"].Value.ToString();
                string password = selectedRow.Cells["Password"].Value.ToString();

                // Get the MemberID
                int memberId = Convert.ToInt32(selectedRow.Cells["MemberID"].Value);

                // Open the EditMemberForm with the selected member details
                EditMemberForm editForm = new EditMemberForm(name, email, password, memberId);
                editForm.ShowDialog(); // Show the form as a dialog box
            }
            else
            {
                MessageBox.Show("Please select a member to edit.");
            }

            LoadMembers();
        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {


            // Check if a row is selected
            if (dataGridViewMembers.SelectedRows.Count > 0)
            {
                // Get the selected row and fetch the MemberID
                int selectedRowIndex = dataGridViewMembers.SelectedRows[0].Index;
                int memberId = Convert.ToInt32(dataGridViewMembers.Rows[selectedRowIndex].Cells["MemberID"].Value);

                // Confirm the deletion action
                DialogResult result = MessageBox.Show("Are you sure you want to delete this member?", "Confirm Deletion", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Call the Delete method from MemberController to delete the member
                    MemberController memberController = new MemberController();
                    memberController.DeleteMember(memberId);

                    // After deletion, reload the members in the DataGridView
                    LoadMembers();

                    // Show confirmation message
                    MessageBox.Show("Member deleted successfully.");
                }
            }
            else
            {
                MessageBox.Show("Please select a member to delete.");
            }


        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string searchText = txtboxsearch.Text;  // Get the text from the search box
            string searchColumn = searchcomboBox.SelectedItem.ToString();  // Get selected column from ComboBox

            if (string.IsNullOrEmpty(searchText))  // If the search text is empty
            {
                MessageBox.Show("Please enter a search query.");
                return;
            }

            // Now call the function to filter and update the DataGridView based on the selected column and search query
            LoadMembers(searchColumn, searchText);
        }
    }
}
