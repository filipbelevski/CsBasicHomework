using System;

namespace SEDC.BasicOop.WorkshopHomework.Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            /*          Create two functions that calculates the amount of numeric digits and vowels(samoglaski) that a text string contains.
                        It will accept one parameter parameter: the string that we want to search,
                        Function 1 should return the number of digits, function 2 should return the number of vowels.Do not name them function1 and 2 :)*/
            string word = "McLarenF1";
            int numberOfDigits = CalculateDigitsInString(word);
            int numberOfVowels = CalculateVowelsInString(word);

            Console.WriteLine($"The word {word} contains {numberOfDigits} digits and contains {numberOfVowels} vowels. \"note sometimes Y is a vowel and result may vary\"");
        }
        static int CalculateDigitsInString (string word)
        {
            int result = 0;
            for (int i = 0; i < word.Length; i ++)
            {
                bool isAValidNumber = char.IsDigit(word[i]);
                if(isAValidNumber)
                {
                    result++;
                }
            }
            return result;
        }

        static int CalculateVowelsInString (string word)
        {
            int result = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o'|| word[i] == 'u')
                {
                    result++;
                }
            }
            return result;
        }
    }
}
