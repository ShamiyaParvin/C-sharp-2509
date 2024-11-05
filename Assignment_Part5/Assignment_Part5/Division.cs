using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Part5
{
    public class Division
    {
        public void Divide()
        {
            try
            {
                Console.WriteLine("Enter the numerator : ");
                int numerator = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the denominator : ");
                int denominator = Convert.ToInt32(Console.ReadLine());
                int result = numerator / denominator;
                Console.WriteLine($"Result: {numerator} / {denominator} = {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division by zero is not allowed");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input format. Enter a valid integer");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occured: {ex.Message}");
            }
        }
    }
}
