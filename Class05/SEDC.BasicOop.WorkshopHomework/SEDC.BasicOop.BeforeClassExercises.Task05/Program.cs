using System;

namespace SEDC.BasicOop.WorkshopHomework.Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a function to read a sentence and replace lowercase characters by uppercase and vice-versa.
            Console.WriteLine("Enter a sentence and press enter to switch the lowercase and uppercase characters");
            string originalSentence = Console.ReadLine();
            string switchedSentence = SwitchCharacters(originalSentence);
            Console.WriteLine(switchedSentence);

        }

        static string SwitchCharacters(string sentence)
        {
            string temp = "";

            for (int i = 0; i < sentence.Length; i++)
            {
                if (char.IsLower(sentence[i]))
                {
                    temp += char.ToUpper(sentence[i]);
                }
                else
                {
                    temp += char.ToLower(sentence[i]);
                }

            }
            return temp;

        }
    }
}
