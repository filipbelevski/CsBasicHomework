using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.BasicOop.Class07.Exercises.Domain.Classes
{
    public class SalesPerson : Employee
    {
        public SalesPerson(string firstName, string lastName, Role role, double successRevenue) : base(firstName, lastName, role)
        {
            this.Salary = 500;
            this.SuccessSaleRevenue = successRevenue;
        }
        private double SuccessSaleRevenue { get; set; }


        public void GetInfoForSales()
        {
            Console.WriteLine($"{Salary} of sales person");
        }
        
        public void AddSalesRevenue (double successValue)
        {

            this.SuccessSaleRevenue = successValue;
        }
        public override double GetSalary()
        {
            double bonus = 0;

            if (this.SuccessSaleRevenue <= 2000)
            {
                bonus += 500;
            }
            if (this.SuccessSaleRevenue > 2000 && this.SuccessSaleRevenue <= 5000)
            {
                bonus += 1000;
            }
            if (this.SuccessSaleRevenue > 5000)
            {
                bonus += 1500;
            }

            return base.GetSalary() + bonus;
        }
    }
}
