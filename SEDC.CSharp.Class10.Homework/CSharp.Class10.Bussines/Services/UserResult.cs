using CSharp.Class10.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Class10.Bussines.Services
{
    public class UserResult
    {
        public Admin Admin { get; set; }
        public Student Student { get; set; }
        public Trainer Trainer { get; set; }
        public bool IsLOgedIn { get; set; }
    }
}
