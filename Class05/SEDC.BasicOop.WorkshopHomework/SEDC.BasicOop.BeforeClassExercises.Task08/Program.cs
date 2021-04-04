using System;

namespace SEDC.BasicOop.WorkshopHomework.Task08
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a function to take one parameter n and calculate what day of the week is n days from this moment.
            
            Console.WriteLine(GetDayOfWeek(10));

            Console.ReadLine();
        }

        static string GetDayOfWeek (int number)
        {
            DateTime today = DateTime.Now;
            DateTime daysFromToday = today.AddDays(number);
            
            return daysFromToday.DayOfWeek.ToString();
        }
    }
}
