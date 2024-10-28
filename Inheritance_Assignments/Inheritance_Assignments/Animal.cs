using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Assignments
{
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal Eat");
        }
        
    }
    public class Dog : Animal
    {
        public void Bark()
        {
            
            Console.WriteLine("Dog Barks");
        }
    }
    public class Puppy : Dog
    {
        public void Weep()
        {
            Console.WriteLine("Puppy is weeping");
        }
    }
}
