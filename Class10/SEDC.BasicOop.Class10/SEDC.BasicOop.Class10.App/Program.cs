using System;
using SEDC.BasicOop.Class10.Bussiness;
using SEDC.BasicOop.Class10.Bussiness.Services;

namespace SEDC.BasicOop.Class10.App
{
    class Program
    {
        static void Main(string[] args)
        {
            UserManagementService userManagmentService = new UserManagementService();

            UserResult userResult = userManagmentService.Login();

            Console.WriteLine(userResult.IsLoggedIn);
            if (userResult.Admin != null)
            {
                AdminManagementService adminManagementService = new AdminManagementService();
                adminManagementService.AdminService(userResult.Admin);

            }
            else if (userResult.Student != null)
            {
                StudentService studentService = new StudentService();
                studentService.ListSubjects(userResult.Student);
            }
            else if (userResult.Trainer != null)
            {
                TrainerService trainerService = new TrainerService();
                trainerService.TrainerServiceInit(userResult.Trainer);
            }
            else
            {
                Console.WriteLine("Something went wrong");
            }
            
            Console.ReadLine();
        }
    }
}
