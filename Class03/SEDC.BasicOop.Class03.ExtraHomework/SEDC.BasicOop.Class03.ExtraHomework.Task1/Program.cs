using System;

namespace SEDC.BasicOop.Class03.ExtraHomework.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that will print out all numbers from the range 1 - N(N is input from keyboard, N > 2) that divide with 3.

            Console.WriteLine("Please enter a number bigger than 2");
            bool isValidInput = int.TryParse(Console.ReadLine(), out int input);

            if (isValidInput && input > 2)
            {
                for (int i = 0; i < input; i++)
                {
                    if (i % 3 == 0)
                    {
                        Console.WriteLine(i + " divides with 3");
                    }
                }
            }
            else
            {
                Console.WriteLine("Please enter a number bigger than 2");
            }
        }
    }
}
