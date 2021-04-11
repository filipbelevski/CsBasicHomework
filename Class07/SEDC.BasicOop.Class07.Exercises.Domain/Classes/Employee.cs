using SEDC.BasicOop.Class07.Exercises.Domain.Classes;
using System;

namespace SEDC.BasicOop.Class07.Exercises.Domain
{
    public class Employee
    {
        // manager only constructor 
        // public Employee (string firstName, string lastName)
        public Employee (string firstName, string lastName, Role role)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Role = role;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }
        protected double Salary { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"{FirstName}, {LastName}, Salary: {Salary}");
        }
        public virtual double GetSalary ()
        {
            return Salary;
        }
    }
}
