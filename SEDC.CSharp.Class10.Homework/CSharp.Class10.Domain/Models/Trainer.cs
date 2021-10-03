using System;
using System.Collections.Generic;
using System.Text;
using CSharp.Class10.Domain.Enumerations;

namespace CSharp.Class10.Domain.Models
{
    public class Trainer : User
    {
        public List<Subject> Subject { get; set;}

        public Trainer(int id, string fName, string lName, string email, string pass)
              : base(id, fName, lName, email, pass, Role.Trainer)
        {

        }
    }
}
