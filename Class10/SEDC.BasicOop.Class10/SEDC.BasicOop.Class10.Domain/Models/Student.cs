using System;
using System.Collections.Generic;
using System.Text;
using SEDC.BasicOop.Class10.Domain.Enumerations;

namespace SEDC.BasicOop.Class10.Domain.Models
{
    public class Student: User
    {
        public Student() { }
        public Student(int id, string fName, string lName, string email, string password)
            : base(id, fName, lName, email, password, Role.Student)
        {
        }
        public Dictionary<Subject, int> Grades { get; set; }
        public List<Subject> Subjects { get; set; }
    }
}

