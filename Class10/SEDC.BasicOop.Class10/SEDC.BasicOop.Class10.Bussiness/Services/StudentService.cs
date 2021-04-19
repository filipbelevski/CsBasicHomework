
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SEDC.BasicOop.Class10.Domain.Data;
using SEDC.BasicOop.Class10.Domain.Models;

namespace SEDC.BasicOop.Class10.Bussiness.Services
{
    public class StudentService
    {
        public void ListSubjects(Student student)
        {
            Console.WriteLine("Subjects that you are currently listening: ");
            foreach(KeyValuePair<Subject, int> subject in student.Grades)
            {
                Console.WriteLine($"{subject.Key.Name} Grade: {subject.Value}");
            }
        }
    }
}
