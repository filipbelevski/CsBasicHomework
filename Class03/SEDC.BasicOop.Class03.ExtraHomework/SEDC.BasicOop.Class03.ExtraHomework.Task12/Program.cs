using System;

namespace SEDC.BasicOop.Class03.ExtraHomework.Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a short program that prints each number from 1 to 100 on a new line.
            //For each number that is divided by 3 print “Fizz” instead of the number.
            //For each number that is divided by 5 print “Buzz” instead of the number.
            //For each number that is divided by 3 and 5 print “FizzBuzz” instead of the number.

            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else 
                    {
                        Console.WriteLine("Fizz");
                    }
                }
                else {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
