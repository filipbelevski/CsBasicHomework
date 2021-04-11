using System;
using SEDC.BasicOop.Class07.Exercises.Domain;
using SEDC.BasicOop.Class07.Exercises.Domain.Classes;

namespace SEDC.BasicOop.Class07.Exercises.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee filip = new Employee("Filip", "Belevski", Role.Sales);

            filip.PrintInfo();
            Console.WriteLine(filip.GetSalary());

            SalesPerson Bob = new SalesPerson("Bob", "Bobski", Role.Sales, 235);

            Manager SonjaOdTAT = new Manager("Sonja", "TAT", Role.Manager, 3000);

            SonjaOdTAT.AddBonus(100000.25);
            Console.WriteLine(SonjaOdTAT.GetSalary());
            
        }
    }
}
