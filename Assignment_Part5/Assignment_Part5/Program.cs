using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Assignment_Part5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assignment 1.Identify the need for single and multidimensional arrays as
            //properties of a class
            //Question : Create a Library class to store and manage books in a single-dimensional array where
            //each element represents a book title.Also, use a two-dimensional array in a Classroom class
            //where each element represents the seat of a student based on rows and columns.

            //// Example for Library
            //Library library = new Library(5);
            //library.AddBook("Harry Potter");
            //library.AddBook("Twisted Games");
            //library.AddBook("The 5th season");
            //library.DisplayBooks();
            //// Example for Classroom
            //Classroom classroom = new Classroom(3, 3);
            //classroom.AssignSeat(0, 0, "Shamiya");
            //classroom.AssignSeat(1, 1, "Riya");
            //classroom.AssignSeat(2, 2, "Thabsi");
            //classroom.DisplaySeating();
            //Console.ReadLine();


            //Assignment 2.Identify the need for an array of objects
            //Question: Define a Movie class with properties like Title and Year.Create a MovieLibrary class
            //that stores an array of Movie objects and displays each movie’s information.

            //// Create a MovieLibrary with a maximum size of 3 movies
            //MovieLibrary myLibrary = new MovieLibrary(3);
            //// Add some movies to the library
            //myLibrary.AddMovie(new Movie("Tangled", 2012));
            //myLibrary.AddMovie(new Movie("Howl's Moving Castle", 1999));
            //myLibrary.AddMovie(new Movie("Spider Man", 2020));
            //// Try to add another movie beyond the library size
            //myLibrary.AddMovie(new Movie("The Godfather", 1972));
            //// Display all movies in the library
            //myLibrary.DisplayMovies();
            //Console.ReadLine();


            //Assignment 3.Identify the need for enumerations
            //Question: Create an enumeration OrderStatus with values Pending, Shipped, and Delivered.
            //Define an Order class with an OrderStatus property to manage the status of each order.

            //// Creating some orders with different statuses
            //Order order1 = new Order(101, OrderStatus.Pending);
            //Order order2 = new Order(102, OrderStatus.Shipped);
            //Order order3 = new Order(103, OrderStatus.Delivered);
            //// Display the status of each order
            //order1.DisplayOrderStatus();
            //order2.DisplayOrderStatus();
            //order3.DisplayOrderStatus();
            //// Update the status of an order and display it
            //order1.Status = OrderStatus.Shipped;
            //Console.WriteLine("Updated Order Status : ");
            //order1.DisplayOrderStatus();
            //Console.ReadLine();


            //Assignment 4.Identify the need for value types and reference types
            //Question: Create a Circle struct to represent a circle as a value type, and a Shape class to
            //represent a reference type.Show how changing values affects each.

            //// Demonstrate struct (Circle) as a value type
            //Circle circle1 = new Circle(5);
            //// Copies circle1 into circle2 (value type)
            //Circle circle2 = circle1;
            //Console.WriteLine("Original Circle:");
            //circle1.Display();
            //Console.WriteLine("Copied Circle before modification:");
            //circle2.Display();

            //// Modify circle2's radius
            //circle2.Radius = 10;
            //Console.WriteLine();
            //Console.WriteLine("After modifying Circle2's radius : ");
            //Console.WriteLine("circle1 (original) : ");
            //circle1.Display();
            //Console.WriteLine("circle2 (copy):");
            //circle2.Display();

            //// Demonstrate class Shape as a reference type
            //Shape shape1 = new Shape("Circle");
            //// shape2 references the same object as shape1 (reference type)
            //Shape shape2 = shape1;
            //Console.WriteLine("\nOriginal Shape:");
            //shape1.Display();
            //Console.WriteLine("Copied Shape before modification:");
            //shape2.Display();
            //// Modify shape2's name
            //shape2.Name = "Square";
            //Console.WriteLine("\nAfter modifying shape2's Name:");
            //Console.WriteLine("shape1 (original):");
            //shape1.Display();
            //Console.WriteLine("shape2 (reference):");
            //shape2.Display();
            //Console.ReadLine();



            //Assignment 5.Identify the need for pass by reference using ref keyword
            //Question: Create a method IncreaseScore that takes a ref integer parameter representing a
            //player’s score and increases it by 10.

            //int score = 50;
            //Console.WriteLine($"Initial score: {score}");
            //// Increase score by calling the method in ScoreManager
            //ScoreManager.IncreaseScore(ref score);
            //// Display the updated score
            //Console.WriteLine($"Updated Score: {score}");
            //Console.ReadLine();


            //Assignment 6.Identify the need for out parameters
            //Question: Create a method Divide that takes two integers, calculates their quotient and
            //remainder, and returns both values using the out keyword.

            //int dividend = 10;
            //int divisor = 3;
            //int quotient, remainder;
            //// Create an instance of the Calculator class
            //Calculator calculator = new Calculator();
            //// call the divide method
            //calculator.Divide(dividend, divisor, out quotient, out remainder);
            //// Display the results
            //Console.WriteLine($"Dividend: {dividend}, Divisor: {divisor}");
            //Console.WriteLine($"Quotient: {quotient}, Remainder: {remainder}");
            //Console.ReadLine();


            //Assignment 7.What is Exception and its Types
            //Question: Write a C# program that demonstrates a FileNotFoundException and an 
            //IndexOutOfRangeException. Explain what causes these exceptions.

            ////FileNotFoundException
            //try
            //{
            //    string filepath = "xyz.txt";
            //    string content = File.ReadAllText(filepath);
            //    Console.WriteLine(content);
            //}
            //catch (FileNotFoundException ex)
            //{
            //    Console.WriteLine($"Message : {ex.Message}");
            //}
            //// index out of range exception
            //try
            //{
            //    int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            //    Console.WriteLine($"sixth number: {numbers[5]}");
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine($"Message : {ex.Message}");
            //}
            //Console.ReadLine();


            //Assignment 8.How to Handle Exception
            //Question: Create a method GetUserInput that prompts the user to enter an integer. If the input is
            //invalid, catch the exception and prompt the user again until they enter a valid integer.

            //// create an instance of UserInput
            //UserInput myInput = new UserInput();
            //int userInput = myInput.GetUserInput(); // call method to get valid integer
            //Console.WriteLine("You enter integer : " + userInput);
            //Console.ReadLine();


            //Assignment 9.Multiple Catch Blocks
            //Question: Create a method that calculates the division of two integers. Use multiple catch blocks
            //to handle DivideByZeroException and FormatException. 

            //// Create an instance of the Division class
            //Division division = new Division();
            //division.Divide();
            //Console.ReadLine();


            //Assignment 10.Finally Block
            //Question: Write a method ReadFile that opens a file, reads its contents, and closes it. Use a 
            //finally block to ensure the file is closed, even if an exception occurs. 

            //// Create an instance of the FileHandler class
            //FileHandler fileHandler = new FileHandler();
            //// Specify the file path
            //string filePath = "file.txt";
            //// Call the ReadFile method
            //fileHandler.ReadFile(filePath);
            //Console.ReadLine();


            //Assignment 11.Difference between throw and throws
            //Question: Explain the purpose of the throw keyword in C#. Create a method ValidateAge that 
            //throws an exception if the age is below 18, and handle it in the calling method.

            //Age validator = new Age();
            //try
            //{
            //    Console.Write("Enter age : ");
            //    int age = Convert.ToInt32(Console.ReadLine());
            //    // call the validateage method
            //    validator.ValidateAge(age);
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine("Exception caught: " + ex.Message);
            //}
            //Console.ReadLine();


            //Assignment 12.Custom Exception
            //Question: Create a custom exception class NegativeNumberException to handle negative inputs.
            //Write a method CheckNumber that throws this exception if the number is negative.

            //NumberChecker checker = new NumberChecker();
            //try
            //{
            //    Console.Write("Enter a number: ");
            //    int number = Convert.ToInt32(Console.ReadLine());
            //    // Call the CheckNumber method
            //    checker.CheckNumber(number);
            //}
            //catch (NegativeNumberException ex)
            //{
            //    Console.WriteLine("Exception caught: " + ex.Message);
            //}
            //Console.ReadLine();


        }
    }
}
