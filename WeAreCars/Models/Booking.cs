using System;
using System.Text.Json.Serialization;

namespace WeAreCars.Models
{
    /// <summary>
    /// Represents one car rental booking: the customer, the car, the options
    /// chosen and the price calculation.
    /// </summary>
    public class Booking
    {
        public string BookingID { get; set; }
        public DateTime BookingDate { get; set; }
        public Customer Customer { get; set; }
        public Car Car { get; set; }

        public bool IsReturned { get; set; }   // true once the car has come back
        /// <summary>The date the car is due back, worked out from the booking date and number of days.</summary>
        [JsonIgnore]   // calculated, so it doesn't need saving to the file
        public DateTime ReturnDate => BookingDate.AddDays(NumberOfDays);
        public int NumberOfDays { get; set; }
        public bool UnlimitedMileage { get; set; }
        public bool BreakdownCover { get; set; }

        // Pricing constants from the WeAreCars specification
        public const decimal DailyRate = 25m;                 // public so the form can display it
        private const decimal UnlimitedMileagePerDay = 10m;
        private const decimal BreakdownCoverPerDay = 2m;

        public Booking(string bookingId, Customer customer, Car car, int numberOfDays,
                       bool unlimitedMileage, bool breakdownCover)
        {
            BookingID = bookingId;
            BookingDate = DateTime.Now;
            Customer = customer;
            Car = car;
            NumberOfDays = numberOfDays;
            UnlimitedMileage = unlimitedMileage;
            BreakdownCover = breakdownCover;
        }

        // Each part of the price, so the form and summary can show a breakdown
        public decimal GetDaysCost() => DailyRate * NumberOfDays;
        public decimal GetCarCharge() => Car.GetCarTypeSurcharge();     
        public decimal GetFuelCharge() => Car.GetFuelTypeSurcharge();   
        public decimal GetMileageCost() => UnlimitedMileage ? UnlimitedMileagePerDay * NumberOfDays : 0m;
        public decimal GetBreakdownCost() => BreakdownCover ? BreakdownCoverPerDay * NumberOfDays : 0m;

        //Total price = days + car charge + fuel charge + any extras
        public decimal CalculateTotalCost()
        {
            return GetDaysCost() + GetCarCharge() + GetFuelCharge()
                 + GetMileageCost() + GetBreakdownCost();
        }

        /// <summary>Checks the business rules that must hold before a booking is confirmed.</summary>
        public bool IsValid(out string errorMessage)
        {
            if (!Customer.IsEligibleToRent())
            {
                errorMessage = "Booking cannot proceed - customer must hold a valid driving licence.";
                return false;
            }

            if (NumberOfDays < 1 || NumberOfDays > 28)
            {
                errorMessage = "Number of days must be between 1 and 28.";
                return false;
            }

            errorMessage = string.Empty;
            return true;
        }
    }
}