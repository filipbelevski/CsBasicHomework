using System;

namespace SEDC.BasicOop.WorkshopHomework.Task09
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a function to take one parameter n to display the date of past n years from current date and to tell what day it was.
            //The parameter should not be larger that 20.

            Console.WriteLine(GetDateAndDayFromYearsAgo(20));
            
            Console.ReadLine();
        }

        static string GetDateAndDayFromYearsAgo (int number)
        {
            if(number > 20)
            {
                return "We can only go back 20yrs";
            }

            DateTime currentDate = DateTime.Now;
            DateTime requestedDate = currentDate.AddYears(-(number));

            string formatedDate = string.Format("{0:dd-MM-yyyy}", requestedDate);
            string requestedDayOfWeek = requestedDate.DayOfWeek.ToString();

            return $"The date {number} years ago was {formatedDate}, and the day of the week was {requestedDayOfWeek}";
        }
    }
}
