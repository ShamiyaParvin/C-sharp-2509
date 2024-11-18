using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Assignment_Part7.Calculator;

namespace Assignment_Part7
{
    internal class Program
    {

        //Assignment 1.Anonymous Types
        //Question: 
        //Create an anonymous type to represent a book with properties for Title, Author, and Price.
        //Display the details of the book.

        //static void Main(string[] args)
        //{
        //    var book = new
        //    {
        //        Title = "Harry Potter",
        //        Author = "J K Rowling",
        //        Price = 1000
        //    };
        //    // Displaying the details of the book
        //    Console.WriteLine("Book Details:");
        //    Console.WriteLine($"Title: {book.Title}");
        //    Console.WriteLine($"Author: {book.Author}");
        //    Console.WriteLine($"Price: {book.Price}");
        //    Console.ReadLine();
        //}



        //Assignment 2.Var and Dynamic
        //Question:
        //1.Declare a var variable to hold a list of integers, add some numbers to it, and print them.
        //2.Declare a dynamic variable, assign different types of values to it, and observe the
        //behavior.

        //static void Main(string[] args)
        //{
        ////1. using var
        //var numbers = new List<int>();
        //numbers.Add(5);
        //numbers.Add(10);
        //numbers.Add(30);
        //// Printing the list of numbers
        //Console.WriteLine("List of Numbers (var):");
        //foreach (var number in numbers)
        //{
        //    Console.WriteLine(number);
        //}

        ////2. using dynamic
        //dynamic data = 100; // integer
        //Console.WriteLine("Dynamic Variable Example:");
        //Console.WriteLine($"Data (int): {data}");
        //data = "Hello, World!"; // Now it's a string
        //Console.WriteLine($"Data (string): {data}");
        //data = true; // Now it's a boolean
        //Console.WriteLine($"Data (boolean): {data}");
        //Console.ReadLine();
        //}



        //Assignment 3.Delegates
        //Question:
        //Create a simple calculator using delegates.Define a delegate OperationDelegate that can
        //represent different arithmetic operations(addition, subtraction, multiplication, division).
        //Implement methods for each operation and allow the user to select an operation to perform on
        //two input numbers.
        //Requirements: 
        //1.Define a delegate called OperationDelegate that takes two double parameters and returns
        //a double result.
        //2.Implement methods for addition, subtraction, multiplication, and division.
        //3.Use the delegate to call the selected method.
        //4.Allow the user to input two numbers and choose an operation.
        //5.Display the result of the operation.

        //static void Main(string[] args)
        //{
        //Console.Write("Enter the first number: ");
        //double num1 = Convert.ToDouble(Console.ReadLine());

        //Console.Write("Enter the second number: ");
        //double num2 = Convert.ToDouble(Console.ReadLine());

        //Console.WriteLine("Choose an operation:");
        //Console.WriteLine("1. Addition");
        //Console.WriteLine("2. Subtraction");
        //Console.WriteLine("3. Multiplication");
        //Console.WriteLine("4. Division");
        //Console.Write("Enter your choice (1-4): ");
        //int choice = Convert.ToInt32(Console.ReadLine());

        //// Declare the delegate variable
        //Calculator.OperationDelegate operation;
        //switch (choice)
        //{
        //    case 1:
        //        operation = new OperationDelegate(Add);
        //        break;
        //    case 2:
        //        operation = new OperationDelegate(Sub);
        //        break;
        //    case 3:
        //        operation = new OperationDelegate(Multiplication);
        //        break;
        //    case 4:
        //        operation = new OperationDelegate(Divide);
        //        break;
        //    default:
        //        Console.WriteLine("Invalid choice");
        //        return;
        //}
        //double result = operation.Invoke(num1, num2);
        //Console.WriteLine($"Result: {result}");
        //Console.ReadLine();
        //}



        //Assignment 4.Events
        //Question:
        //Create an event called OnCompleted in a class Process. Raise the event when a process is 
        //completed.Subscribe to the event from the main program to display a message.

        //static void Main(string[] args)
        //{
        //Process process = new Process();
        //process.OnCompleted += (sender, e) =>
        //{
        //    Console.WriteLine("Process completed successfully!");
        //};
        //process.StartProcess();
        //Console.ReadLine();
        //}



