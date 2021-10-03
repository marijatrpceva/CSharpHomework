using CSharp.Class10.Domain.Data;
using CSharp.Class10.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Class10.Bussines.Services
{
    public class UserMenagmentService
    {
        private UserRepo UserRepo { get; set; }
        public UserMenagmentService()
        {
            UserRepo = new UserRepo();
        }
        public UserResult Login()
        {   
            while(true)
            {
                Console.WriteLine($"Please enter email:");
                string email = Console.ReadLine();
                Console.WriteLine("Enter password");
                string password = Console.ReadLine();
                try   
                {
                    Student student = UserRepo.GetStudentByMail(email);
                    if (student != null)
                    {
                        student.ValidatePassword(password);
                        return new UserResult
                        {
                            Student = student,
                            IsLOgedIn = true
                        };
                    }
                    Admin admin = UserRepo.GetAdminByEmail(email);
                    if(admin != null) 
                    {
                        student.ValidatePassword(password);
                        return new UserResult
                        {
                            Admin = admin,
                            IsLOgedIn = true
                        };
                    }
                    Trainer trainer = UserRepo.GetTrainerByEmail(email);
                    if(trainer != null)
                    {
                        trainer.ValidatePassword(password);
                        return new UserResult
                        {
                            Trainer = trainer,
                            IsLOgedIn = true
                        };
                    }
                    throw new Exception("Not walid email");
 
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Please try again!");
                }
            }
            
        }
    }
}
