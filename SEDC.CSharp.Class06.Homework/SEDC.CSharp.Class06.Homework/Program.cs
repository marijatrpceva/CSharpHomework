using SEDC.CSharp.Class06.Homework.Classes;
using System;

namespace SEDC.CSharp.Class06.Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Driver[] driver = new Driver[4]
            {
                new Driver("Bob", 4),
                new Driver("Greg", 8),
                new Driver("Hamilton", 10),
                new Driver("Anne", 8)
            };

            Car[] car = new Car[4]
            {
                new Car("Hyundai", 200),
                new Car("Mazda", 220),
                new Car("Ferrari", 280),
                new Car("Porsche", 270)
            };

            int firstDriverNumber = returnDriver(driver);
            Driver firstDriver = driver[firstDriverNumber];
            Console.WriteLine("The skill is " + firstDriver.Skill);

            int secondDriverNumber = returnDriver(driver);
            Driver secondDriver = driver[secondDriverNumber];
            Console.WriteLine("The skill is " +secondDriver.Skill);
            
            int firstCarNumber = returnCar(car);
            Car firstCar = car[firstCarNumber];
            Console.WriteLine(firstCar.Speed);

            int secondCarNumber = returnCar(car);
            Car secondCar = car[secondCarNumber];
            Console.WriteLine(secondCar.Speed);

            firstCar.NewDriver(firstDriver);
            secondCar.NewDriver(secondDriver);



            Car winnerCar = RaceCars(firstCar, secondCar);
            Console.WriteLine($"The winner is {winnerCar.Driver.Name} with the car {winnerCar.Model}");

           

        }
         
        static int returnDriver(Driver[] driver)
        {
            while (true)
            {
                Console.WriteLine("Select car driver: 1, 2, 3 or 4");
            for (int i = 0; i < driver.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {driver[i].Name}");
            }
            string inputDriverNumberString = Console.ReadLine();
            bool isValid = int.TryParse(inputDriverNumberString, out int inputDriverNumber);
           
            
                if (!isValid || inputDriverNumber < 0 || inputDriverNumber > 5)
                {

                    Console.WriteLine("Enter valid input");

                    continue;
                }
                
                return inputDriverNumber - 1;
            }
         
            
        }

        static int returnCar(Car[] car)
        {
            while (true)
            {
                Console.WriteLine("Select car:  1, 2, 3 or 4");
                for (int i = 0; i < car.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {car[i].Model}");
                }
                string inputCarNumberString = Console.ReadLine();
                bool isValid = int.TryParse(inputCarNumberString, out int inputCarNumber);

                if (!isValid || inputCarNumber < 0 || inputCarNumber > 5)
                {
                    Console.WriteLine("Enter valid input");
                    continue;
                }
                
                return inputCarNumber - 1;
            } 
            
        }

        static Car RaceCars(Car fCar, Car sCar)
        {
            if (fCar.CalculateSpeed(fCar.Driver)< sCar.CalculateSpeed(sCar.Driver)) {
                return sCar;
            }
            else  
            {
                return fCar;
            }
        }


    }
}
