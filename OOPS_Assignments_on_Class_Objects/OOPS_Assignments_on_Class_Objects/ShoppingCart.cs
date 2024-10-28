using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Assignments_on_Class_Objects
{
    public class ShoppingCart
    {
        public class Product
        {
            public string Name { get; set; }
            public double Price { get; set; }
            public int Quantity { get; set; }

            public Product(string name, double price, int quantity)
            {
                Name = name;
                Price = price;
                Quantity = quantity;
            }
        }


        private List<Product> products = new List<Product>();
        public void AddProduct(Product product)
        {
            products.Add(product);
            Console.WriteLine($"Added {product.Quantity} of {product.Name} to the cart.");
        }
        public double CalculateTotalPrice()
        {
            double totalPrice = 0.0;
            foreach (var product in products)
            {
                totalPrice += product.Price * product.Quantity;
            }
            return totalPrice;
        }
        public void DisplayCart()
        {
            Console.WriteLine("Shopping Cart:");
            foreach (var product in products)
            {
                Console.WriteLine($"Name : {product.Name},Quantity : {product.Quantity},Price: {product.Price} ");
            }
            Console.WriteLine($"Total Price: {CalculateTotalPrice()}");

        }
    }
}
