using System;

namespace SEDC.BasicOop.WorkshopHomework.Task07
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a function to find the number of times a substring appears in a given string.

            string string1 = "Find the number of times a substring appears in a given string, string, subababastring, string string string aaron aaron";
            string word = "Aaron";
            Console.WriteLine(NumberOfTimesASubstringAppears(string1, word));
        }

        static int NumberOfTimesASubstringAppears(string sentence, string word)
        {
            int startIndex = -1;
            int numberOfStrings = 0;
            string parsedWord = word.ToLower();
            string parsedSentence = sentence.ToLower();
            do
            {
                startIndex = parsedSentence.IndexOf(parsedWord, startIndex + 1); // string not found - returns -1 ; otherwise returns 0 based index;
                                                                                 // startIndex +1 so we can continue from Length(startIndex)+1;
                if (startIndex != -1)
                {
                    numberOfStrings++;
                }

            } while (startIndex != -1);


            return numberOfStrings;
        }
    }
}
