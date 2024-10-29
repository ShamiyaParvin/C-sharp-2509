using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Assignments
{
    public class Employee2
    {
        public string[] Tasks { get; set; }
        public virtual void ShowTasks()
        {
            Console.WriteLine("Employee tasks:");
            foreach (var task in Tasks)
            {
                Console.WriteLine(task);
            }
        }
    }
    public class Manager2 : Employee2 
    {
        public override void ShowTasks()
        {
            Console.WriteLine("Manager tasks:");
            foreach(var task in Tasks)
            {
                Console.WriteLine(task);
            }
        }
    }
    public class Developer2 : Employee2
    {
        public override void ShowTasks()
        {
            Console.WriteLine("Developer tasks:");
            foreach (var task in Tasks)
            {
                Console.WriteLine(task);
            }
        }
    }
}
