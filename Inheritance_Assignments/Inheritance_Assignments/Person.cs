using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Assignments
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
    public class Student : Person
    {
        public double Grade { get; set; }   
        public Student(string name, int age, double grade) : base(name, age)
        {
            Grade = grade;
        }
        public void DisplayStudent()
        {
            Display();
            Console.WriteLine($"Grade: {Grade}");
        }
    }
}