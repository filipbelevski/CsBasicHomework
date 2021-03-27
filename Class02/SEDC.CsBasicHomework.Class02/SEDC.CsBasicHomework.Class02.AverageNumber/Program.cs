using System;

namespace SEDC.CsBasicHomework.Class02.AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Create new console application “AverageNumber” that takes four numbers as input to calculate and print the average.

               Test Data:
               Enter the First number: 10
               Enter the Second number: 15
               Enter the third number: 20
               Enter the four number: 30
               Expected Output:
               The average of 10, 15, 20 and 30 is: 18*/

            Console.WriteLine("Enter the First number: ");
            string userInput1 = Console.ReadLine();
            Console.WriteLine("Enter the Second number: ");
            string userInput2 = Console.ReadLine();
            Console.WriteLine("Enter the Third number: ");
            string userInput3 = Console.ReadLine();
            Console.WriteLine("Enter the Fourth number: ");
            string userInput4 = Console.ReadLine();

            bool isValidFirstInput = double.TryParse(userInput1, out double num1);
            bool isValidSecondInput = double.TryParse(userInput2, out double num2);
            bool isValidThirdInput = double.TryParse(userInput3, out double num3);
            bool isValidFourthInput = double.TryParse(userInput4, out double num4);

            if (isValidFirstInput && isValidSecondInput && isValidThirdInput && isValidFourthInput)
            {
                double average = (num1 + num2 + num3 + num4) / 4;

                Console.WriteLine("The average of " + num1 + ", "+ num2 + ", " + num3+ ", " + num4 + " is: " + average);
            }
            else
            {
                Console.WriteLine("Please enter valid numbers");
            }

        }
    }
}
