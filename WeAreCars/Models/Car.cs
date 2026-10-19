namespace WeAreCars.Models
{
 
    public enum CarType
    {
        City,     // No extra charge
        Family,   // +£50
        Sports,   // +£75
        SUV       // +£65
    }

    public enum FuelType
    {
        Petrol,       // No extra charge
        Diesel,       // No extra charge
        Hybrid,       // +£30
        FullElectric  // +£50
    }

    public class Car
    {
        public string RegistrationNumber { get; set; }
        public CarType CarType { get; set; }
        public FuelType FuelType { get; set; }
        public bool IsRented { get; set; }

        public Car(string registrationNumber, CarType carType, FuelType fuelType)
        {
            RegistrationNumber = registrationNumber;
            CarType = carType;
            FuelType = fuelType;
            IsRented = false;
        }

        public decimal GetCarTypeSurcharge()
        {
            switch (CarType)
            {
                case CarType.Family: return 50m;
                case CarType.Sports: return 75m;
                case CarType.SUV: return 65m;
                default: return 0m; // City
            }
        }

        public decimal GetFuelTypeSurcharge()
        {
            switch (FuelType)
            {
                case FuelType.Hybrid: return 30m;
                case FuelType.FullElectric: return 50m;
                default: return 0m; // Petrol / Diesel
            }
        }

        public void MarkAsRented() => IsRented = true;
        public void MarkAsReturned() => IsRented = false;
    }
}