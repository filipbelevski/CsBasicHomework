using System;

namespace SEDC.BasicOop.Class03.ExtraHomework.Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that will find out all numbers in the range[1 : 1000] that divide the product composed of their digits.*/

            for (int i = 10; i < 1000; i++)
            {
                int currentNumber = i;
                int result = 1;
                while (currentNumber != 0)
                {
                    int digits = currentNumber % 10;
                    currentNumber = currentNumber / 10;
                    result *= digits;
                }
             
                if (result == 0)
                {
                    continue;
                }
                if (i % result == 0)
                {
                    Console.WriteLine(i + ": The product of my digits is: " + result);
                }
            }
        }
    }
}
