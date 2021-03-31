using System;

namespace SEDC.BasicOop.Class03.ExtraHomework.Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that will find out the sum of all even numbers in the range 1 - N(N is input from keyboard).

            Console.WriteLine("Enter a number and find the sum of all even numbers from 1 to the number you have entered");

            bool isValidNumber = int.TryParse(Console.ReadLine(), out int input);

            if (isValidNumber)
            {
                int result = 0;
                for (int i = 0; i <= input; i++)
                {
                    if (i % 2 == 0)
                    {
                        result += i;
                    }
                }
                Console.WriteLine(result);
                Console.ReadLine();
            }
        }
    }
}
