using System;

namespace SEDC.BasicOop.WorkshopHomework.Task01
{
    class Program
    {
        static void Main(string[] args)
        {           
            Console.WriteLine(CalculatePower(5, 3));
            GetStats(25);

            Console.ReadLine();
        }
        // calculate power Task:00;
        static int CalculatePower(int number, int power)
        {
            int result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= number;
            }
            return result;

        }
        // get stats for num Task01;
        static void GetStats (int num)
        {
            int value = num;
            int digits = 0;

            while(num > 0)
            {
                num = num / 10;
                digits++;
            }
            string isEven = "even";
            string isPositive = "positive";

            if(num % 2 != 0)
            {
                isEven = "odd";
            }
            if(num <0)
            {
                isPositive = "negative";
            }

            Console.WriteLine($"The number {value} is {digits} digit number, it's {isEven} and it's a {isPositive}");
        }

    }


}
