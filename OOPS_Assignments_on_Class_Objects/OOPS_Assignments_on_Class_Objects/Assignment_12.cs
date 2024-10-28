using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Assignments_on_Class_Objects
{
    public class Car
    {
        private static int carCount;
        static Car()
        {
            carCount = 0;
            Console.WriteLine("Static constructor: Car count initialized");
        }
        public Car()
        {
            carCount++;
            Console.WriteLine("Regular constructor: New car object created");
        }
        public static int GetCarCount()
        {
            return carCount;
        }
    }
}
