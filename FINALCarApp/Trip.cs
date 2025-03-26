using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINALCarApp
{
    public class Trip
    {
        public double Distance { get; set; }  // Distance traveled in kilometers
        public DateTime Date { get; set; }    // Date of the trip
        public double FuelUsed { get; set; }  // Fuel used in liters

        public Trip(double distance, double fuelUsed)
        {
            Distance = distance;
            Date = DateTime.Now;  // Automatically set the trip date to the current date
            FuelUsed = fuelUsed;
        }

        // Method to display trip information
        public void DisplayTripInfo()
        {
            Console.WriteLine($"Date: {Date.ToShortDateString()} - Distance: {Distance} km - Fuel Used: {FuelUsed} liters");
        }
    }
}