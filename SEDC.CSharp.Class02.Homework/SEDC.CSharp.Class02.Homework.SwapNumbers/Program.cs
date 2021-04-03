using System;

namespace SEDC.CSharp.Class02.Homework.SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //## Task 3:
            //Create new console application “SwapNumbers”. Input 2 numbers from the console and then
            //swap the values of the variables so that the first variable has the second value and the second variable the first value.

            Console.WriteLine("Enter first number");
            string input1 = Console.ReadLine();
            Console.WriteLine("Enter second number");
            string input2 = Console.ReadLine();

            bool isValid1 = int.TryParse(input1, out int firstNumber);
            bool isValid2 = int.TryParse(input2, out int secondNumber);
             
            int empty;

            if (isValid1 && isValid2)
            {
                empty = firstNumber;
                firstNumber = secondNumber;
                secondNumber = empty;

                Console.WriteLine("Swapped numbers, First: {0}, Second: {1}", firstNumber, secondNumber);
            }
            else
            {
                Console.WriteLine("Enter valid inputs");
            }

            
        }
    }
}
