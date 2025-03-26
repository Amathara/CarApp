using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINALCarApp
{
    enum FuelType
    {
        Petrol,
        Diesel,
        Electric,

    }
    internal class Car
    {
        // Set attributes:
        private string _name;
        private string _brand;
        private string _model;
        private int _year;
        private char _gearType;
        private FuelType _fuelType;

       
        // Constructor:
        public Car(string name, string brand, string model, int year, char gearType, FuelType fuelType)
        {
            _name = name;
            _brand = brand;
            _model = model;
            _year = year;
            _gearType = gearType;
            _fuelType = fuelType;
        }

        // Public Properties (getters and setters)
        public string Name
        { 
            get { return _name; }
            set { _name = value; }
        }
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
        public char gearType
        {
            get { return _gearType; }
            set { _gearType = value; }
        }

        public FuelType FuelType
        {
            get { return _fuelType; }
            set { _fuelType = value; }
        }

        // Method to convert user input into fueltypes Enum
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
                default: //if they write somethig that's NOT one of these
                    Console.WriteLine("We don't have that type here!\n Defaulting to Petrol");
                    return FuelType.Petrol;
            }
        }

        public void DisplayCarInfo()
        {
            Console.WriteLine($"Car Name: {_name}\n\nBrand: {_brand}\n\nModel: {_model}\n\nYear: {_year}Gear Type: {_gearType}\n\n");
        }

            
}
