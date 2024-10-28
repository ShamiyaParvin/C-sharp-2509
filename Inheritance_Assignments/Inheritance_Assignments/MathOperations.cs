using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Assignments
{
    public sealed class MathOperations
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
    //Trying to create a derived class from MathOperations

    //public class NewMathOperations : MathOperations
    //{
    //    // it won't compile
    //}
}
