using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINALCarApp
{
    public class CarPark
    {
        private List<Car> _cars;

        public CarPark()
        {
            _cars = new List<Car>();
        }

        public void AddCar(Car car)
        {
            _cars.Add(car);
        }

        public void DisplayCars()
        {
            if (_cars.Count == 0)
            {
                Console.WriteLine("No cars available.");
                return;
            }

            Console.WriteLine("\nAvailable Cars:");
            for (int i = 0; i < _cars.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_cars[i].Brand} {_cars[i].Model} ({_cars[i].Year})");
            }
        }

        public Car SelectCar(int index)
        {
            if (index >= 0 && index < _cars.Count)
            {
                return _cars[index];
            }
            else
            {
                Console.WriteLine("Invalid selection.");
                return null;
            }
        }
    }
}