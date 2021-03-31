using System;

namespace SEDC.BasicOop.Class03.Homework.StudentGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentsG1 = new string[] { "Bob", "Jill", "Nancy", "Tracy", "Stacy" };
            string[] studentsG2 = new string[] { "Filip", "Trajan", "Damjan", "Marija", "Petko" };

            Console.WriteLine("Please enter the group number 1 or 2 to see members");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    for (int i = 0; i < studentsG1.Length; i++)
                    {
                        Console.WriteLine(studentsG1[i]);
                    }
                    break;
                case "2":
                    for (int i = 0; i < studentsG2.Length; i++)
                    {
                        Console.WriteLine(studentsG2[i]);
                    }
                    break;
                case "3":
                    Console.WriteLine("Please enter 1 or 2");
                    break;
            }
            Console.ReadLine();

        }
    }
}
