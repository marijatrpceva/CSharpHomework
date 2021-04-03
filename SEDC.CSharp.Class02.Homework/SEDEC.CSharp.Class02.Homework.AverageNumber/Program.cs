using System;

namespace SEDEC.CSharp.Class02.Homework.AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //## Task 2
            //Create new console application “AverageNumber” that takes four numbers as input to calculate and print the average.

            int input = 4;
            Console.WriteLine("Enter first number");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number");
            int third = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter fourth number");
            int fourth = Convert.ToInt32(Console.ReadLine());

            int avg = (first + second + third + fourth )/ input;
            Console.WriteLine("The avgerage of {0}, {1}, {2}, {3} is:{4} ", first, second, third, fourth, avg);

            


        }
    }
}
