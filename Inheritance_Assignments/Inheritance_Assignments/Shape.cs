using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Assignments
{
    public class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing Something...");
        }
    }
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing is circle");
        }
    }
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing is a rectangle");
        }

    }
}
