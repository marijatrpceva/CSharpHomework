using System;

namespace SEDC.CSharp.Class03.Homework.StudentGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            //*Make 2 arrays called studentsG1 and studentsG2 and fill them with 5 student names. 
            //*Get a number from the console between 1 and 2 and print the students from that group in the console.

            string[] studentsG1 = new string[] { "Ana", "Jana", "Eva", "Mila", "Sara" };
            string[] studentsG2 = new string[] { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };

            Console.WriteLine("Enter number 1 or 2");
            string answer = Console.ReadLine();
            bool isValid = int.TryParse(answer, out int number);

            if (isValid && number == 1 || number == 2)
            {
                if (number == 1)
                {
                    Console.WriteLine("The studets from G1 are");
                    foreach (string name in studentsG1)
                    {
                        Console.WriteLine(name);
                    }
                }
                else if (number == 2)
                {
                    Console.WriteLine("The studets from G2 are");
                    foreach (string name in studentsG2)
                    {
                        Console.WriteLine(name);
                    }
                }

            }
            else
            {
                Console.WriteLine("Invalid number");
            }
        }
    }
}
