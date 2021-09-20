using System;
using System.Collections.Generic;
using System.Text;

namespace classes
{
    public class SalesPerson: Employee
    {
        public SalesPerson(string name,string lastName)
        {
            this.FirstName = name;
            this.LastName = lastName;
            this.Salary = 500;
            this.Role = Role.Sales;
        }
        private double SuccessSaleRevenue { get; set; }
        public void AddSuccessRevenue(double number)
        {
             SuccessSaleRevenue = number;
        }
        public override double GetSalary()
        {
            int bonus;
            if (SuccessSaleRevenue <= 2000)
            {
                bonus =  500;
            }
            else if (SuccessSaleRevenue > 2000 && SuccessSaleRevenue <= 5000)
            {
                bonus =  1000;
            }
            else
            {
                bonus =  1500;
            }
            return Salary + bonus;
        }

    }
}
