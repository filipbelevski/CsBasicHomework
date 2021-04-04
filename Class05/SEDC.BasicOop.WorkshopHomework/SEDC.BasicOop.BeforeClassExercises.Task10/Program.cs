using System;

namespace SEDC.BasicOop.WorkshopHomework.Task10toTask12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a function that takes a number as an argument and returns an array of numbers counting down from this number to zero. Task 10;
            int num = 5;
            int[] theArr = CountDownToZero(num);

            foreach(int number in theArr)
            {
                Console.WriteLine(number);
            }

            //Create a function that takes an array and returns the difference between the biggest and smallest numbers. Task 11;
            //[10, 4, 1, 4, -10, -50, 32, 21] -> 82

            int[] dummyArray = new int[] { 10, 4, 1, 4, -10, -50, 32, 21 };

            Console.WriteLine("The difference between the smallest and biggest number in the array is: " + DifferenceBetweenBiggestAndSmallestNumberInArray(dummyArray));

            //Create a function that goes through the array, incrementing (+1) for each odd number and decrementing (-1) for each even number and returns that array.
            //[1, 2, 3, 4, 5] -> [2, 1, 4, 3, 6]
            int[] integerArray = new int[] { 1, 2, 3, 4, 5 };
            int[] newArrayOfIntegers = DecrementAndIncrementEvenAndOdd(integerArray);
            foreach (int integer in newArrayOfIntegers)
            {
                Console.WriteLine(integer);
            }

            Console.ReadLine();
        }


        static int[] CountDownToZero (int num)
        {
            int[] tempArr = new int[num];

            for(int i = num, j=0; i >= 0 && j < tempArr.Length; i--, j++)
            {
                tempArr[j] += i;
            }
            return tempArr;
            
        }
        static int DifferenceBetweenBiggestAndSmallestNumberInArray (int[] array)
        {
            int biggestNumber = array[0];
            int smallestNumber = array[0];

            for(int i = 0; i < array.Length; i++)
            {
                if(biggestNumber < array[i])
                {
                    biggestNumber = array[i];
                }
                if(smallestNumber > array[i])
                {
                    smallestNumber = array[i];
                }
            }
            return biggestNumber - smallestNumber;
        }

        //Create a function that goes through the array, incrementing (+1) for each odd number and decrementing (-1) for each even number and returns that array.

        static int[] DecrementAndIncrementEvenAndOdd (int[] array)
        {
            int[] tempArr = new int[0];
            for (int i = 0; i < array.Length; i++)
            {
                Array.Resize(ref tempArr, tempArr.Length + 1);
                if (array[i] % 2 == 0)
                {
                    tempArr[i] = array[i] - 1;
                }
                else { tempArr[i] = array[i] + 1; };
            }
            return tempArr;
        }

    }
}
