using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Assignments
{
    public class Employee
    {
        private static int totalEmployees;
        public Employee()
        {
            totalEmployees++;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine("I am an employee");
        }
        public static void DisplayTotalEmployees()
        {
            Console.WriteLine($"Total Employees: {totalEmployees}");
        }
    }

    public class Manager : Employee
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("I am a Manager");
        }
    }
    public class Developer : Employee
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("I am a Developer.");
        }
    }

}
