using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SEDC.BasicOop.Class10.Domain.Models;

namespace SEDC.BasicOop.Class10.Domain.Data
{
    public class StudentRepo
    {
        public Student ReturnCurrentStudent(Student currentStudent)
        {
            return InMemoryDataBase.Students.First(student => student == currentStudent);
        }
    }
}
