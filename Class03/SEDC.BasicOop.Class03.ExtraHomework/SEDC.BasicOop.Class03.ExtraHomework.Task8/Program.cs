using System;

namespace SEDC.BasicOop.Class03.ExtraHomework.Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*            Write a program that will read two arrays from console input.Then the program has to make a comparison of the arrays and determine whether they are equal or not.
             *          { 1, 2, 3, 4 } == { 1, 2, 3, 4 }
                        { 1, 2, 3, 4 } != { 2, 1, 3, 4 }*/

            Console.WriteLine("Please enter four numbers and store them in the first Array, press enter after each number ");
            int[] firstArray = new int[4];
            int[] secondArray = new int[4];

            for(int i = 0; i < firstArray.Length; i++)
            {
                int num = Convert.ToInt32(Console.ReadLine());

                firstArray[i] = num;
            }
            Console.WriteLine("The first array consists of: " + firstArray[0] + " " + firstArray[1] + " " + firstArray[2] + " " + firstArray[3]);

            Console.WriteLine("Please enter four numbers and store them in the second Array, press enter after each number ");

            for (int i = 0; i < secondArray.Length; i++)
            {
                int num = Convert.ToInt32(Console.ReadLine());

                secondArray[i] = num;
            }

            for (int i = 0, j = 0; i < firstArray.Length && j < firstArray.Length; i++, j++)
            {
                if(firstArray[i] != secondArray [j])
                {
                    Console.WriteLine("The arrays are not equal");
                    break;
                }
                else
                {
                    Console.WriteLine("The arrays are equal");
                    return;
                }
            }

        }
    }
}
