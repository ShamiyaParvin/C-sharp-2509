using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_2509_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            while (number != 0)
            {
                number /= 10;
                count++;
            }
            Console.WriteLine("Number of digits: " + count);
            Console.ReadLine();
        }
    }
}
