using System;
using System.Drawing;
using System.Windows.Forms;
using WeAreCars.Models;
using WeAreCars.Services;

namespace WeAreCars.Forms
{
    /// <summary>
    /// Main screen after login. Lists the cars currently out on rental and lets
    /// staff start a new booking, return a car, or cancel a booking.
    /// </summary>
    public partial class DashboardForm : Form
    {
        // The single shared RentalManager passed in from the login form
        private readonly RentalManager rentalManager;

        public DashboardForm(RentalManager rentalManager)
        {
            InitializeComponent();
            this.rentalManager = rentalManager;
            StyleGrid();

            // Re-check which buttons should be enabled whenever the selected row changes
            dgvRentedCars.SelectionChanged += (sender, e) => UpdateButtonStates();
        }

        /// Runs once when the form first appears; fills the grid.
        private void DashboardForm_Load(object sender, EventArgs e)
        {
            RefreshRentedCarsList();
        }

        ///Clears and refills the grid with one row per active booking.
        private void RefreshRentedCarsList()
        {
            dgvRentedCars.Rows.Clear();

            foreach (Booking booking in rentalManager.GetActiveBookings())
            {
                Car car = booking.Car;
                string fuel = car.FuelType == FuelType.FullElectric ? "Full electric" : car.FuelType.ToString();

                // Values go into the columns in designer order:
                // Registration, Customer, Car Type, Fuel Type
                int rowIndex = dgvRentedCars.Rows.Add(car.RegistrationNumber, booking.Customer.FullName,
                                                      car.CarType.ToString(), fuel);

                // Remember which booking this row shows, so the buttons can act on it later
                dgvRentedCars.Rows[rowIndex].Tag = booking;
            }

            dgvRentedCars.ClearSelection();
            dgvRentedCars.CurrentCell = null;                  // stops the first row auto-highlighting
            lblNoCars.Visible = dgvRentedCars.Rows.Count == 0; // show the message when the list is empty
            UpdateButtonStates();
        }

        /// Return and Cancel only make sense when a row is selected.
        private void UpdateButtonStates()
        {
            bool rowSelected = dgvRentedCars.SelectedRows.Count > 0;
            btnReturnCar.Enabled = rowSelected;
            btnCancelBooking.Enabled = rowSelected;
        }

        /// Gives the grid a clean, flat look instead of the spreadsheet default.
        private void StyleGrid()
        {
            // read-only, whole-row selection, columns share the width evenly
            dgvRentedCars.AllowUserToAddRows = false;
            dgvRentedCars.AllowUserToDeleteRows = false;
            dgvRentedCars.AllowUserToResizeRows = false;
            dgvRentedCars.ReadOnly = true;
            dgvRentedCars.RowHeadersVisible = false;
            dgvRentedCars.MultiSelect = false;
            dgvRentedCars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRentedCars.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Borders: only a thin line between rows
            dgvRentedCars.BackgroundColor = Color.White;
            dgvRentedCars.BorderStyle = BorderStyle.None;
            dgvRentedCars.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRentedCars.GridColor = Color.FromArgb(222, 222, 218);

            // Header row: light background, muted bold text, centred
            dgvRentedCars.EnableHeadersVisualStyles = false;
            dgvRentedCars.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvRentedCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvRentedCars.ColumnHeadersHeight = 38;
            dgvRentedCars.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 242);
            dgvRentedCars.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(115, 115, 110);
            dgvRentedCars.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(245, 245, 242);
            dgvRentedCars.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(115, 115, 110);
            dgvRentedCars.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvRentedCars.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Data rows: taller, centred, soft grey highlight when selected
            dgvRentedCars.RowTemplate.Height = 36;
            dgvRentedCars.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dgvRentedCars.DefaultCellStyle.ForeColor = Color.FromArgb(38, 38, 36);
            dgvRentedCars.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvRentedCars.DefaultCellStyle.SelectionBackColor = Color.FromArgb(225, 225, 220);
            dgvRentedCars.DefaultCellStyle.SelectionForeColor = Color.FromArgb(38, 38, 36);

            // Turn off header-click sorting (removes the sort arrow)
            foreach (DataGridViewColumn column in dgvRentedCars.Columns)
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        /// <summary>Opens the booking screen; the grid refreshes when it closes.</summary>
        private void btnNewBooking_Click(object sender, EventArgs e)
        {
            using (BookingForm bookingForm = new BookingForm(rentalManager))
            {
                bookingForm.ShowDialog();
            }

            // A booking may have been confirmed while that form was open
            RefreshRentedCarsList();
        }

        /// <summary>Marks the selected booking's car as returned, after confirmation.</summary>
        private void btnReturnCar_Click(object sender, EventArgs e)
        {
            if (dgvRentedCars.SelectedRows.Count == 0)
                return;   // nothing selected (the button is normally disabled in this case)

            // Each row's Tag holds the booking it shows (set in RefreshRentedCarsList)
            Booking booking = (Booking)dgvRentedCars.SelectedRows[0].Tag;

            DialogResult answer = MessageBox.Show(
                $"Mark {booking.Car.RegistrationNumber} ({booking.Customer.FullName}) as returned?",
                "Return car", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            {
                rentalManager.ReturnCar(booking);
                RefreshRentedCarsList();
            }
        }

        /// <summary>Removes the selected booking completely, after a warning.</summary>
        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            if (dgvRentedCars.SelectedRows.Count == 0)
                return;

            Booking booking = (Booking)dgvRentedCars.SelectedRows[0].Tag;

            
            DialogResult answer = MessageBox.Show(
                $"Cancel booking {booking.BookingID} for {booking.Customer.FullName}?\n\n" +
                "This removes the booking record and cannot be undone.",
                "Cancel booking", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

            if (answer == DialogResult.Yes)
            {
                rentalManager.CancelBooking(booking);
                RefreshRentedCarsList();
            }
        }

        /// Closes the dashboard, which returns to the login screen.
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}