        //Assignment 5.Anonymous Methods
        //Question: 
        //Write a delegate GreetDelegate that takes a string parameter. Assign an anonymous method to
        //the delegate that prints a greeting message.

        //delegate void GreetDelegate(string name);

        //static void Main(string[] args)
        //{
        //GreetDelegate greet = delegate (string name)
        //{
        //    Console.WriteLine($"Hello, {name}");
        //};
        //greet("Shamiya");
        //Console.ReadLine();
        //}



        //Assignment 6.Lambda Expressions
        //Question: 
        //Write a lambda expression that takes two integers and returns their product. Use Func<int, int,
        //int> for the delegate type.

        //static void Main(string[] args)
        //{
        //Func<int, int, int> multiply = (a, b) => a * b;
        //int num1 = 3;
        //int num2 = 5;
        //Console.WriteLine($"{num1} * {num2} = {multiply(num1, num2)}");
        //Console.ReadLine();

        //}


        //Assignment 7.Expression Tree
        //Question: 
        //Create an expression tree for a lambda expression that adds two integers.Compile and execute
        //the expression.

        //static void Main(string[] args)
        //{
        //string input = "Hello!!";
        ////creating instance of the delegate
        //StringOperationDelegate upperDelegate = StringOperations.ConvertUpper;
        //StringOperationDelegate reverseDelegate = StringOperations.ReverseString;
        //StringOperationDelegate prefixDelegate = StringOperations.AddPrefix;
        ////Using delegates to call each method
        //Console.WriteLine("Original String: " + input);
        //Console.WriteLine("Uppercase: " + upperDelegate(input));
        //Console.WriteLine("Reversed: " + reverseDelegate(input));
        //Console.WriteLine("With Prefix: " + prefixDelegate(input));
        //Console.ReadLine();
        //}



        //Assignment 8.Using Delegates to Hold Methods with the Same Signature
        //Question:
        //Create a delegate called StringOperationDelegate that accepts a string parameter and returns a
        //string.Write three different methods that modify the string in different ways(e.g., convert to
        //uppercase, reverse, add a prefix). Use the delegate to call each method. 

        //static void Main(string[] args)
        //{
        //string input = "Hello!!";
        ////creating instance of the delegate
        //StringOperationDelegate upperDelegate = StringOperations.ConvertUpper;
        //StringOperationDelegate reverseDelegate = StringOperations.ReverseString;
        //StringOperationDelegate prefixDelegate = StringOperations.AddPrefix;
        ////Using delegates to call each method
        //Console.WriteLine("Original String: " + input);
        //Console.WriteLine("Uppercase: " + upperDelegate(input));
        //Console.WriteLine("Reversed: " + reverseDelegate(input));
        //Console.WriteLine("With Prefix: " + prefixDelegate(input));
        //Console.ReadLine();
        //}



        //Assignment 9.Lambda Expressions to Filter and Process Lists
        //Question:
        //Given a list of products with properties Name and Price, use lambda expressions to:
        //1.Filter the list to find products that cost more than $50.
        //2.Sort the list by price in descending order. 
        //3.Select and display only the names of products from the filtered list.

        //static void Main(string[] args)
        //{
        //List<Product> products = new List<Product>
        //{
        //    new Product("Laptop", 100),
        //    new Product("tv", 10),
        //    new Product("mouse", 70),
        //    new Product("Tablet", 90),
        //    new Product("hear phone", 20),
        //    new Product("charger", 10),
        //    new Product("watch", 50),
        //    new Product("phone", 80)
        //};

        ////lambda expression to filter products with price > 50
        //var filteredProducts = products.Where(p => p.Price > 50).ToList();

        ////Sorting the filtered list by price in descending order
        //var sortedProducts = filteredProducts.OrderByDescending(p => p.Price).ToList();

        ////Select only the names of the products from the sorted list
        //var productName = sortedProducts.Select(p => p.Name).ToList();

        //Console.WriteLine("Products that costs more than $50, sorted: ");
        //foreach (var product in productName)
        //{
        //    Console.WriteLine(product);
        //}
        //Console.ReadLine();
        //}



        //Assignment 10.Delegate as a Callback Mechanism
        //Question:
        //Create a delegate called CalculationDelegate that takes two integers and returns an integer. 
        //Implement methods for addition and subtraction, and write a method Calculate that accepts two
        //integers and a delegate as parameters.Use the delegate to perform addition and subtraction
        //operations by passing different methods.

