using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Part7
{
   
    public class Calculator
    {
        public delegate double OperationDelegate(double num1, double num2);
        public static double Add(double num1, double num2)
        {
            return (num1 + num2);
        }
        public static double Sub(double num1, double num2)
        {
            return (num1 - num2);
        }
        public static double Multiplication(double num1, double num2)
        {
            return (num1 * num2);
        }
        public static double Divide(double num1, double num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("Cannot divide by zero");
                return 0;
            }
            else
            {
                return (num1 / num2);
            }
        }
    }
}
