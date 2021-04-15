using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharp.Class06.Homework.Classes
{
    public class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public Driver  Driver { get; set; }

        public Car (string model, int speed)
        {
            Model = model;
            Speed = speed;
        }
   

        public void NewDriver( Driver dr)
        {
            Driver = dr;
        }

        public int CalculateSpeed(Driver Driver)
        {
            return Driver.Skill * Speed;
        }
    }
}
