using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Assignments
{
    public class Employee
    {
        public virtual void Work()
        {
            Console.WriteLine("Employee is wotking...");
        }
    }
    public class Manager : Employee
    {
        public override void Work()
        {
            Console.WriteLine("Manager is working...");
        }
    }
}
