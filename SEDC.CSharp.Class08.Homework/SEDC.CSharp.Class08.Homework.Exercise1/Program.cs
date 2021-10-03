using System;
using System.Collections.Generic;

namespace SEDC.CSharp.Class08.Homework.Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            phoneBook.Add("Bob", "077/352/846");
            phoneBook.Add("Sam", "077/121/123");
            phoneBook.Add("Ana", "078/899/856");
            phoneBook.Add("Lara", "070/352/554");
            phoneBook.Add("Ina", "077/777/202");

            Console.WriteLine("Enter name");
            string inputName = Console.ReadLine();

            searchName(inputName, phoneBook);

            // moze i so Containskey()

           
        }
        static void searchName(string name, Dictionary<string, string> phoneBook)
        {
            foreach (KeyValuePair<string, string> item in phoneBook)
            {
                if (item.Key != name)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine($"The phone number of {item.Key} is: {item.Value} ");
                }
            }
        }
    }
}
