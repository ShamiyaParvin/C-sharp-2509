using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Assignments_on_Class_Objects
{
    public class Inventory
    {
        private class Item
        {
            public string Name { get; set; }
            public int Stock { get; set; }
            public decimal Price { get; set; }

            public Item(string name, int stock, decimal price)
            {
                Name = name;
                Stock = stock >= 0 ? stock : 0;
                Price = price >= 0 ? price : 0;
            }

            public void Display()
            {
                Console.WriteLine($"Item: {Name}, Stock: {Stock}, Price: {Price}");
            }
        }

        private List<Item> items;

        public Inventory()
        {
            items = new List<Item>();
        }

        public void AddItem(string name, int stock, decimal price)
        {
            Item newItem = new Item(name, stock, price);
            items.Add(newItem);
            Console.WriteLine($"{name} is Added");
        }

        public void RemoveItem(string name)
        {
            Item itemToRemove = null;
            foreach (var item in items)
            {
                if (item.Name == name)
                {
                    itemToRemove = item;
                    break;
                }
            }
            if (itemToRemove != null)
            {
                items.Remove(itemToRemove);
                Console.WriteLine($"Removed : {name}");
            }
            else
            {
                Console.WriteLine($"Item not found : {name}");
            }
        }

        public void UpdateStock(string name, int newStock)
        {
            Item itemToUpdate = null;
            foreach (var item in items)
            {
                if (item.Name == name)
                {
                    itemToUpdate = item;
                    break;
                }
            }
            if (itemToUpdate != null)
            {
                itemToUpdate.Stock = newStock;
                Console.WriteLine($"Updated stock : {name}");
            }
            else
            {
                Console.WriteLine($"Item not found : {name}");
            }
        }

        public void UpdatePrice(string name, decimal newPrice)
        {
            Item itemToUpdatePrice = null;
            foreach (var item in items)
            {
                if (item.Name == name)
                {
                    itemToUpdatePrice = item;
                    break;
                }
            }
            if (itemToUpdatePrice != null)
            {
                itemToUpdatePrice.Price = newPrice;
                Console.WriteLine($"Updated price for: {name}");
            }
            else
            {
                Console.WriteLine($"Item not found: {name}");
            }

        }

        public void DisplayAllItems()
        {
            Console.WriteLine("Inventory Items: ");
            foreach (var item in items)
            {
                item.Display();
            }
        }
    }
}
