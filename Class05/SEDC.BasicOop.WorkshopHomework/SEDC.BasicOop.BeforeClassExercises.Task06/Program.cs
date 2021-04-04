using System;

namespace SEDC.BasicOop.WorkshopHomework.Task06
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a function to check whether a character is an alphabet or not and if so, go to check for the case (upper or lower).
            IsAnAlphabet('.');

        }

        static void IsAnAlphabet(char ch)
        {
            if (char.IsLetter(ch))
            {
                if (char.IsUpper(ch))
                {
                    Console.WriteLine(ch + " is an upper case letter");
                    return;
                }
                Console.WriteLine(ch + " is a lower case letter");
            }
            else
            {
                Console.WriteLine("Not an alphabet");
            }
        }
    }
}
