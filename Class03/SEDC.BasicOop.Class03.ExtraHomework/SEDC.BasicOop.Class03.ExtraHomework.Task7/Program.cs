using System;

namespace SEDC.BasicOop.Class03.ExtraHomework.Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*            Write a program that will reverse the array {“a”,”b”,”c”,”d”}
                        so that the output is {“d”,“c”,“b”,“a”}. -Do NOT use reverse array method:)*/

            string[] initialArray = new string[] { "a", "b", "c", "d" };
            string[] reveresedArray = new string[4];

            for (int i = 0, j = initialArray.Length -1; i < initialArray.Length && j >= 0; i++ , j--)
            {
                reveresedArray[i] = initialArray[j];
            }

            for(int k = 0; k < reveresedArray.Length; k++)
            {
                Console.WriteLine(reveresedArray[k]);
            }

        }
    }
}
