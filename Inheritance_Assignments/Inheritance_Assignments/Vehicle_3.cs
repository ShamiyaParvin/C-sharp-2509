using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Assignments
{
    public class Vehicle_3
    {
        public string Brand { get; set; }

        public Vehicle_3(string brand)
        {
            Brand = brand;
            Console.WriteLine($"Vehicle brand: {Brand}");
        }
    }
    public class Car_ : Vehicle_3
    {
        public string Model { get; set; }

        public Car_(string brand, string model) : base(brand)
        {
            Model = model;
            Console.WriteLine($"Car model: {Model}");
        }
    }
}
