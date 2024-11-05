using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Part5_Log4net
{
    internal class Program
    {
        public static void Divide(int a, int b)
        {
            try
            {
                int result = a / b;
                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException ex)
            {
                Logger.LogError("Attempted to divide by zero.", ex);
                Console.WriteLine("DivideByZeroException caught and logged.");
            }
        }

        static void Main(string[] args)
        {
            // Assignment 13.Logging Exceptions

            //Divide(10, 0);
            //Console.ReadLine();


            //Assignment 14.Identify the Need for User - Defined Exceptions, Create Them,
            //and Throw Them
            //Question: Create a custom exception NegativeNumberException to handle scenarios where a
            //negative number is passed to a method that only accepts positive numbers.Write code to throw
            //this exception if the number is negative.

            //NumberChecker checker = new NumberChecker();
            //try
            //{
            //    Console.WriteLine("Enter a positive number:");
            //    int number = Convert.ToInt32(Console.ReadLine());

            //    // Use CheckNumber to validate input
            //    checker.CheckNumber(number);
            //}
            //catch (NegativeNumberException ex)
            //{
            //    Console.WriteLine($"Error : {ex.Message}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"An unexpected error occured");
            //}
            //Console.ReadLine();


            //Assignment 15.Explain the Difference between Exception(Checked Exceptions)
            //and RuntimeException(Unchecked Exceptions)

            //1.File Reading with Exception Handling: 
            //o Create a class FileProcessor with a method ReadFileContent(string filePath). 
            //o In this method, attempt to read content from the file located at filePath using 
            //StreamReader. 
            //2.Math Operation with Exception Handling: 
            //o Create a class MathOperations with a method Divide(int a, int b). 
            //o This method should return the result of dividing a by b.
            //o Handle DivideByZeroException and print "Cannot divide by zero". 
            //3. Custom Exception for Age Validation: 
            //o Create a custom exception called InvalidAgeException that inherits from
            //Exception.
            //o Create a class Person with a property Age.
            //o Add a method SetAge(int age) in Person that throws an InvalidAgeException if 
            //age is less than 0 or greater than 120. 
            //o Print "Invalid age provided" if the exception is thrown.
            //4. Test Class: 
            //o Create a main class ExceptionDemo with the Main method.
            //o In the Main method: 
            // Create an instance of FileProcessor and call ReadFileContent() with a file
            //path that does not exist to trigger and handle the FileNotFoundException.
            // Create an instance of MathOperations and call Divide() with b as 0 to
            //trigger and handle the DivideByZeroException. 

            // Task 1: File Reading with Exception Handling
            FileProcessor fileProcessor = new FileProcessor();
            string filePath = "xyz.txt";
            fileProcessor.ReadFileContent(filePath);

            // Task 2: Math Operation with Exception Handling
            MathOperations mathOperations = new MathOperations();
            int a = 10;
            int b = 0;
            mathOperations.Divide(a, b);

            // Task 3: Custom Exception for Age Validation
            Person person = new Person();
            try
            {
                person.SetAge(-5); // Invalid age to trigger exception
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();




        }
    }
}
