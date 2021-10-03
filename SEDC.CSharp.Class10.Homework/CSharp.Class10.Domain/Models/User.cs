using CSharp.Class10.Domain.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Class10.Domain.Models
{
    public  class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
        public User(int id,string fName, string lName, string email, string pass, Role role)
        {
            Id = id;
            FirstName = fName;
            LastName = lName;
            Email = email;
            Password = pass;
            Role = role;

        }

        public void ValidatePassword(string password)
        {
            if (password != Password)
            {
                throw new Exception("Not valid password");
            }
        }
    }
}

