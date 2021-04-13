using System;
using SEDC.BasicOop.Class07.Exercises.Domain;
using SEDC.BasicOop.Class07.Exercises.Domain.Classes;

namespace SEDC.BasicOop.Class07.Exercises.App
{
    class Program
    {
        static void Main(string[] args)
        {

            Manager SonjaOdTAT = new Manager("Sonja", "TAT", Role.Manager, 3000, Department.Sales);
            Manager bob = new Manager("Bob", "Bobski", Role.Manager, 3100, Department.Merch);

            SonjaOdTAT.AddBonus(100000.25);
            Console.WriteLine($"The salary of Sonja od TAT is: " + SonjaOdTAT.GetSalary());
            Employee[] company = new Employee[]
            {
                new Contractor("Filip", "Belevski", Role.Sales, 7.5, 12, SonjaOdTAT),
                new Contractor("Trajan", "Stevkovski", Role.Other, 7.6, 12, bob),
                bob, // manager
                SonjaOdTAT, // manager
                new SalesPerson("Damjan", "Stojanovski", Role.Sales, 150.2)
            };
            CEO ron = new CEO("Ron", "Ronski", Role.CEO, company, 60);
            ron.AddSharesPrice(500);
            Console.WriteLine($"Salary of CEO is {ron.GetSalary()}");
            ron.PrintInfo();
            ron.PrintEmployees();

        }
    }
}
