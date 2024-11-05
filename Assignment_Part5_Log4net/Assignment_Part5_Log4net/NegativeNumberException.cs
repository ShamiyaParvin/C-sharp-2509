using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Part5_Log4net
{
    public class NegativeNumberException : Exception
    {
        public NegativeNumberException(string message) : base(message) { }
    }
    public class NumberChecker
    {
        public void CheckNumber(int number)
        {
            if (number < 0)
            {
                throw new NegativeNumberException("Negative numbers are not allowed");
            }
            Console.WriteLine("Number is valid");
        }
    }
}
