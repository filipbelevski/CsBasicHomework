using System;

namespace SEDC.CsBasicHomework.Class02.SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Create new console application “SwapNumbers”. Input 2 numbers from the console and then swap the values of the variables so that the first variable has the second value and the second variable the first value. Please find example below:

            Test Data:
            Input the First Number: 5
            Input the Second Number: 8
            Expected Output:
            After Swapping:
            First Number: 8
            Second Number: 5 */

            Console.WriteLine("Please enter the first number");
            string firstUserInput = Console.ReadLine();
            Console.WriteLine("Please enter the second number");
            string secondUserInput = Console.ReadLine();

            double firstNumber;
            double secondNumber;

            // if true assign a value to the firstNumber and secondNumber 
            bool isValidFirstNumber = double.TryParse(firstUserInput, out firstNumber);
            bool isValidSecondNumber = double.TryParse(secondUserInput, out secondNumber);

            if (isValidFirstNumber && isValidSecondNumber)
            {
                // assign new value to another variable to "hold" the value so we can change it later
                double num1 = firstNumber;
                double num2 = secondNumber;

                // switch the values
                firstNumber = num2;
                secondNumber = num1;
                Console.WriteLine("1st = " + firstNumber);
                Console.WriteLine("2nd = " + secondNumber);
            }
            else
            {
                Console.WriteLine("Please enter valid numbers");
            }
        }
    }
}
