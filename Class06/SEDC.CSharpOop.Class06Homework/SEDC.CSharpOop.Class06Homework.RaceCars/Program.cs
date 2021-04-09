using SEDC.CSharpOop.Class06Homework.RaceCars.MyClasses;
using System;


namespace SEDC.CSharpOop.Class06Homework.RaceCars
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        // RaceApp Core
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

            // initializing classes to store car and driver obj
            Car firstCar = new Car();
            Car secondCar = new Car();
            Driver firstDriver = new Driver();
            Driver secondDriver = new Driver();
            // initializing counters and userInput, so we can dynamically change the choice #; car #1, driver #2;
            int carPrompt = 1;
            int driverPrompt = 1;
            int userCarChoiceInput = 0;
            int userDriverChoiceInput = 0;
            
            // propmpt user car choice and check if userInput is Valid//
            PromptUserCarChoice(carPrompt, cars, firstCar);
            userCarChoiceInput = ReadUserChoiceAndValidate(Console.ReadLine(), cars);
            while (userCarChoiceInput == 0) // Validation returns 0 if invalid, else we get the valid userInput and set properties to the car object
            {
                PromptUserCarChoice(carPrompt, cars, firstCar);
                userCarChoiceInput = ReadUserChoiceAndValidate(Console.ReadLine(), cars);
                firstCar = UserCarChoice(cars, userCarChoiceInput);
            }
            carPrompt++;
            //propmpt user driver choice and check if userInput is Valid//
            PromptUserDriverChoice(driverPrompt, drivers, firstDriver);
            userDriverChoiceInput = ReadUserChoiceAndValidateDriver(Console.ReadLine(), drivers); 
            while (userDriverChoiceInput == 0) //Validation returns 0 if invalid, else we get the valid userInput and set properties to the Driver object
            {
                PromptUserDriverChoice(driverPrompt, drivers, firstDriver);
                userDriverChoiceInput = ReadUserChoiceAndValidateDriver(Console.ReadLine(), drivers);
            }
            firstDriver = UserDriverChoice(drivers, userDriverChoiceInput);
            firstCar.Driver = firstDriver;
            driverPrompt++;

            PromptUserCarChoice(carPrompt, cars, firstCar);
            userCarChoiceInput = ReadUserChoiceAndValidate(Console.ReadLine(), cars);
            while(userCarChoiceInput == 0)
            {
                PromptUserCarChoice(carPrompt, cars, firstCar);
                int tempInput = ReadUserChoiceAndValidate(Console.ReadLine(), cars);
                secondCar = UserCarChoice(cars, tempInput);
                if(CarInUse(firstCar, secondCar))
                {
                    userCarChoiceInput = 0;
                }
            }

            PromptUserDriverChoice(driverPrompt, drivers, firstDriver);
            userDriverChoiceInput = ReadUserChoiceAndValidateDriver(Console.ReadLine(), drivers);
            while (userDriverChoiceInput == 0)
            {
                PromptUserDriverChoice(driverPrompt, drivers, firstDriver);
                int tempInput = ReadUserChoiceAndValidateDriver(Console.ReadLine(), drivers);
                if(tempInput == userDriverChoiceInput)
                {
                    userDriverChoiceInput = 0;
                }
            }
            secondDriver = UserDriverChoice(drivers, userDriverChoiceInput);
            secondCar.Driver = secondDriver;


            RaceCars(firstCar, secondCar);

        }
        // Methods For RaceApp
        static void PromptUserDriverChoice(int counter, Driver[]driverArray, Driver someDriver)
        {
            Console.WriteLine($"Select driver no.{counter}");
            LogDrivers(driverArray, someDriver);
        }
        static void PromptUserCarChoice (int counter, Car[] carArray, Car someCar)
        {
            Console.WriteLine($"Select car no.{counter}");
            LogCars(carArray, someCar);
        }
        static bool CarInUse (Car firstCar, Car secondCar)
        {
            if (firstCar.Model == secondCar.Model)
            {
                return true;
            }
            else
            {

            return false;
            }
        }
        static void LogCars (Car[] carArray, Car firstCar)
        {
            for(int i = 0; i < carArray.Length; i++)
            {
                if (carArray[i].Model == firstCar.Model)
                {
                    continue;
                }
                Console.WriteLine($"{i+1}: {carArray[i].Model}");
            }
        }
        static void LogDrivers (Driver[] driverArray, Driver firstDriver)
        {
            for (int i = 0; i < driverArray.Length; i++)
            {
                if (driverArray[i].Name == firstDriver.Name)
                {
                    continue;
                }
                Console.WriteLine($"{i+1}: {driverArray[i].Name}");
            }
        }
        static int ReadUserChoiceAndValidateDriver(string userInput, Driver[] driverArray)
        {
          
            bool isValidInput = int.TryParse(userInput, out int userChoice);

            if (isValidInput && userChoice <= driverArray.Length && userChoice > 0)
            {
                return userChoice;
            }

            return 0;

        }

        static int ReadUserChoiceAndValidate(string userInput, Car[] carArray)
        {
            bool isValidInput = int.TryParse(userInput, out int userChoice);

            if (isValidInput && userChoice <= carArray.Length && userChoice > 0)
            {
                return userChoice;
            }

            return 0;
        }
        static Driver UserDriverChoice(Driver[] driverArray, int userInput)
        {
            Driver driverChoice = driverArray[userInput - 1];

            return driverChoice;
        }
        static Car UserCarChoice(Car[] carArray, int userInput)
        {
            Car carChoice = carArray[userInput - 1];

            return carChoice;
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
