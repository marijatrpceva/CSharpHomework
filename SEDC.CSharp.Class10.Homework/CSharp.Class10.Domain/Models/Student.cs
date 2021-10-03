using System;
using System.Collections.Generic;
using System.Text;
using CSharp.Class10.Domain.Enumerations;

namespace CSharp.Class10.Domain.Models
{
    public class Student : User 
    {
        private Dictionary<string, int> Grades { get; set; }
        public List<Subject> Subjects { get; set; }

        public Student(int id, string fName, string lName, string email, string pass)
              : base(id, fName, lName, email, pass, Role.Student )
        {
        }
        public Dictionary<string, int> GetGrades()
        {
            return Grades;
        }
        public void AddGrade (string subject, int grade)
        {

        }
    }
}
