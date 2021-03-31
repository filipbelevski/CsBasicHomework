using System;

namespace SEDC.BasicOop.Class03.ExtraHomework.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that will print out all numbers in the range 1 - N(N is input from keyboard, N > 5) that divide 2 and 3.*/

            Console.WriteLine("Please enter a number higher than 5, to see which numbers divide with 2 and 3");

            bool isValidInput = int.TryParse(Console.ReadLine(), out int input);

            if (isValidInput && input > 5)
            {
               for(int i = 0; i <= input; i++)
                {
                    if(i % 2 == 0 && i % 3 == 0)
                    {
                        Console.WriteLine(i + " divides with 2 and 3");
                    }
                }
            }
            else
            {
                Console.WriteLine("Please enter valid input");
            }

            Console.ReadLine();

        }

    }
}
