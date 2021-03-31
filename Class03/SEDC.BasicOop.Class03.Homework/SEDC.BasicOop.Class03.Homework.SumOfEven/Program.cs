using System;

namespace SEDC.BasicOop.Class03.Homework.SumOfEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[6];

            Console.WriteLine("Enter int no1: ");
            bool num1 = int.TryParse(Console.ReadLine(), out int inputNumber1);
            Console.WriteLine("Enter int no2: ");     
            bool num2 = int.TryParse(Console.ReadLine(), out int inputNumber2);
            Console.WriteLine("Enter int no3: ");
            bool num3 = int.TryParse(Console.ReadLine(), out int inputNumber3);
            Console.WriteLine("Enter int no4: ");
            bool num4 = int.TryParse(Console.ReadLine(), out int inputNumber4);
            Console.WriteLine("Enter int no5: ");
            bool num5 = int.TryParse(Console.ReadLine(), out int inputNumber5);
            Console.WriteLine("Enter int no6: ");
            bool num6 = int.TryParse(Console.ReadLine(), out int inputNumber6);

            if (num1 && num2 && num3 && num4 && num5 && num6)
            {
                numbers[0] = inputNumber1;
                numbers[1] = inputNumber2;
                numbers[2] = inputNumber3;
                numbers[3] = inputNumber4;
                numbers[4] = inputNumber5;
                numbers[5] = inputNumber6;
            }
            else
            {
                Console.WriteLine("Please enter valid inputs");
                return;
            }

            int result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {

                if (numbers[i] % 2 != 0)
                {
                    continue;
                }
                else
                {
                    result += numbers[i];
                }
            }
            Console.WriteLine("The result of the even numbers is: " + result);

            Console.ReadLine();
        }
    }
}
