using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Assignments
{
    public abstract class Shape4
    {
        public string Name { get; }
        protected Shape4(string name)
        {
            Name = name;
        }
        public abstract double Area();
    }
    public class Circle4 : Shape4
    {
        public double Radius { get; }

        public Circle4(double radius) : base("Circle")
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
    public class Square : Shape4
    {
        public double Side { get; }

        public Square(double side) : base("Square")
        {
            Side = side;
        }
        public override double Area()
        {
            return Side * Side;
        }
    }
}
