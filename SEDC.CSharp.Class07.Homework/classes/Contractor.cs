using System;
using System.Collections.Generic;
using System.Text;

namespace classes
{
    public class Contractor : Employee
    {
        public Contractor(string name, string lastName)
        {
            this.FirstName = name;
            this.LastName = lastName;
        }
        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }
        public Manager Responsible { get; set; }

        public override double GetSalary()
        {
            Salary = WorkHours * PayPerHour;
            return Salary;
        }
        
    }
}
