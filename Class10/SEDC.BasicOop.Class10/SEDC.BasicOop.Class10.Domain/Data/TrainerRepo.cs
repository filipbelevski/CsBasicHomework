using System;
using System.Collections.Generic;
using System.Text;
using SEDC.BasicOop.Class10.Domain.Models;
using System.Linq;

namespace SEDC.BasicOop.Class10.Domain.Data
{
    public class TrainerRepo
    {
        public List<Student> ReturnAllStudents()
        {
            return InMemoryDataBase.Students;
        }
        public List<Subject> ReturnAllSubjects()
        {
            return InMemoryDataBase.Subjects;
        }
        public List<Subject> ReturnStudentSubjects(int studentByIndex)
        {
            return InMemoryDataBase.Students[studentByIndex].Subjects;
        }
    }
}
