using CSharp.Class10.Bussines.Services;
using System;

namespace CSharp.Class10.AcademyMenagmentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            UserMenagmentService userMenagmentService = new UserMenagmentService();
            UserResult userResult = userMenagmentService.Login();
            Console.WriteLine(userResult.IsLOgedIn);

            if(userResult.Student != null)
            {
                Console.WriteLine(userResult.Student.FirstName);
            }
            else if (userResult.Admin != null)
            {
                Console.WriteLine(userResult.Admin.FirstName);
            }
            else if (userResult.Trainer != null)
            {
                Console.WriteLine(userResult.Trainer.FirstName);
            }

            //while(isLoged)
            //{

            //}
        }
    }
}
