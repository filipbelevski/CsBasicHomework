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
            Console.WriteLine("Please enter the seocnd number");
            string secondUserInput = Console.ReadLine();

            bool isValidFirstNumber = double.TryParse(firstUserInput, out double firstNumber);
            bool isValidSecondNumber = double.TryParse(secondUserInput, out double secondNumber);

            if (isValidFirstNumber && isValidSecondNumber)
            {
                Console.WriteLine("First Number: " + secondNumber);
                Console.WriteLine("Second Number: " + firstNumber);
            }
            else
            {
                Console.WriteLine("Please enter valid numbers");
            }
        }
    }
}
