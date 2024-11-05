using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Part5
{
    public enum OrderStatus
    {
        Pending,
        Shipped,
        Delivered
    }
    public class Order
    {
        public int OrderID {  get; set; }
        public OrderStatus Status { get; set; }
        public Order(int orderId, OrderStatus status)
        {
            OrderID = orderId;
            Status = status;
        }
        public void DisplayOrderStatus()
        {
            Console.WriteLine($"Order ID : {OrderID}, Status : {Status}");
        }
    }
}
