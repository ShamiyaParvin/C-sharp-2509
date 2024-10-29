using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Assignments
{
    public class Payment
    {
        public virtual void ProcessPayment()
        {
            Console.WriteLine("Processing a payment");
        }
    }
    public class CreditCardPayment : Payment
    {
        public override void ProcessPayment()
        {
            Console.WriteLine("Payment with credit card");
        }
    }
    public class PayPalPayment : Payment
    {
        public override void ProcessPayment()
        {
            Console.WriteLine("Payment through PayPal");
        }
    }

}
