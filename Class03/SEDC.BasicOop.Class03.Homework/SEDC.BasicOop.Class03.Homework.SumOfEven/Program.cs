using System;

namespace SEDC.BasicOop.Class03.Homework.SumOfEven
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[6];

            int result = 0;
            for (int i = 0; i < numbers.Length; i ++)
            {
                int number = int.Parse(Console.ReadLine());
                numbers[i] = number;

                if (numbers[i] % 2 == 0)
                {
                    result += numbers[i];
                }
            }

            Console.WriteLine("The result of the even numbers is: " + result );

            Console.ReadLine();
        }
    }
}
