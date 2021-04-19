using SEDC.BasicOop.Class10.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SEDC.BasicOop.Class10.Domain.Data
{
    public class UserRepo
    {
        public Admin GetAdminByEmail(string email)
        {
            Admin admin = InMemoryDataBase.Admins.FirstOrDefault(admin => admin.Email == email);
            return admin;
        }
        public Student GetStudentByEmail(string email)
        {
            Student student = InMemoryDataBase.Students.FirstOrDefault(student => student.Email == email);
            return student;
        }
        public Trainer GetTrainerByEmail(string email)
        {
            Trainer trainer = InMemoryDataBase.Trainers.FirstOrDefault(trainer => trainer.Email == email);
            return trainer;
        }
    }
}
