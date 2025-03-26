using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINALCarApp
{
    public enum FuelType
    {
        Petrol,
        Diesel,
        Electric,
    }

    public class Car
    {
        // Attributes:
        private string _brand;
        private string _model;
        private int _year;
        private char _gearType;
        private FuelType _fuelType;
        private double _kmPerLiter;
        private bool _isEngineOn;
        private int _odometer;
        private List<Trip> _trips;

        // Constructor:
        public Car(string brand, string model, int year, char gearType, FuelType fuelType,
                   double kmPerLiter, bool isEngineOn, int odometer)
        {
            _brand = brand;
            _model = model;
            _year = year;
            _gearType = gearType;
            _fuelType = fuelType;
            _kmPerLiter = kmPerLiter;
            _isEngineOn = isEngineOn;
            _odometer = odometer;
            _trips = new List<Trip>();
        }

        // Public Properties (getters and setters) - Ensure these are public
        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public char GearType
        {
            get { return _gearType; }
            set { _gearType = value; }
        }

        public FuelType FuelType
        {
            get { return _fuelType; }
            set { _fuelType = value; }
        }

        public double KmPerLiter
        {
            get { return _kmPerLiter; }
            set { _kmPerLiter = value; }
        }

        public bool IsEngineOn
        {
            get { return _isEngineOn; }
            set { _isEngineOn = value; }
        }

        public int Odometer
        {
            get { return _odometer; }
            set { _odometer = value; }
        }

        public List<Trip> Trips
        {
            get { return _trips; }
        }

        // Method to take a drive (log a trip)
        public void TakeDrive(double distance)
        {
            double fuelUsed = distance / _kmPerLiter;
            _odometer += (int)distance;

            Trip newTrip = new Trip(distance, fuelUsed);
            _trips.Add(newTrip);

            Console.WriteLine($"\nDrive completed. Distance: {distance} km - Fuel used: {fuelUsed} liters.");
            Console.WriteLine($"Updated Odometer: {_odometer} km.");
        }

        // Method to display car details
        public void DisplayCarInfo()
        {
            Console.WriteLine($"Brand: {_brand}\nModel: {_model}\nYear: {_year}\nGear Type: {_gearType}\nFuel Type: {_fuelType}\nOdometer: {_odometer} km");
            Console.WriteLine("Trips:");
            foreach (var trip in _trips)
            {
                trip.DisplayTripInfo();
            }
        }

        // Method to collect car details from user and create a Car object - Ensure this is public
        public static Car CreateCarFromUserInput()
        {
            Console.Write("Enter the car brand: ");
            string brand = Console.ReadLine();

            Console.Write("Enter the car model: ");
            string model = Console.ReadLine();

            Console.Write("Enter the car year: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Enter the gear type (A for automatic, M for manual): ");
            char geartype = char.Parse(Console.ReadLine());

            Console.WriteLine("Select fuel type:");
            Console.WriteLine("1. Petrol");
            Console.WriteLine("2. Diesel");
            Console.WriteLine("3. Electric");
            int fuelChoice = int.Parse(Console.ReadLine());

            // Convert user input to FuelTypes enum
            FuelType fuelType = GetFuelTypeFromInput(fuelChoice);

            Console.Write("Enter the car's kilometers per liter (fuel efficiency): ");
            double kmPerLiter = double.Parse(Console.ReadLine());

            // Create and return a new Car object
            return new Car(brand, model, year, geartype, fuelType, kmPerLiter, false, 0);
        }

        // Method to convert user input into FuelTypes enum
        public static FuelType GetFuelTypeFromInput(int fuelChoice)
        {
            switch (fuelChoice)
            {
                case 1:
                    return FuelType.Petrol;
                case 2:
                    return FuelType.Diesel;
                case 3:
                    return FuelType.Electric;
                default:
                    Console.WriteLine("Invalid choice. Defaulting to Petrol.");
                    return FuelType.Petrol;
            }
        }
    }
}