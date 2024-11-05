using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Part5
{
    public class Age
    {
        public void ValidateAge(int age)
        {
            if (age < 18)
            {
                throw new ArgumentException("Age must be 18 or older");
            }
            Console.WriteLine("Age is valid");
        }
    }
}
