using System;

namespace classes
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }
        protected double Salary { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"First Name:{FirstName}, Last Name:{LastName},Salary: {Salary}");
        }
        public virtual double GetSalary()
        {
            return Salary;
        }
    }
}
