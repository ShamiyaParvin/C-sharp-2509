using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Assignments
{
    public class Vehicle
    {
        public virtual void Drive()
        {
            Console.WriteLine("The vehicle is driving");
        }
    }
    public class Car : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Car is driving");
        }
    }
}
