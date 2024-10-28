using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Assignments
{
    public abstract class Vehicle_2
    {
        public abstract void Drive();
    }
    public class Car : Vehicle_2
    {
        public override void Drive()
        {
            Console.WriteLine("Car is now driven...");
        }
    }
    public class Bike : Vehicle_2
    {
        public override void Drive()
        {
            Console.WriteLine("Bike is now riding...");
        }
    }
}
