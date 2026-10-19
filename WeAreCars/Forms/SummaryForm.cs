using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WeAreCars.Models;
using WeAreCars.Services;

namespace WeAreCars.Forms
{
    /// <summary>
    /// Read-only recap of a booking, shown before it is saved.
    /// Staff either confirm the booking or go back to edit it.
    /// </summary>
    public partial class SummaryForm : Form
    {
        private readonly RentalManager rentalManager;
        private readonly Booking booking;

        public SummaryForm(RentalManager rentalManager, Booking booking)
        {
            InitializeComponent();
            this.rentalManager = rentalManager;
            this.booking = booking;

            ShowBookingDetails();
        }

        // Fills every label on the form from the booking
        private void ShowBookingDetails()
        {
            lblBookingId.Text = booking.BookingID;

            // Customer
            lblValName.Text = booking.Customer.FullName;
            lblValAddress.Text = booking.Customer.Address;
            lblValAge.Text = booking.Customer.Age.ToString();
            lblValLicence.Text = booking.Customer.HasValidLicence ? "Yes" : "No";

            // Rental
            lblValCarType.Text = booking.Car.CarType.ToString();
            lblValFuelType.Text = FuelName(booking.Car.FuelType);
            lblValDays.Text = booking.NumberOfDays.ToString();
            lblValExtras.Text = ExtrasText();
            // Two lines: the weekday on top, the full date underneath
            lblValReturnDate.Text = booking.ReturnDate.ToString("dddd") + Environment.NewLine
                                  + booking.ReturnDate.ToString("d MMMM yyyy");  // e.g. Monday 19 October 2026

            // Price breakdown (same methods the live estimate uses, so the numbers always match)
            int days = booking.NumberOfDays;
            lblLineDays.Text = $"{days} {(days == 1 ? "day" : "days")} × £{Booking.DailyRate:0}";
            lblAmtDays.Text = Money(booking.GetDaysCost());

            lblLineCar.Text = $"{booking.Car.CarType} car";
            lblAmtCar.Text = Charge(booking.GetCarCharge());

            lblLineFuel.Text = FuelName(booking.Car.FuelType);
            lblAmtFuel.Text = Charge(booking.GetFuelCharge());

            lblLineMileage.Text = "Unlimited mileage";
            lblAmtMileage.Text = Charge(booking.GetMileageCost());

            lblLineBreakdown.Text = "Breakdown cover";
            lblAmtBreakdown.Text = Charge(booking.GetBreakdownCost());

            lblTotalValue.Text = Money(booking.CalculateTotalCost());
        }

        /// <summary>Lists the optional extras that were chosen, or "None".</summary>
        private string ExtrasText()
        {
            List<string> extras = new List<string>();

            if (booking.UnlimitedMileage) extras.Add("Unlimited mileage");
            if (booking.BreakdownCover) extras.Add("Breakdown cover");

            return extras.Count == 0 ? "None" : string.Join(", ", extras);
        }

        /// <summary>Turns FullElectric into the friendlier "Full electric".</summary>
        private static string FuelName(FuelType fuel)
        {
            return fuel == FuelType.FullElectric ? "Full electric" : fuel.ToString();
        }

        private static string Money(decimal amount) => $"£{amount:0.00}";

        // Shows a dash instead of £0.00 for charges that don't apply
        private static string Charge(decimal amount) => amount == 0m ? "—" : Money(amount);

        // Saves the booking and closes with OK, so the booking form closes too
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // Final safety check of the business rules before saving
            if (!booking.IsValid(out string error))
            {
                MessageBox.Show(error, "Cannot confirm booking",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            rentalManager.AddBooking(booking);

            MessageBox.Show($"Booking {booking.BookingID} confirmed.\nTotal: {Money(booking.CalculateTotalCost())}",
                            "Booking confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
        }

        /// <summary>Closes without saving; the booking form stays open with its data intact.</summary>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void lblValCarType_Click(object sender, EventArgs e)
        {

        }

        private void lblValName_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalValue_Click(object sender, EventArgs e)
        {

        }

        private void SummaryForm_Load(object sender, EventArgs e)
        {

        }

        private void lblTotalCaption_Click(object sender, EventArgs e)
        {

        }
    }
}