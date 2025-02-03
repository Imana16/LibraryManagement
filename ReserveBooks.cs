using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagement.Modelclass;
using MySql.Data.MySqlClient;

namespace LibraryManagement
{
    public partial class ReserveBooks : UserControl
    {
        private int currentMemberID;

        private ReservationController reservationController = new ReservationController();
        private Database db = new Database();
        public ReserveBooks()
        {
            InitializeComponent();

        }
        public ReserveBooks(int memberID)
        {
            InitializeComponent();
            currentMemberID = memberID;
            LoadBooks(currentMemberID);
            LoadReservations( memberID);
            // Load books based on currentMemberID
        }
        private void LoadBooks(int currentMemberID)
        {
            ReservationController reservationController = new ReservationController();
            var availableBooks = reservationController.GetAvailableBooks();

            // Bind the available books to the ComboBox
            cmbBooksAvailable.DataSource = availableBooks;
            cmbBooksAvailable.DisplayMember = "Title";  // Show book title
            cmbBooksAvailable.ValueMember = "BookID";
        }
        public void LoadReservations(int memberID)
        {
            // Fetch updated reservation data
            List<ReservationModel> reservations = reservationController.GetReservationsByMember(memberID);
            dgvReservations.DataSource = reservations; // Binding updated data to the DataGridView
        }
        private void ReserveBooks_Load(object sender, EventArgs e)
        {

        }
        private bool CheckBookAvailability(int bookID)
        {
            ReservationController reservationController = new ReservationController();
            List<BookModel> availableBooks = reservationController.GetAvailableBooks();

            // Check if the book ID is in the list of available books
            return availableBooks.Any(b => b.BookID == bookID);
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {

            // Get selected book ID from the ComboBox
            int bookID = (int)cmbBooksAvailable.SelectedValue;

            // Get current member ID
            int memberID = currentMemberID;

            // Call the ReservationController to add a reservation
            ReservationController reservationController = new ReservationController();
            bool reservationSuccess = reservationController.AddReservation(memberID, bookID);

           
            if (reservationSuccess)
            {
                MessageBox.Show("Book reserved successfully.");
                LoadReservations(memberID); // Refresh the DataGridView
            }
            else
            {
                MessageBox.Show("Failed to reserve the book.");
            }
        }

        private void cmbBooksAvailable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvReservations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
