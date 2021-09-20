using System;
using System.Collections.Generic;
using System.Text;

namespace classes
{
    public class Manager : Employee
    {
        public Manager(string name, string lastName, double salary)
        {
            this.FirstName = name;
            this.LastName = lastName;
            this.Salary = salary;
            this.Role = Role.Manager;
        }
       
        private double Bonus { get; set; }
        public void AddBonus(double bonus)
        {
            Bonus = bonus;
        }
        public override double GetSalary()
        {
            return base.GetSalary() + Bonus;
        }
       
    }
}
