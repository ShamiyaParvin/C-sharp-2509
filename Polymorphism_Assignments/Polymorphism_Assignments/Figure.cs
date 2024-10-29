using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Assignments
{
    // Early Binding
    public class Figure
    {
        public double Area(double radius)
        {
            return Math.PI * radius * radius;
        }
        public double Area(double length, double width)
        {
            return length * width;
        }
        //late binding
        public virtual void Display()
        {
            Console.WriteLine("This is a figure");
        }
    }
    public class Circle2 : Figure
    {
        public override void Display()
        {
            Console.WriteLine("This is a circle");
        }
    }
    public class Rectangle2 : Figure
    {
        public override void Display()
        {
            Console.WriteLine("This is a Rectangle");
        }
    }
}
