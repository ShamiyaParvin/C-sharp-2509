using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Assignments
{
    public class Engine
    {
        public int HorsePower { get; set; }
        public Engine(int horsePower)
        {
            HorsePower = horsePower;
        }
        public void ShowEngineDetails()
        {
            Console.WriteLine($"Engine Horsepower: {HorsePower}");
        }
    }
    public class Car_3
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Car_3(string model, int horsePower)
        {
            Model = model;
            Engine = new Engine(horsePower);
        }
        public void ShowCarDetails()
        {
            Console.WriteLine($"Car Model: {Model}");
            Engine.ShowEngineDetails();
        }
    }
}
