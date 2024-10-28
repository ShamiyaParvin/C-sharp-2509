using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Assignments_on_Class_Objects
{
    public class Product
    {
        public string Name;
        public double Price;
        public int Discount;
        public Product(string name)
        {
            this.Name = name;
            this.Price = 0;
            this.Discount = 0;
        }
        public Product(string name, double price) : this(name)
        {

            this.Price = price;

        }
        public Product(string name, double price, int discount) : this(name, price)
        {

            this.Discount = discount;
        }

        public void Display()
        {
            double FinalPrice = Price - ((Discount / Price) * 100);
            Console.WriteLine($"Name : {Name} , Price : {Price} , Discount : {Discount}");
            Console.WriteLine($"The Final Price after discount is : {FinalPrice}");
        }
    }

}
