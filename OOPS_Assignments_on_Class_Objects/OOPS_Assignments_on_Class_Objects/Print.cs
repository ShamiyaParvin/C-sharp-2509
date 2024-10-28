using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Assignments_on_Class_Objects
{
    public class Print
    {
        public void PrintData(string data)
        {
            Console.WriteLine("String: " + data);
        }

        public void PrintData(int data)
        {
            Console.WriteLine("Integer: " + data);
        }

        public void PrintData(int[] data)
        {
            Console.Write("Array: ");
            foreach (int item in data)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
