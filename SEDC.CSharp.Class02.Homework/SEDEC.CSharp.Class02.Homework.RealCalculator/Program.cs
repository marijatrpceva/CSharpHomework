using System;

namespace SEDEC.CSharp.Class02.Homework.RealCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //## Task 1
            //Create new console application “RealCalculator” that takes two numbers from the input and
            //asks what operation would the user want to be done( +, - , * , / ). Then it returns the result.

            Console.WriteLine("Enter first number");
            string input1 = Console.ReadLine();
            Console.WriteLine("Enter second number");
            string input2 = Console.ReadLine();
            Console.WriteLine("Enter operation");
            string operation = Console.ReadLine();

            bool isValid1 = int.TryParse(input1, out int firstNumber);
            bool isValid2 = int.TryParse(input2, out int secondNumber);

            if (isValid1 && isValid2)
            {
                if (operation == "+")
                {
                    int resultPlus = firstNumber + secondNumber;
                    Console.WriteLine("the result is " + resultPlus);
                }

                if (operation == "-")
                {
                    int resultMinus = firstNumber - secondNumber;
                    Console.WriteLine("the result is " + resultMinus);
                }
                if (operation == "*")
                {
                    int resultMulti = firstNumber * secondNumber;
                    Console.WriteLine("the result is " + resultMulti);
                }
                if (operation == "/")
                {
                    int resultDiv = firstNumber / secondNumber;
                    Console.WriteLine("the result is " + resultDiv);
                }
            }
            else
            {
                Console.WriteLine("Enter valid input");
            }
        }
    }
}
