using SEDC.BasicOop.Class10.Domain.Models;
using System;
using System.Collections.Generic;

namespace SEDC.BasicOop.Class10.Domain
{
    public static class InMemoryDataBase
    {
        public static List<Admin> Admins { get; set; }
        public static List<Trainer> Trainers { get; set; }
        public static List<Student> Students { get; set; }
        public static List<Subject> Subjects { get; set; }
        static InMemoryDataBase()
        {
            Subjects = GenerateSubjects();
            Admins = GenerateAdmins();
            Trainers = GenerateTrainers();
            Students = GenerateStudents();
        }
        private static List<Subject> GenerateSubjects()
        {
            List<Subject> subjects = new List<Subject>
            {
                new Subject() { Name = "c# basic",
                IsOptional = false,
                NumberOfClasses = 10,
                EndOn = new DateTime(2021, 04, 20),
                StartOn =  new DateTime(2021, 04, 01)},
                new Subject() { Name = "c# advanced",
                IsOptional = false,
                NumberOfClasses = 10,
                EndOn = new DateTime(2021, 05, 20),
                StartOn =  new DateTime(2021, 05, 01)},
                new Subject() { Name = "javascript advanced",
                IsOptional = false,
                NumberOfClasses = 10,
                EndOn = new DateTime(2021, 03, 20),
                StartOn =  new DateTime(2021, 03, 01)},
                new Subject() { Name = "javascript basic",
                IsOptional = false,
                NumberOfClasses = 10,
                EndOn = new DateTime(2021, 02, 20),
                StartOn =  new DateTime(2021, 02, 01)},
                new Subject() { Name = "html",
                IsOptional = false,
                NumberOfClasses = 10,
                EndOn = new DateTime(2021, 01, 20),
                StartOn =  new DateTime(2021, 01, 01)},
                new Subject() { Name = "css",
                IsOptional = false,
                NumberOfClasses = 10,
                EndOn = new DateTime(2020, 12, 20),
                StartOn =  new DateTime(2020, 12, 01)},
            };
            return subjects;
        }
        private static List<Student> GenerateStudents()
        {

            List<Student> listOfStudents = new List<Student>
            {
                new Student(1, "Andjela", "Mitkova", "andmit@mail.com", "123asd")
                {
                    Grades = new Dictionary <Subject, int> () { { Subjects[2], 5}, { Subjects[3], 3}, { Subjects[4], 4 }  },
                    Subjects = new List<Subject> { Subjects[2], Subjects[3], Subjects[4] },
                },

                new Student(2, "Angel", "Jordanovski", "andjor@mail.com", "123asd") {
                    Grades = new Dictionary <Subject, int> () { { Subjects[2], 5}, { Subjects[3], 3}, { Subjects[5], 4 }  },
                    Subjects = new List<Subject> { Subjects[2], Subjects[3], Subjects[5] },
                },
                new Student(3, "Biljana", "Radevska", "bilrad@mail.com", "123asd")
                {
                    Grades = new Dictionary <Subject, int> () { { Subjects[2], 5}, { Subjects[3], 3}, { Subjects[4], 4 }  },
                    Subjects = new List<Subject> { Subjects[2], Subjects[3], Subjects[4] },
                },
                new Student(4, "Filip", "Belevski", "filbel@mail.com", "123asd")
                {
                    Grades = new Dictionary <Subject, int> () { { Subjects[1], 5}, { Subjects[3], 3}, { Subjects[4], 4 }  },
                    Subjects = new List<Subject> { Subjects[1], Subjects[3], Subjects[4] },
                },
                new Student(5, "Goran", "Stojanovski", "gorsto@mail.com", "123asd")
                {
                    Grades = new Dictionary <Subject, int> () { { Subjects[1], 5}, { Subjects[3], 3}, { Subjects[5], 4 }  },
                    Subjects = new List<Subject> { Subjects[1], Subjects[3], Subjects[5] },
                },
                new Student(6, "Igor", "Tarchugovski", "igotar@mail.com", "123asd")
                {
                    Grades = new Dictionary <Subject, int> () { { Subjects[1], 5}, { Subjects[3], 3}, { Subjects[5], 4 }  },
                    Subjects = new List<Subject> { Subjects[1], Subjects[3], Subjects[5] },
                },
                new Student(7, "Kristina", "Lazarovska", "krilar@mail.com", "123asd")
                {
                    Grades = new Dictionary <Subject, int> () { { Subjects[1], 5}, { Subjects[3], 3}, { Subjects[5], 4 }  },
                    Subjects = new List<Subject> { Subjects[1], Subjects[3], Subjects[5] },
                },
            };

            return listOfStudents;
        }

        private static List<Trainer> GenerateTrainers()
        {
            List<Trainer> listOfTrainer = new List<Trainer>
            {
                new Trainer(1, "Trajan", "Stevkovski", "traste@mail.com", "123asd"),
                new Trainer(2, "Damjan", "Stojanovski", "damsto@mail.com", "123asd"),
            };

            return listOfTrainer;
        }

        private static List<Admin> GenerateAdmins()
        {
            List<Admin> listOfAdmins = new List<Admin>
            {
                new Admin(1, "admin", "admin", "admin@mail.com", "123asd"),
                new Admin(2, "admin1", "admin1", "admin1@mail.com", "123asd")
            };

            return listOfAdmins;
        }
    }
}
