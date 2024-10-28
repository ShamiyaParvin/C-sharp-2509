using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Assignments
{
    public class Person_3
    {
        public string Name { get; set; }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
        }
    }

    public class Employee_3 : Person_3
    {
        public int Id { get; set; }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Id : {Id}");
        }
    }
}
