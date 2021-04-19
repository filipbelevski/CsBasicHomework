using System;
using System.Collections.Generic;
using System.Text;
using SEDC.BasicOop.Class10.Domain.Models;
using System.Linq;

namespace SEDC.BasicOop.Class10.Domain.Data
{
    public class AdminRepo
    {
        public bool AddStudent(Student newStudent)
        {
            int count = InMemoryDataBase.Students.Count();
            Student MailInUse = InMemoryDataBase.Students.FirstOrDefault(student => student.Email == newStudent.Email);
            if (MailInUse == null)
            {
                InMemoryDataBase.Students.Add(newStudent);
                Console.WriteLine("Init...");
            }
            if (count != InMemoryDataBase.Students.Count())
            {
                Console.WriteLine($"Added student {newStudent.Email}");
                return true;
            }
            Console.WriteLine($"Email already in use");
            return false;
        }
        public bool RemoveStudent(string numberInList)
        {
            try
            {
                int choice = int.Parse(numberInList);
                if(choice < 1 || choice > InMemoryDataBase.Students.Count)
                {
                    throw new Exception("Invalid user entered");
                }
                Console.WriteLine($"Sucessfuly removed student {InMemoryDataBase.Students[choice - 1].FirstName}");
                return InMemoryDataBase.Students.Remove(InMemoryDataBase.Students[choice - 1]); // method returns true or false..
            }
            catch
            {
                Console.WriteLine("User not found");
            }
            return false;
        }
        public bool AddTrainer(Trainer newTrainer)
        {
            int count = InMemoryDataBase.Trainers.Count();
            Trainer MailInUse = InMemoryDataBase.Trainers.FirstOrDefault(trainer => trainer.Email == newTrainer.Email);
            if (MailInUse == null)
            {
                InMemoryDataBase.Trainers.Add(newTrainer);
                Console.WriteLine("Init...");
            }
            if (count != InMemoryDataBase.Trainers.Count())
            {
                Console.WriteLine($"Added trainer {newTrainer.Email}");
                return true;
            }
            Console.WriteLine($"Email already in use");
            return false;
        }
        public bool RemoveTrainer(string trainer)
        {
            try
            {
                int choice = int.Parse(trainer);
                if (choice < 1 || choice > InMemoryDataBase.Students.Count)
                {
                    throw new Exception("Invalid user entered");
                }
                Console.WriteLine($"Sucessfuly removed trainer {InMemoryDataBase.Trainers[choice - 1].FirstName}");
                return InMemoryDataBase.Trainers.Remove(InMemoryDataBase.Trainers[choice - 1]); // method returns true or false..
            }
            catch
            {
                Console.WriteLine("User not found");
            }
            return false;
        }
        public bool AddAdmin(Admin newAdmin)
        {
            int count = InMemoryDataBase.Admins.Count();
            Admin MailInUse = InMemoryDataBase.Admins.FirstOrDefault(admin => admin.Email == newAdmin.Email);
            if(MailInUse == null)
            {
                InMemoryDataBase.Admins.Add(newAdmin);
                Console.WriteLine("Init...");
            }
            if (count != InMemoryDataBase.Admins.Count())
            {
                Console.WriteLine($"Added admin {newAdmin.Email}");
                return true;
            }
            Console.WriteLine($"Email already in use");
            return false;
        }
        public bool RemoveAdmin(string toBeremovedAdmin, string currentAdmin)
        {
            
            if(toBeremovedAdmin == currentAdmin)
            {
                Console.WriteLine("You cant remove yourself");
                return false;
            }
            try
            {
                Admin toBeRemoved = InMemoryDataBase.Admins.First(admin => admin.Email == toBeremovedAdmin);
                return InMemoryDataBase.Admins.Remove(toBeRemoved);
            }
            catch
            {
                Console.WriteLine("That admin doesn't exist");
            }
            return false;
        }
        public void ListStudents()
        {
            if(InMemoryDataBase.Students.Count == 0)
            {
                Console.WriteLine("There arent any students yet");
                return;
            }
            for (int i = 0; i < InMemoryDataBase.Students.Count; i++)
            {
                Console.WriteLine($"{i+1} {InMemoryDataBase.Students[i].FirstName} {InMemoryDataBase.Students[i].LastName} {InMemoryDataBase.Students[i].Email}");
            }
        }
        public void ListTrainers()
        {
            if (InMemoryDataBase.Trainers.Count == 0)
            {
                Console.WriteLine("There arent any trainers yet");
                return;
            }
            for (int i = 0; i < InMemoryDataBase.Trainers.Count; i++)
            {
                Console.WriteLine($"{i + 1} {InMemoryDataBase.Trainers[i].FirstName} {InMemoryDataBase.Trainers[i].LastName} {InMemoryDataBase.Trainers[i].Email}");
            }
        }
    }
}
