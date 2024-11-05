using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Part5
{
    public class UserInput
    {
        public int GetUserInput()
        {
            int number;
            while (true)
            {
                Console.Write("Enter an integer : ");
                string input = Console.ReadLine();
                try
                {
                    number = int.Parse(input);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid inout. Enter a valid integer");
                }
            }
            return number;
        }

    }
}
