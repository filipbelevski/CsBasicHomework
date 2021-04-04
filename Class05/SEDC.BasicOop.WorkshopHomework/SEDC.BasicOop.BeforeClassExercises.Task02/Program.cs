using System;

namespace SEDC.BasicOop.WorkshopHomework.Task02_Task03
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(IsPalindrome("Radar"));

            int[] numbersArray = new int[] { 14, 3, -1, 19, 23, 35, 5 };
            int biggestNumber = BiggestNumber(numbersArray);

            Console.WriteLine($"The biggest number is {biggestNumber}");

        }

        static string IsPalindrome(string word)
        {
            string temp = "";
            string wordToLower = word.ToLower();

            for(int i = wordToLower.Length - 1; i >= 0; i--)
            {
                temp += word[i];
            }

            if (word == temp)
            {
                return "It's a palindrome";
            }
            else
            {
                return "It's not a palindrome";
            }
            
        }
        //Create a function which returns the greatest value stored in an array of real numbers which is specified as parameter.
        static int BiggestNumber(int[] numbersArray)
        {
            int biggestNumber = numbersArray[0];
            for (int i = 0; i < numbersArray.Length; i++)
            {
                if (numbersArray[i] > biggestNumber)
                {
                    biggestNumber = numbersArray[i];
                }
            }
            return biggestNumber;
        }

        
    }

    
}
