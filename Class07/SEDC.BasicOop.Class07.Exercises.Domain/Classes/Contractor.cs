using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.BasicOop.Class07.Exercises.Domain.Classes
{
    public class Contractor : Employee
    {
        public Contractor (string firstName, string lastName, Role role, double workHours, int payPerHour, Manager responsibleManager) : base(firstName, lastName, role)
        {
            this.Workhours = workHours;
            this.PayPerHour = payPerHour;
            this.ResponsibleManager = responsibleManager;
        }
        public double Workhours { get; set; }
        public int PayPerHour { get; set; }
        public Manager ResponsibleManager { get; set; }

        public override double GetSalary()
        {
            this.Salary = this.Workhours * this.PayPerHour;
            return this.Salary;
        }
        public Department GetDepartment ()
        {
            return this.ResponsibleManager.Department;
        }
    }
}
