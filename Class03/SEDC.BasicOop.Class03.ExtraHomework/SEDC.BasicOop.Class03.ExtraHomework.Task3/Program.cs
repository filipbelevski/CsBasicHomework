using System;

namespace SEDC.BasicOop.Class03.ExtraHomework.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program, which will be calculating the product of the digits of an input number.

            Console.WriteLine("Please enter a number");

            bool isValidInput = int.TryParse(Console.ReadLine(), out int input);

            if(isValidInput)
            {
                int result = 1;
                while(input != 0)
                {
                    int digit = input % 10;
                    input = input / 10;

                    result *= digit;
                }

                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Please enter a valid input");
            }
                




        }
    }
}
