using System;

namespace SEDEC.CSharp.Class03.Homework.SumOfEven
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make a console application called SumOfEven. Inside it create an array of 6 integers.Get numbers from the input, 
            //find and print the sum of the even numbers from the array:

            int[] array = new int[6];
            for (int i = 0; i <= array.Length - 1; i++)
            {
                Console.WriteLine("Enter integer no.: " + (i + 1));
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = 0;
            foreach (int j in array)
            {
                if(j % 2 ==0)
                {
                    sum = sum + j;
                }
            }
            Console.WriteLine("The sum is: " +sum);
        }
    }
}
