namespace LibraryManagement
{
    partial class ManageReservations
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvReservations = new DataGridView();
            btnCancelReservation = new Button();
            btnFulfillReservation = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReservations).BeginInit();
            SuspendLayout();
            // 
            // dgvReservations
            // 
            dgvReservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservations.Location = new Point(0, 0);
            dgvReservations.Name = "dgvReservations";
            dgvReservations.RowHeadersWidth = 51;
            dgvReservations.Size = new Size(900, 552);
            dgvReservations.TabIndex = 0;
            // 
            // btnCancelReservation
            // 
            btnCancelReservation.Location = new Point(97, 590);
            btnCancelReservation.Name = "btnCancelReservation";
            btnCancelReservation.Size = new Size(168, 29);
            btnCancelReservation.TabIndex = 1;
            btnCancelReservation.Text = "Cancel Reservation";
            btnCancelReservation.UseVisualStyleBackColor = true;
            btnCancelReservation.Click += btnCancelReservation_Click;
            // 
            // btnFulfillReservation
            // 
            btnFulfillReservation.Location = new Point(386, 590);
            btnFulfillReservation.Name = "btnFulfillReservation";
            btnFulfillReservation.Size = new Size(179, 29);
            btnFulfillReservation.TabIndex = 2;
            btnFulfillReservation.Text = "Fulfill Reservation";
            btnFulfillReservation.UseVisualStyleBackColor = true;
            btnFulfillReservation.Click += btnFulfillReservation_Click;
            // 
            // ManageReservations
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnFulfillReservation);
            Controls.Add(btnCancelReservation);
            Controls.Add(dgvReservations);
            Name = "ManageReservations";
            Size = new Size(900, 699);
            Load += ManageReservations_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReservations).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvReservations;
        private Button btnCancelReservation;
        private Button btnFulfillReservation;
    }
}
