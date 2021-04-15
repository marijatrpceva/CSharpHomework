using System;

namespace CSharp.ExtraHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a function that calculates the result of raising an integer to another integer(eg 5 raised to 3 = 5 ^ 3 = 5 × 5 × 5 = 125).
            Console.WriteLine(Calculate(2, 3));
        }

        static int Calculate(int num1, int num2 )
        {
            int sum = 1;
             while(num2 != 0)
            {
                sum = sum * num1;
                num2--;
            }
            return sum;
        }
    }
}
