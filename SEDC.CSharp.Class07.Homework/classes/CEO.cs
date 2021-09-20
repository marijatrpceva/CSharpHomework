using System;
using System.Collections.Generic;
using System.Text;

namespace classes
{
    public class CEO : Employee
    {
    
        public Employee[] Employees { get; set; }
        public int Shares { get; set; }
        private double SharesPrice { get; set; }

        public void AddSharesPrice( double shares)
        {
            SharesPrice = shares;
        }
        //The CEO should have a method called PrintEmployees() that will print all employees that work for his company. 
        public void PrintEmployees()
        {
            foreach(Employee empl in Employees)
            {
                Console.WriteLine($"{empl.FirstName}  {empl.LastName}");
            }
        }
    }
}
