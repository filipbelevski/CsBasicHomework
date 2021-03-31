using System;

namespace SEDC.BasicOop.Class03.ExtraHomework.Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that will find out the sum of all odd numbers in the range 1 - N(N is input from keyboard).
            Console.WriteLine("Please enter the number to find out the sum of all odd numbers in the range 1 to Input");

            int input = Convert.ToInt32(Console.ReadLine());

            int result = 0;
            for (int i = 1; i <= input; i ++)
            {
                if(i % 2 != 0)
                {
                    result += i;
                }
            }
            Console.WriteLine("The sum of the even numbers from 1 to " + input + " is: " + result);

        }
    }
}
