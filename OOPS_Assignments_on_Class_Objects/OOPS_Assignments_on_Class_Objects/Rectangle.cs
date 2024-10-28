using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Assignments_on_Class_Objects
{
    public class Rectangle
    {
        public double CalculateArea(double width, double height)
        {
            return width * height;
        }

        public double CalculateArea(double sideLength)
        {
            return sideLength * sideLength;
        }
    }
}
