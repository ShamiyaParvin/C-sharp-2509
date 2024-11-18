using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Part7
{
    public delegate int CalculationDelegate(int num1, int num2);
    public class Calculation
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int Sub(int num1, int num2)
        {
            return num1 - num2;
        }
        public static int Calculate(int a, int b, CalculationDelegate operation)
        {
            return operation(a, b);
        }
    }
}
