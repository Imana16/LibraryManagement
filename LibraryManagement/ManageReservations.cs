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
    public partial class ManageReservations : UserControl
    {
        private ReservationController reservationController = new ReservationController();
        public ManageReservations()
        {
            InitializeComponent();
        }
        private void LoadReservations()
        {
            List<ReservationModel> reservations = reservationController.GetAllReservations();
            dgvReservations.DataSource = reservations;
        }
        private void ManageReservations_Load(object sender, EventArgs e)
        {
            LoadReservations();
        }

        private void btnCancelReservation_Click(object sender, EventArgs e)
        {
            if (dgvReservations.SelectedRows.Count > 0)
            {
                int reservationID = Convert.ToInt32(dgvReservations.SelectedRows[0].Cells["ReservationID"].Value);
                bool success = reservationController.CancelReservation(reservationID);

                if (success)
                {
                    MessageBox.Show("Reservation canceled successfully.");
                    LoadReservations(); // Reload reservations after canceling
                }
                else
                {
                    MessageBox.Show("Error canceling reservation.");
                }
            }
        }

        private void btnFulfillReservation_Click(object sender, EventArgs e)
        {
            if (dgvReservations.SelectedRows.Count > 0)
            {
                int reservationID = Convert.ToInt32(dgvReservations.SelectedRows[0].Cells["ReservationID"].Value);
                bool success = reservationController.FulfillReservation(reservationID);

                if (success)
                {
                    MessageBox.Show("Reservation fulfilled successfully.");
                    LoadReservations(); // Reload reservations after fulfilling
                }
                else
                {
                    MessageBox.Show("Error fulfilling reservation.");
                }
            }
        }

       
    }
}
