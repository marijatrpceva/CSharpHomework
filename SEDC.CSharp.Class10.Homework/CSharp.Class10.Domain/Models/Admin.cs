using CSharp.Class10.Domain.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Class10.Domain.Models
{
    public class Admin : User
    {
        public Admin(int id, string fName, string lName, string email, string pass)
              : base(id, fName, lName, email, pass, Role.Admin)
        {

        }
    }
}
