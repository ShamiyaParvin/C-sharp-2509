using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Assignments
{
    public class Person_2
    {
        public string Name;
        public Person_2(string name)
        {
            Name = name;
            Console.WriteLine($"Person's Name : {name}");
        }
    }
    public class Employee_2 : Person_2
    {
        public int Id;
        public Employee_2(string name, int id) : base(name)
        {
            Id = id;
            Console.WriteLine($"Employee ID : {Id}");
        }
    }
}
