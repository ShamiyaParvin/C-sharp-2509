using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Part5
{
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message) { }
    }
    public class Person
    {
        public int Age { get; private set; }

        public void SetAge(int age)
        {
            if (age < 0 || age > 120)
            {
                throw new InvalidAgeException("Invalid age provided");
            }
            Age = age;
            Console.WriteLine($"Age set to {age}");
        }
    }
}
