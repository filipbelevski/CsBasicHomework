using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.BasicOop.Class07.Exercises.Domain.Classes
{
    public class CEO : Employee
    {
        public CEO(string firstName, string lastName, Role role, Employee[] employees, int sharesProperty) : base(firstName, lastName, role)
        {
            this.Employees = employees;
            this.SharesProperty = sharesProperty;
            /*this.Salary = 1500;*/ // 
        }
        public int SharesProperty { get; set; }
        private double SharesPrice { get; set; }
        public Employee[] Employees { get; set; }

        public double AddSharesPrice(double sharesPrice)
        {
            return this.SharesPrice = sharesPrice;
        }
        public void PrintEmployees()
        {
            for (int i = 0; i < Employees.Length; i++)
            {
                Console.WriteLine($"{Employees[i].FirstName} {Employees[i].LastName}");
            }
        }
        public override double GetSalary()
        {
            return base.GetSalary() + (SharesPrice * SharesProperty);
            // or 
            // return  this.Salary = SharesPrice * SharesProperty
            // since we never set the base salary and it returns 0 ... 
            // or default the CEO salary to 1500..

        }
    }
}


