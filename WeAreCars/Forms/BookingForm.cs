using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WeAreCars.Models;
using WeAreCars.Services;

namespace WeAreCars.Forms
{
   
    /// The main booking screen. Staff enter customer and rental details here,
    /// and the panel on the left shows a live price estimate as options change.
    
    public partial class BookingForm : Form
    {
        private readonly RentalManager rentalManager;

        // Text colour for tiles that are not selected (selected tiles turn white)
        private readonly Color charcoal = Color.FromArgb(38, 38, 36);

        public BookingForm(RentalManager rentalManager)
        {
            InitializeComponent();
            this.rentalManager = rentalManager;
            UiHelper.RoundTextBox(txtFirstName);
            UiHelper.RoundTextBox(txtSurname);
            UiHelper.RoundTextBox(txtAddress);
            UiHelper.RoundTextBox(txtAge);

           
            rdoCity.Tag = CarType.City;
            rdoFamily.Tag = CarType.Family;
            rdoSports.Tag = CarType.Sports;
            rdoSuv.Tag = CarType.SUV;

            rdoPetrol.Tag = FuelType.Petrol;
            rdoDiesel.Tag = FuelType.Diesel;
            rdoHybrid.Tag = FuelType.Hybrid;
            rdoElectric.Tag = FuelType.FullElectric;

            // Spec: number of days must be between 1 and 28
            numDays.Minimum = 1;
            numDays.Maximum = 28;
            numDays.Value = 1;

            
            lblLineMileage.Text = "Unlimited mileage";
            lblLineBreakdown.Text = "Breakdown cover";

            // Connect every option control to one shared method, so any change
            // refreshes the tile colours and the estimate
            foreach (RadioButton tile in GetAllTiles())
                tile.CheckedChanged += OptionChanged;

            numDays.ValueChanged += OptionChanged;
            chkUnlimitedMileage.CheckedChanged += OptionChanged;
            chkBreakdownCover.CheckedChanged += OptionChanged;

            txtAge.KeyPress += txtAge_KeyPress;

            OptionChanged(this, EventArgs.Empty);   // show the first estimate straight away
        }

        // ---------- Live estimate ----------

        /// Returns every tile (licence, car type and fuel type radio buttons)
        private IEnumerable<RadioButton> GetAllTiles()
        {
            return pnlLicence.Controls.OfType<RadioButton>()
                .Concat(pnlCarType.Controls.OfType<RadioButton>())
                .Concat(pnlFuel.Controls.OfType<RadioButton>());
        }

        ///  Runs whenever any option changes
        private void OptionChanged(object sender, EventArgs e)
        {
            foreach (RadioButton tile in GetAllTiles())
            {
                // Selected tile: charcoal background with white text. Others: white with charcoal text.
                tile.BackColor = tile.Checked ? charcoal : Color.White;
                tile.ForeColor = tile.Checked ? Color.White : charcoal;
            }

            UpdateEstimate();
        }
        private CarType GetSelectedCarType()
        {
            var selected = pnlCarType.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            return selected == null ? CarType.City : (CarType)selected.Tag;
        }

        private FuelType GetSelectedFuelType()
        {
            var selected = pnlFuel.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            return selected == null ? FuelType.Petrol : (FuelType)selected.Tag;
        }

        /// <summary>
        /// Builds a temporary booking from the current choices and shows its price
        /// breakdown on the left panel. Nothing is saved.
        /// </summary>
        private void UpdateEstimate()
        {
            int days = (int)numDays.Value;
            Car car = new Car("TEMP", GetSelectedCarType(), GetSelectedFuelType());
            Customer placeholder = new Customer("", "", "", 0, true);
            Booking estimate = new Booking("TEMP", placeholder, car, days,
                                           chkUnlimitedMileage.Checked, chkBreakdownCover.Checked);

            lblLineDays.Text = $"{days} {(days == 1 ? "day" : "days")} × £{Booking.DailyRate:0}";
            lblAmtDays.Text = Money(estimate.GetDaysCost());

            lblLineCar.Text = $"{car.CarType} car";
            lblAmtCar.Text = Charge(estimate.GetCarCharge());

            lblLineFuel.Text = car.FuelType == FuelType.FullElectric ? "Full electric" : car.FuelType.ToString();
            lblAmtFuel.Text = Charge(estimate.GetFuelCharge());

            lblAmtMileage.Text = Charge(estimate.GetMileageCost());
            lblAmtBreakdown.Text = Charge(estimate.GetBreakdownCost());

            lblTotal.Text = Money(estimate.CalculateTotalCost());
        }

        private static string Money(decimal amount) => $"£{amount:0.00}";

        // Shows a dash instead of £0.00 for charges that don't apply
        private static string Charge(decimal amount) => amount == 0m ? "—" : Money(amount);

        // ---------- Validation ----------

        /// Only lets digits (and Backspace) be typed into the age box.
        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;   // cancels the keystroke
        }

        
        /// Checks every mandatory field and puts a red icon beside each invalid one.
        /// Returns true only if everything is valid.
        
        private bool ValidateInputs()
        {
            errorProvider.Clear();
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                errorProvider.SetError(txtFirstName, "First name is required.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtSurname.Text))
            {
                errorProvider.SetError(txtSurname, "Surname is required.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                errorProvider.SetError(txtAddress, "Address is required.");
                isValid = false;
            }

            // TryParse gives false instead of crashing if the text isn't a whole number
            if (!int.TryParse(txtAge.Text, out int age) || age < 18 || age > 99)
            {
                errorProvider.SetError(txtAge, "Enter a valid age between 18 and 99.");
                isValid = false;
            }

            if (!rdoLicenceYes.Checked && !rdoLicenceNo.Checked)
            {
                errorProvider.SetError(pnlLicence, "Please state whether the customer has a valid licence.");
                isValid = false;
            }

            return isValid;
        }

        // ---------- Buttons ----------

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;   // the red icons show what needs fixing

            Customer customer = new Customer(
                txtFirstName.Text.Trim(),
                txtSurname.Text.Trim(),
                txtAddress.Text.Trim(),
                int.Parse(txtAge.Text),
                rdoLicenceYes.Checked);

            // if there is no valid licence, the booking can't proceed
            if (!customer.IsEligibleToRent())
            {
                MessageBox.Show("Booking cannot proceed - the customer must hold a valid driving licence.",
                                "Licence required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Car car = rentalManager.CreateCar(GetSelectedCarType(), GetSelectedFuelType());

            Booking booking = new Booking(
                rentalManager.GenerateBookingID(),
                customer,
                car,
                (int)numDays.Value,
                chkUnlimitedMileage.Checked,
                chkBreakdownCover.Checked);

            // OK from the summary means the booking was confirmed; anything else keeps staff here to edit
            using (SummaryForm summary = new SummaryForm(rentalManager, booking))
            {
                if (summary.ShowDialog() == DialogResult.OK)
                    this.DialogResult = DialogResult.OK;   // closes this form too
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }
    }
}