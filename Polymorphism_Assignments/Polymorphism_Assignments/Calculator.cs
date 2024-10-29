using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Assignments
{
    public class Calculator
    {
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Multiply(int a, int b, int c)
        {
            return a * b * c;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        // Multiply method with integer and double parameters (different order)
        public double Multiply(int a, double b)
        {
            return a * b;
        }

        // Multiply method with double and integer parameters (different order)
        public double Multiply(double a, int b)
        {
            return a * b;
        }
    }
}
