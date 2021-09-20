using classes;
using System;

namespace SEDC.CSharp.Class07.Homework.Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            SalesPerson salesPerson1 = new SalesPerson("Dejan", "Arsov");
            
            salesPerson1.PrintInfo();
            salesPerson1.AddSuccessRevenue(5500);

            double salary = salesPerson1.GetSalary();
            Console.WriteLine($"The sales person salary is {salary}");

            Manager manager = new Manager("Jana", "Taseva", 4600);
            manager.AddBonus(500);
            double managerSalary = manager.GetSalary();
            Console.WriteLine($"The manager salary with bonus is {managerSalary}");

            //Contractor conctractor = new Contractor();

            Employee[] Company = new Employee[5];
            Company[0] = new Contractor("Lea","Lensky");
            Company[1] = new Contractor("Ina", "Insky");
            Company[2] = new SalesPerson("Jon","Jonsky");
            Company[3] = new Manager("Ben", "Bensky", 10000);
            Company[4] = new Manager("Bob", "Bobsky", 10000);

            CEO ceo = new CEO();
            ceo.Employees = Company;

            Console.WriteLine(ceo.Employees.Length);
            ceo.PrintEmployees();
            Console.ReadLine();
        }
    }
}
