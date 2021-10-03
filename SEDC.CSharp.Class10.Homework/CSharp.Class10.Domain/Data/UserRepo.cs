using CSharp.Class10.Domain.Models;
using SEDC.CSharpOop.Class10.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp.Class10.Domain.Data
{
    public class UserRepo
    {
        public Admin GetAdminByEmail(string email)
        {
            Admin admin = InMemoryDatabase.Admins.FirstOrDefault(admin => admin.Email == email);
            return admin;
        }
        public Student GetStudentByMail(string email)
        {
            Student student = InMemoryDatabase.Students.FirstOrDefault(student => student.Email == email);
            return student;
        }

        public Trainer GetTrainerByEmail(string email)
        {
            Trainer trainer = InMemoryDatabase.Trainers.FirstOrDefault(trainer => trainer.Email == email);
            return trainer;
        }
    }
}
