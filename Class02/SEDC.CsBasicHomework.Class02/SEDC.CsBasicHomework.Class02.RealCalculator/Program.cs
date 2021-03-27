using System;

namespace SEDC.CsBasicHomework.Class02.RealCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create new console application “RealCalculator” that takes two numbers from the input and asks what operation would the user want to be done ( +, - , * , / ). Then it returns the result
            /*Test Data:
            Enter the First number: 10
            Enter the Second number: 15
            Enter the Operation: +
            Expected Output:
            The result is: 25*/

            Console.Write("Please enter the first number: ");
            string userInput1 = Console.ReadLine();
            Console.WriteLine("Please enter the second number: ");
            string userInput2 = Console.ReadLine();
            Console.WriteLine("Please enter the Operation: ");
            string operation = Console.ReadLine();

            bool isValidFirstNum = double.TryParse(userInput1, out double num1);  // used double in case we get an output with decimals
            bool isValidSecondNum = double.TryParse(userInput2, out double num2);

            // operators
            string sum = "+";
            string subtract = "-";
            string divide = "/";
            string multiply = "*";

            bool isValidOperation = operation == sum || operation == subtract || operation ==  divide || operation ==  multiply;


            if (isValidFirstNum && isValidSecondNum)
            {
                if (isValidOperation)
                {
                    if (operation == sum)
                    {
                        double result = num1 + num2;
                        Console.WriteLine("The result is " + result);
                    }
                    if (operation == subtract)
                    {
                        double result = num1 - num2;
                        Console.WriteLine("The result is " + result);
                    }   
                    if (operation == divide)
                    {
                        double result = num1 / num2;
                        Console.WriteLine("The result is " + result);
                    }
                    if (operation == multiply)
                    {
                        double result = num1 * num2;
                        Console.WriteLine("The result is " + result);
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid operation ( +, -, / or * ");
                }
            }
            else
            {
                Console.WriteLine("Please enter valid numbers");
            }

            Console.ReadLine();


            /*            if (isValidFirstNum && isValidSecondNum)
                        {
                            switch (operation)
                            {
                                case "+":
                                    Console.WriteLine("The result is" + (num1 + num2));
                                    break;
                                case "-":
                                    Console.WriteLine("The reuslt is" + (num1 - num2));
                                    break;
                                case "*":
                                    Console.WriteLine("The reuslt is" + (num1 * num2));
                                    break;
                                case "/":
                                    Console.WriteLine("The reuslt is" + (num1 / num2));
                                    break;
                                default:
                                    Console.WriteLine("Please enter a valid operation( +, -, / or * ");
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Please enter valid numbers");
                        }*/

        }
    }
}
