using SEDC.CSharpOop.Class06Homework.RaceCars.MyClasses;
using System;


namespace SEDC.CSharpOop.Class06Homework.RaceCars
{
    class Program
    {
        static void Main(string[] args)
        {
            RaceApp();
            Console.WriteLine("Enter Y to race again");
            if(Console.ReadLine().ToLower() == "y")
            {
                Console.Clear();
                RaceApp();
            }
            Console.ReadLine();

        }

        static void RaceApp()
        {
            Car[] cars = new Car[]
            {
                new Car("Hyundai", 20),
                new Car("Mazda", 20),
                new Car("Ferrari", 24),
                new Car("Porsche", 22),
            };
            Driver[] drivers = new Driver[]
            {
                new Driver("Bob", 9),
                new Driver("Greg", 8),
                new Driver("Jill", 9),
                new Driver("Anne", 10),
            };

            Car firstCar = new Car();
            Car secondCar = new Car();
            Driver firstDriver = new Driver();
            Driver secondDriver = new Driver();

            Console.WriteLine("Enter car no.1");
            LoadCarsExceptUsed(cars, firstCar);
            int selectionFirstCar = IsValidSelectedCar(Console.ReadLine(), cars, firstCar, secondCar);
            while (selectionFirstCar == 0)
            {
                Console.WriteLine("Select a valid car");
                LoadCarsExceptUsed(cars, firstCar);
                selectionFirstCar = IsValidSelectedCar(Console.ReadLine(), cars, firstCar, secondCar);
            }
            firstCar = cars[selectionFirstCar - 1];

            Console.WriteLine("Enter driver no.2");
            LoadDriversExceptUsed(drivers, firstDriver);
            int selectionFirstDriver = IsValidSelectedDriver(Console.ReadLine(), drivers, firstDriver, secondDriver);
            while (selectionFirstDriver == 0)
            {
                Console.WriteLine("Select a valid driver");
                LoadDriversExceptUsed(drivers, firstDriver);
                selectionFirstDriver = IsValidSelectedDriver(Console.ReadLine(), drivers, firstDriver, secondDriver);
            }
            firstDriver = drivers[selectionFirstDriver - 1];

            Console.WriteLine("Enter car no.2");
            LoadCarsExceptUsed(cars, firstCar);
            int selectionSecondCar = IsValidSelectedCar(Console.ReadLine(), cars, firstCar, secondCar);
            while(selectionSecondCar == 0)
            {
                Console.WriteLine("Select a valid car");
                LoadCarsExceptUsed(cars, firstCar);
                selectionSecondCar = IsValidSelectedCar(Console.ReadLine(), cars, firstCar, secondCar);
            }
            secondCar = cars[selectionSecondCar - 1];

            Console.WriteLine("Enter driver no.2");
            LoadDriversExceptUsed(drivers, firstDriver);
            int selectionSecondDriver = IsValidSelectedDriver(Console.ReadLine(), drivers, firstDriver, secondDriver);
            while(selectionSecondDriver == 0)
            {
                Console.WriteLine("Select a valid driver");
                LoadDriversExceptUsed(drivers, firstDriver);
                selectionSecondDriver = IsValidSelectedDriver(Console.ReadLine(), drivers, firstDriver, secondDriver);
            }
            secondDriver = drivers[selectionSecondDriver - 1];

            firstCar.Driver = firstDriver;
            secondCar.Driver = secondDriver;

            RaceCars(firstCar, secondCar);

        }
        static int IsValidSelectedDriver(string userInput, Driver[] driverArray, Driver firstDriver, Driver secondDriver)
        {
            bool isValidSelection = int.TryParse(userInput, out int selection);
            if (isValidSelection && selection > 0 && selection < 5)
            {
                secondDriver = driverArray[selection - 1];
                if (firstDriver.Name == secondDriver.Name)
                {
                    return 0;
                }
                else
                {
                    return selection;
                }

            }
            else
            {
                return 0;
            };
        }
        static int IsValidSelectedCar(string userInput, Car[] carArray, Car firstCar, Car secondCar)
        {
            bool isValidSelection = int.TryParse(userInput, out int selection);
            if (isValidSelection && selection > 0 && selection < 5)
            {
                secondCar = carArray[selection - 1];
                if(firstCar.Model == secondCar.Model)
                {
                    return 0;
                }
                else
                {
                    return selection;
                }
            }
            else
            {
                return 0;
            }
        }
        static void LoadDriversExceptUsed(Driver [] driverArray, Driver firstDriver)
        {
            for (int i = 0; i < driverArray.Length; i++)
            {
                if (driverArray[i].Name == firstDriver.Name)
                {
                    continue;
                }
                Console.WriteLine($"#{i + 1}: {driverArray[i].Name}, Skill: {driverArray[i].Skill}");
            }
        }
        static void LoadCarsExceptUsed(Car[] carArray, Car firstCar)
        {
            for (int i = 0; i < carArray.Length; i++)
            {
                if (carArray[i].Model == firstCar.Model)
                {
                    continue;
                }
                Console.WriteLine($"#{i + 1}: {carArray[i].Model}, Speed: {carArray[i].Speed}");
            }
        }
        static void RaceCars(Car firstCar, Car secondCar)
        {
            int firstCarSpeed = firstCar.CalculateSpeed();
            int secondCarSpeed = secondCar.CalculateSpeed();

            if (firstCarSpeed > secondCarSpeed)
            {
                Console.WriteLine($"{firstCar.Driver.Name} won the race driving a {firstCar.Model}. They were going {firstCarSpeed}");
            }
            else if (firstCarSpeed < secondCarSpeed)
            {
                Console.WriteLine($"{secondCar.Driver.Name} won the race driving a {secondCar.Model}. They were going {secondCarSpeed}");
            }
            else
            {
                Console.WriteLine($"What a close race by {firstCar.Driver.Name} and {secondCar.Driver.Name} it's A TIE! ");
            }
        }
    }
}