        //static void Main(string[] args)
        //{
        ////Use the delegate for addition
        //CalculationDelegate addDelegate = Calculation.Add;
        //int addResult = Calculation.Calculate(10, 5, addDelegate); 
        //Console.WriteLine($"Addition: 10 + 5 = {addResult}");

        //CalculationDelegate subDelegate = Calculation.Sub;
        //int subResult = Calculation.Calculate(10, 5, subDelegate);
        //Console.WriteLine($"Subtraction: 10 - 5 = {subResult}");
        //Console.ReadLine();
        //}



        //Assignment 11.Introduction to Asynchronous Programming
        //Question: 
        //Write a C# program that simulates a long-running operation using Task.Delay() and runs 
        //asynchronously. Display a message before and after the operation completes.

        // creating an async method
        //static async Task LongRunningOperation()
        //{
        //    Console.WriteLine("Operation started.....");
        //    await Task.Delay(2000);
        //    Console.WriteLine("Operation completed");
        //}

        //static async Task Main(string[] args)
        //{
        //    Console.WriteLine("Program started");
        //    await LongRunningOperation();
        //    Console.WriteLine("Program ended");
        //    Console.ReadLine();
        //}



        //Assignment 12. Async and Await Keywords
        //Question: 
        //Create a method that downloads data from a sample URL asynchronously.Use HttpClient to
        //fetch the data and print the length of the content.The method should use async and await
        //keywords.

        //public static async Task DownloadDataAsync(string url)
        //{
        //    // Create an instance of HttpClient
        //    using (HttpClient client = new HttpClient())
        //    {
        //        try
        //        {
        //            Console.WriteLine("Downloading data...");

        //            // Use async and await to download data
        //            string content = await client.GetStringAsync(url);

        //            // Print the length of the content
        //            Console.WriteLine($"Data downloaded successfully. Length of content: {content.Length} characters.");
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine($"An error occurred: {ex.Message}");
        //        }
        //    }
        //}

        //static async Task Main(string[] args)
        //{
        //    // Sample URL to download data from
        //    string url = "https://jsonplaceholder.typicode.com/posts";

        //    await DownloadDataAsync(url);
        //    Console.ReadLine();
        //}


        //Assignment 13. Task and Task<T>
        //Question: 
        //Write a C# program that calculates the sum of an array of integers asynchronously using 
        //Task<int>.Return the result from the asynchronous method and display it.

        //static async Task<int> CalculateSumAsync(int[] numbers)
        //{
        //    return await Task.Run(() =>
        //    {
        //        int sum = 0;
        //        foreach (int number in numbers)
        //        {
        //            sum += number;
        //        }
        //        return sum;
        //    });
        //}
        //static async Task Main(string[] args)
        //{
        //    int[] numbers = { 10, 20, 30 };
        //    Console.WriteLine("Calculating sum...");
        //    int sum = await CalculateSumAsync(numbers);
        //    Console.WriteLine($"The sum of the array is {sum}");
        //    Console.ReadLine();
        //}



        //Assignment 14. Handling Exceptions in Asynchronous Methods
        //Question: 
        //Modify the previous example to handle exceptions that might occur during the sum calculation.
        //Catch the exception in the Main method and display an error message. 

        //static async Task<int> CalculateSumAsync(int[] numbers)
        //{
        //    return await Task.Run(() =>
        //    {
        //        if (numbers==null || numbers.Length == 0)
        //        {
        //            throw new ArgumentException("Array is empty");
        //        }
        //        int sum = 0;
        //        foreach (int number in numbers)
        //        {
        //            sum += number;
        //        }
        //        return sum;
        //    });
        //}
        //static async Task Main(string[] args)
        //{
        //    int[] numbers = { 10, 20, 30 };
        //    try
        //    {
        //        Console.WriteLine("Calculating sum..");
        //        int sum = await CalculateSumAsync(numbers);
        //        Console.WriteLine($"The sum is {sum}");
        //    }
        //    catch (ArgumentException ex)
        //    {
        //        Console.WriteLine("Error: " + ex.Message);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Error: " + ex.Message);
        //    }
        //    Console.ReadLine();
        //}



