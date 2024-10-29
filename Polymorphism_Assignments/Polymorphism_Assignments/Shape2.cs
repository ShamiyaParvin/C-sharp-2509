using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Assignments
{
    public abstract class Shape2
    {
        public abstract double Area();
        public abstract void Display();
    }
    public interface IShape
    {
        double Perimeter();
    }
    public class Circle3 : Shape2, IShape
    {
        private double radius;
        public Circle3(double radius)
        {
            this.radius = radius;
        }
        public override double Area()
        { 
            return Math.PI * radius * radius;
        }
        public override void Display()
        {
            Console.WriteLine($"Circle, radius: {radius}");
        }
        public double Perimeter()
        {
            return 2*Math.PI * radius;
        }
    }
    // Another Derived class implementing both abstract class and interface
    public class Rectangle3 : Shape2, IShape
    {
        private double length;
        private double width;

        public Rectangle3(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public override double Area()
        {
            return length * width;
        }

        public override void Display()
        {
            Console.WriteLine($"Rectangle, length: {length}, width: {width}");
        }

        public double Perimeter()
        {
            return 2 * (length + width);
        }
    }
}
