using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Assignments
{
    public class Person_4
    {
        public string Name { get; set; }

    }
    public class Student_1 : Person_4
    {
        public new string Name
        {
            get => "Student : " + base.Name;
            set => base.Name = value;
        }
        public void Display()
        {
            Console.WriteLine("Base name : " + base.Name);
            Console.WriteLine("Derived name : " + Name);
        }
    }
}
