using System;

namespace SEDC.BasicOop.Class03.ExtraHomework.Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that will find all numbers in between 1 and 1000, that divide the sum composed of their digits.*/

            for (int i = 1; i < 1000; i++)
            {
              int currentNumber = i;
              int result = 0;
              while(currentNumber != 0)
                {
                    int digits = currentNumber % 10;
                    currentNumber = currentNumber / 10;
                    result += digits;
                }
                if (i % result == 0)
                {
                    Console.WriteLine(i + " The result of digits is " + result);

                }
            }
        }
    }
}
