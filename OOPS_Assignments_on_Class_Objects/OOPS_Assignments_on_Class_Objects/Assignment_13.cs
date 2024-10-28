using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Assignments_on_Class_Objects
{
    public class MathOperations
    {
        public static double Pi;
        static MathOperations()
        {
            Pi = 3.14159;
            Console.WriteLine("Static Constructor : Pi = " + Pi);
        }

    }
}
