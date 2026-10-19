namespace WeAreCars.Models
{
   
    public class Customer
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public bool HasValidLicence { get; set; }

        public Customer(string firstName, string surname, string address, int age, bool hasValidLicence)
        {
            FirstName = firstName;
            Surname = surname;
            Address = address;
            Age = age;
            HasValidLicence = hasValidLicence;
        }

        public bool IsEligibleToRent()
        {
            return HasValidLicence;
        }

        public string FullName => $"{FirstName} {Surname}";
    }
}