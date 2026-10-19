namespace WeAreCars.Models
{

    public class Staff
    {
        public string StaffID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        private const string ValidUsername = "sta001";
        private const string ValidPassword = "givemethekeys123";

        public Staff(string staffId, string username, string password)
        {
            StaffID = staffId;
            Username = username;
            Password = password;
        }

        public static bool ValidateLogin(string username, string password)
        {
            return username == ValidUsername && password == ValidPassword;
        }
    }
}