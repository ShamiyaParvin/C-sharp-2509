using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Assignments_on_Class_Objects
{
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        public Vehicle(string make)
        {
            Make = make;
            Console.WriteLine($"Make = {Make}");
        }

        public Vehicle(string make, string model) : this(make)
        {
            Model = model;
            Console.WriteLine($"Model = {Model}");
        }

        public Vehicle(string make, string model, int year) : this(make, model)
        {
            Year = year;
            Console.WriteLine($"Year = {Year}");
        }

        public Vehicle(string make, string model, int year, decimal price) : this(make, model, year)
        {
            Price = price;
            Console.WriteLine($"Price = {Price}");
        }

        public void Display()
        {
            Console.WriteLine($"Vehicle Details - Make: {Make}, Model: {Model}, Year: {Year}, Price: {Price}");
        }
    }
}
