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
    public partial class GenerateReports : UserControl
    {
        public GenerateReports()
        {
            InitializeComponent();
        }

        private void comboBoxReports_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GenerateReports_Load(object sender, EventArgs e)
        {
            comboBoxReports.Items.Add("Most Borrowed Books");
            comboBoxReports.Items.Add("Most Active Members");
            comboBoxReports.Items.Add("Overdue Books");
            comboBoxReports.SelectedIndex = 0;
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            string selectedReport = comboBoxReports.SelectedItem.ToString();
            DataTable reportData = new DataTable();

            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=librarydb;uid=root;pwd=;"))
            {
                conn.Open();
                string query = "";

                if (selectedReport == "Most Borrowed Books")
                {
                    query = "SELECT BookID, COUNT(*) AS BorrowCount FROM borrowedbooks GROUP BY BookID ORDER BY BorrowCount DESC LIMIT 10";
                }
                else if (selectedReport == "Most Active Members")
                {
                    query = "SELECT MemberID, COUNT(*) AS BorrowCount FROM borrowedbooks GROUP BY MemberID ORDER BY BorrowCount DESC LIMIT 10";
                }
                else if (selectedReport == "Overdue Books")
                {
                    query = "SELECT BookID, MemberID, DueDate FROM borrowedbooks WHERE DueDate < CURDATE() AND ReturnDate IS NULL";
                }

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(reportData);
                }
            }

            dgvReports.DataSource = reportData;
        }
    }
}
