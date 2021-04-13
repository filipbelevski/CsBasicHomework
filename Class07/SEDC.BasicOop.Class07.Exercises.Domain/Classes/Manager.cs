using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.BasicOop.Class07.Exercises.Domain.Classes
{
    public class Manager : Employee
    {
        public Manager(string firstName, string lastName, Role role, double salary, Department department) : base(firstName, lastName, role) // base: (firstName, lastName)
        {
            this.Salary = salary; // since exercises states create a constructor that sets ALL THE PROPERTIES, 
            // Note: I think it would be better if role is default , this.Role = Role.Manager, and we create a new constructor for employee that doesn't require us to add a role...
            this.Department = department;
        }
        public Department Department { get; set; }
        private double Bonus { get; set; }

        public void AddBonus(double bonus)
        {
            this.Bonus += bonus;
        }
        public override double GetSalary()
        {
            return base.GetSalary() + this.Bonus;

        }
    }
}
