using System.Diagnostics;



namespace FINALCarApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CarPark carPark = new CarPark(); // Initialize CarPark

            while (true)
            {
                Console.WriteLine("\nCar Park Menu:");
                Console.WriteLine("1. Add a car");
                Console.WriteLine("2. View cars");
                Console.WriteLine("3. Select a car");
                Console.WriteLine("4. Take a drive");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        // Add a car
                        Car newCar = Car.CreateCarFromUserInput();
                        carPark.AddCar(newCar);
                        Console.WriteLine("Car added successfully!");
                        break;

                    case 2:
                        // View all cars
                        carPark.DisplayCars();
                        break;

                    case 3:
                        // Select a car
                        carPark.DisplayCars();  // Show the list of cars
                        Console.Write("Select a car by entering the number: ");
                        int carChoice = int.Parse(Console.ReadLine()) - 1;

                        Car selectedCar = carPark.SelectCar(carChoice);

                        if (selectedCar != null)
                        {
                            // Display selected car info
                            Console.WriteLine("\nCar selected:");
                            selectedCar.DisplayCarInfo();
                        }
                        break;

                    case 4:
                        // Take a drive
                        carPark.DisplayCars();  // Show the list of cars
                        Console.Write("Select a car by entering the number: ");
                        carChoice = int.Parse(Console.ReadLine()) - 1;

                        selectedCar = carPark.SelectCar(carChoice);

                        if (selectedCar != null)
                        {
                            Console.Write("Enter the distance of the drive in kilometers: ");
                            double distance = double.Parse(Console.ReadLine());

                            // Log the trip and update the car
                            selectedCar.TakeDrive(distance);
                        }
                        break;

                    case 5:
                        // Exit
                        Console.WriteLine("Exiting program.");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}