using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Assignments
{
    public class Animal_2
    {
        public string Name { get; set; }

        public void Eat()
        {
            Console.WriteLine($"{Name} is eating");
        }
    }

    public class Dog_2 : Animal_2
    {
        public void Bark()
        {
            Console.WriteLine($"{Name} is Barking");
        }
    }
}
