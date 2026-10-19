using System;
using System.Windows.Forms;
using WeAreCars.Forms;
using WeAreCars.Services;

namespace WeAreCars
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();   

            
            RentalManager rentalManager = new RentalManager();

            Application.Run(new SplashForm(rentalManager));
        }
    }
}