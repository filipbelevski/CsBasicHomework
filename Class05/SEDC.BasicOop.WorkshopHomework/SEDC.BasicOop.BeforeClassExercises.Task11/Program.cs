using System;

namespace SEDC.BasicOop.WorkshopHomework.AgeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*           Make a method called AgeCalculator
                        The method will have one input parameter, your birthday date
                        The method should return your age
                        Show the age of a user after he inputs a date*/

            Console.WriteLine("Please enter your birthday format(mm-dd-yyyy)");

            bool isValidDate = DateTime.TryParse(Console.ReadLine(), out DateTime result);

            if (isValidDate)
            {
                Console.WriteLine(AgeCalculator(result));
            }
            else
            {
                Console.WriteLine("Enter a valid date format");
            }

        }

        static int AgeCalculator(DateTime userDob)
        {
            DateTime current = DateTime.Now;
            int currentDay = current.Day;
            int currentMonth = current.Month;
            int currentYear = current.Year;

            int userBirthYear = userDob.Year;
            int userMonth = userDob.Month;
            int userDay = userDob.Day;

            int age = currentYear - userBirthYear;

            if (userMonth > currentMonth)
            {
                age -= 1;
            }
            if (userMonth == currentMonth)
            {
                if (userDay > currentDay)
                {
                    age -= 1;
                }
            }

            return age;

        }
    }
}
