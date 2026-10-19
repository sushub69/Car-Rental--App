using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using WeAreCars.Models;

namespace WeAreCars.Services
{
    /// <summary>
    /// Central service class that manages the cars and bookings.
    /// Bookings are saved to a JSON file so they survive closing the application.
    /// </summary>
    public class RentalManager
    {
        private List<Car> cars;
        private List<Booking> bookings;
        private int nextBookingNumber;
        private int nextCarNumber;

        // Saved to C:\Users\<name>\AppData\Roaming\WeAreCars\bookings.json
        private readonly string saveFilePath;

      
        private static readonly JsonSerializerOptions jsonOptions = new JsonSerializerOptions
        {
            WriteIndented = true,
            Converters = { new JsonStringEnumConverter() }
        };

        public RentalManager()
        {
            cars = new List<Car>();
            bookings = new List<Booking>();
            nextBookingNumber = 1;
            nextCarNumber = 100;

            SeedSampleCars();

            string folder = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "WeAreCars");
            Directory.CreateDirectory(folder);
            saveFilePath = Path.Combine(folder, "bookings.json");

            LoadBookings();
        }

        /// <summary>Creates a small starting fleet of cars.</summary>
        private void SeedSampleCars()
        {
            cars.Add(new Car("WC01 CTY", CarType.City, FuelType.Petrol));
            cars.Add(new Car("WC02 FAM", CarType.Family, FuelType.Diesel));
            cars.Add(new Car("WC03 SPT", CarType.Sports, FuelType.Petrol));
            cars.Add(new Car("WC04 SUV", CarType.SUV, FuelType.Hybrid));
            cars.Add(new Car("WC05 ELC", CarType.City, FuelType.FullElectric));
        }

        // ---------- Saving and loading ----------

        /// <summary>Reads saved bookings from the file (if there is one) when the app starts.</summary>
        private void LoadBookings()
        {
            if (!File.Exists(saveFilePath))
                return;   // first run: nothing saved yet

            try
            {
                string json = File.ReadAllText(saveFilePath);
                List<Booking> loaded = JsonSerializer.Deserialize<List<Booking>>(json, jsonOptions);
                if (loaded == null)
                    return;

                bookings = loaded;

                // Every booking brings its own car record, so add those to the fleet
                foreach (Booking booking in bookings)
                    cars.Add(booking.Car);

                // Carry on numbering after the highest ID already used
                if (bookings.Count > 0)
                {
                    nextBookingNumber = bookings.Max(b => ParseNumber(b.BookingID, 3)) + 1;
                    nextCarNumber = Math.Max(100,
                        bookings.Max(b => ParseNumber(b.Car.RegistrationNumber.Split(' ')[0], 2)) + 1);
                }
            }
            catch (Exception)
            {
                // An unreadable or damaged file shouldn't stop the app opening, so start empty instead
                bookings = new List<Booking>();
            }
        }

        /// <summary>Writes every booking to the file. Called after each change.</summary>
        private void SaveBookings()
        {
            try
            {
                string json = JsonSerializer.Serialize(bookings, jsonOptions);
                File.WriteAllText(saveFilePath, json);
            }
            catch (Exception)
            {
                // If the disk can't be written to, the app keeps working in memory for this session
            }
        }

        /// <summary>Reads the number after a prefix, e.g. ("BK-0007", 3) gives 7.</summary>
        private static int ParseNumber(string text, int prefixLength)
        {
            return text.Length > prefixLength && int.TryParse(text.Substring(prefixLength), out int number)
                ? number : 0;
        }

        // ---------- Cars and bookings ----------

        /// <summary>Returns cars that are not currently rented.</summary>
        public List<Car> GetAvailableCars()
        {
            return cars.Where(c => !c.IsRented).ToList();
        }

        /// <summary>Returns cars that are currently rented out.</summary>
        public List<Car> GetRentedCars()
        {
            return cars.Where(c => c.IsRented).ToList();
        }

        /// <summary>Generates the next booking ID, e.g. BK-0001.</summary>
        public string GenerateBookingID()
        {
            string id = $"BK-{nextBookingNumber:D4}";
            nextBookingNumber++;
            return id;
        }

        /// <summary>Creates a car of the chosen type and fuel with a generated registration.</summary>
        public Car CreateCar(CarType carType, FuelType fuelType)
        {
            string registration = $"WC{nextCarNumber} {carType.ToString().Substring(0, 3).ToUpper()}";
            nextCarNumber++;
            return new Car(registration, carType, fuelType);
        }

        /// <summary>Stores a confirmed booking, marks its car as rented and saves.</summary>
        public void AddBooking(Booking booking)
        {
            bookings.Add(booking);
            if (!cars.Contains(booking.Car))
                cars.Add(booking.Car);
            booking.Car.MarkAsRented();
            SaveBookings();
        }

        /// <summary>Returns every booking, including returned ones.</summary>
        public List<Booking> GetAllBookings()
        {
            return bookings;
        }

        /// <summary>Returns only the bookings whose car is still out on rental.</summary>
        public List<Booking> GetActiveBookings()
        {
            return bookings.Where(b => !b.IsReturned).ToList();
        }

        /// <summary>Records that a car has come back; the booking is kept on record.</summary>
        public void ReturnCar(Booking booking)
        {
            booking.IsReturned = true;
            booking.Car.MarkAsReturned();
            SaveBookings();
        }

        /// <summary>Removes a booking entirely (e.g. one entered by mistake), then saves.</summary>
        public void CancelBooking(Booking booking)
        {
            bookings.Remove(booking);
            cars.Remove(booking.Car);
            SaveBookings();
        }
    }
}