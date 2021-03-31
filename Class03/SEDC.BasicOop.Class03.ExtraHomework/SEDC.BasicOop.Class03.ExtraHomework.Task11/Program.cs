using System;

namespace SEDC.BasicOop.Class03.ExtraHomework.Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that will print out all two-digit numbers, which have the first digit greater than the second digit.

            for (int i = 10; i < 99; i++) {
                int secondDigit = i % 10;
                int firstDigit = i / 10;

                if(firstDigit > secondDigit)
                {
                    Console.WriteLine(i);
                }
                            
            }
        }
    }
}
