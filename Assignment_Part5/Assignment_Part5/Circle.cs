using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Part5
{
    //value type
    public struct Circle
    {
        public double Radius {  get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
        public void Display()
        {
            Console.WriteLine($"Circle Radius : {Radius}, Area : {CalculateArea()}");
        }
    }
    //reference type
    public class Shape
    {
        public string Name { get; set; }
        public Shape(string name)
        {
            Name = name;
        }
        public void Display()
        {
            Console.WriteLine($"Shape Name : {Name}");
        }
    }
}
