using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Assignments_on_Class_Objects
{
    public class Ecommerce
    {
        public class Product
        {
            public string Name { get; set; }
            private decimal price;
            private int stockQuantity;

            public Product(string name, decimal price, int stockQuantity)
            {
                Name = name;
                Price = price;
                StockQuantity = stockQuantity;
            }
            public decimal Price
            {
                get { return price; }
                set
                {
                    if (value < 0)
                        throw new ArgumentException("Price cannot be negative");
                    price = value;
                }
            }
            public int StockQuantity
            {
                get { return stockQuantity; }
                set
                {
                    if (value < 0)
                        throw new ArgumentException("Stock quantity cannot be negative");
                    stockQuantity = value;
                }
            }
        }
        public class Order
        {
            public List<Product> Products { get; set; }
            public decimal TotalAmount { get; set; }

            public Order()
            {
                Products = new List<Product>();
                TotalAmount = 0;
            }

            public void CreateOrder(Product product, int quantity)
            {
                if (quantity <= 0)
                    throw new ArgumentException("Quantity must be greater than zero");

                if (product.StockQuantity < quantity)
                    throw new InvalidOperationException("Insufficient stock for the requested quantity");

                product.StockQuantity -= quantity;

                TotalAmount += product.Price * quantity;

                Products.Add(product);
            }

            public void DisplayOrderDetails()
            {
                Console.WriteLine("Order Details:");
                foreach (var product in Products)
                {
                    Console.WriteLine($"Product: {product.Name}, Price: {product.Price}, Quantity: {product.StockQuantity}");
                }
                Console.WriteLine($"Total Amount: {TotalAmount}");
            }
        }
    }
}