        //Assignment 15. Parallel Programming with Task Parallel Library(TPL)
        //Question: 
        //Create a program that runs multiple tasks in parallel to simulate multiple operations, such as 
        //calculating the factorial of different numbers.Print the result of each task when completed.

        //static int Factorial(int number)
        //{
        //    int result = 1;
        //    for (int i = 1; i <= number; i++)
        //    {
        //        result *= i;
        //    }
        //    return result;
        //}

        //static async Task Main(string[] args)
        //{
        //    int[] numbers = { 5, 6, 7, 3 };
        //    //list of tasks to calculate factorials in parallel
        //    Task[] tasks = new Task[numbers.Length];
        //    Console.WriteLine("Factorials : ");
        //    for (int i = 0;i < numbers.Length;i++)
        //    {
        //        int num = numbers[i];
        //        tasks[i] = Task.Run(() =>
        //        {
        //            int result = Factorial(num);
        //            Console.WriteLine($"Fcatorial of {num} = {result}");
        //        });
        //    }
        //    //wait for all tasks to complete
        //    await Task.WhenAll(tasks);
        //    Console.WriteLine("All factorials calculated");
        //    Console.ReadLine();
        //}



        //Assignment 16. LINQ Query Syntax and Method Syntax
        //Question: Write a LINQ query using both query syntax and method syntax to retrieve all
        //numbers greater than 5 from a list of integers.

        //static void Main(string[] args)
        //{
        //    List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        //    // using linq query
        //    var queryResult = from num in numbers where num > 5 select num;
        //    Console.WriteLine("Using query syntax: ");
        //    foreach (var num in queryResult)
        //    {
        //        Console.WriteLine(num);
        //    }
        //    Console.WriteLine();

        //    // linq method syntax
        //    var methodResult = numbers.Where(num => num > 5);
        //    Console.WriteLine("Using method syntax : ");
        //    foreach (var num in methodResult)
        //    {
        //        Console.WriteLine(num);
        //    }
        //    Console.ReadLine();
        //}



        //Assignment 17. LINQ Operators(Select, Where, GroupBy, Join, etc.)
        //Question 1: Given a list of strings representing student names, write a LINQ query that selects
        //the names starting with the letter 'A' and orders them alphabetically.

        //static void Main(string[] args)
        //{
        //    List<string> names = new List<string> { "Shamiya", "Riya", "Akhil", "Ava", "John" };

        //    var namesFiltered = names.Where(name => name.StartsWith("A")).OrderBy(name => name);
        //    Console.WriteLine("Names staing with 'A' : ");
        //    foreach (var name in namesFiltered)
        //    {
        //        Console.WriteLine(name);
        //    }
        //    Console.ReadLine();
        //}



        //Assignment 18. LINQ to Objects
        //Question: Write a LINQ query to find the sum of all even numbers in an array of integers.

        //static void Main(string[] args)
        //{
        //    List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        //    var result = numbers.Where(x => x % 2 == 0).Sum();
        //    Console.WriteLine($"Sum of all even numbers : {result}");
        //    Console.ReadLine();
        //}



        //Assignment 19. LINQ to XML
        //Question: Create an XML document representing a list of books, and use LINQ to XML to
        //query the titles of books published after 2015.


        //static void Main(string[] args)
        //{
        //    // create xml document with a list of books
        //    XDocument books = new XDocument(
        //        new XElement("Books",
        //            new XElement("Book",
        //                new XElement("Title", "Harry Potter"),
        //                new XElement("Author", "JK Rowling"),
        //                new XElement("Year", 2014)
        //            ),
        //            new XElement("Book",
        //                new XElement("Title", "Twisted Games"),
        //                new XElement("Author", "Ana Huang"),
        //                new XElement("Year", 2019)
        //            ),
        //            new XElement("Book",
        //                new XElement("Title", "Pride and Prejudice"),
        //                new XElement("Author", "Jane Austen"),
        //                new XElement("Year", 2020)
        //            )
        //        )
        //    );

        //    var booksAfter2015 = from book in books.Descendants("Book")
        //                         where (int)book.Element("Year") > 2015
        //                         select book.Element("Title").Value;
        //    Console.WriteLine("Books published after 2015: ");
        //    foreach (var title in booksAfter2015)
        //    {
        //        Console.WriteLine(title);
        //    }
        //    Console.ReadLine();
        //}


    }
}
