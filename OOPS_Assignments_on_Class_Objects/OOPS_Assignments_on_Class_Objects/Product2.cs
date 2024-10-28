using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Assignments_on_Class_Objects
{
    public class Product2
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Category { get; set; }

        public Product2()
        {
            Name = "unknown value";
            Price = 0;
            Category = "unknown value";
        }
        public Product2(string name, int price, string category)
        {
            Name = name;
            Price = price;
            Category = category;
        }
        public static Product2 CreateProduct(string name, int price, string category)
        {
            return new Product2(name, price, category);
        }
        public void Display()
        {
            Console.WriteLine($"Name : {Name} , Price : {Price} , Category : {Category}");
        }
    }
}
