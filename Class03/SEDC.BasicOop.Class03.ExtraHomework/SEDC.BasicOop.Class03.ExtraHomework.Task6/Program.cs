using System;

namespace SEDC.BasicOop.Class03.ExtraHomework.Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that will find out the sum of all numbers that divide 5 in the range 1-N (N is input from keyboard).

            Console.WriteLine("Please enter a  number");

            bool isValidNumber = int.TryParse(Console.ReadLine(), out int input);

            if(isValidNumber)
            {
                int result = 0;
                for(int i = 0; i <= input; i ++)
                {
                    if(i % 5 == 0)
                    {
                        result += i;
                    }
                }
                Console.WriteLine(result);
            }
        }
    }
}
