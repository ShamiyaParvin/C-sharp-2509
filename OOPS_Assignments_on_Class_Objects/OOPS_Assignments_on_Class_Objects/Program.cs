using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static OOPS_Assignments_on_Class_Objects.Ecommerce;
using System.Xml.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Data;
using System.ComponentModel;
using System.Security.Principal;

namespace OOPS_Assignments_on_Class_Objects
{
    //C# Assignments on Classes & Objects

    //Assignment 1: Circle Class
    //Problem Statement: Create a Circle class with a property for Radius. Implement a getter to
    //retrieve the radius and a setter to ensure that the radius cannot be negative.

    class Circle
    {
        private double radius;
        public double Radius
        {
            get { return radius; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Radius cannot be negative");
                    radius = 0;
                }
                else
                {
                    radius = value;
                }
            }
        }
        public Circle(double radius)
        {
            Radius = radius;
        }
    }
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Circle circle1 = new Circle(5);
    //        Console.WriteLine("Circle 1 Radius is " + circle1.Radius);

    //        Circle circle2 = new Circle(-3);
    //        Console.WriteLine("Circle 2 Radius is " + circle2.Radius);

    //        Console.ReadLine();
    //    }
    //}

    //Assignment 2: Employee Class
    //Problem Statement: Design an Employee class with properties for Name and Salary.Use
    //getters and setters to manage access to the salary, ensuring it cannot be set to a negative value.

    class Employee
    {
        private string name;
        private double salary;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Salary
        {
            get { return salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Salary Cannot be negative");

                }
                salary = value;
            }
        }
        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }
    }

    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        try
    //        {
    //            Employee employee1 = new Employee("shamiya", 5000);
    //            Console.WriteLine("Employee name : " + employee1.Name);
    //            Console.WriteLine("Employee Salary : " + employee1.Salary);
    //        }
    //        catch (ArgumentException ex)
    //        {
    //            Console.WriteLine("Error: " + ex.Message);
    //        }
    //        try
    //        {
    //            Employee employee2 = new Employee("Riya", -6000);
    //        }
    //        catch (ArgumentException ex)
    //        {
    //            Console.WriteLine("Error: " + ex.Message);
    //        }
    //        Console.ReadLine();
    //    }
    //}

    //Assignment 3: Library Management System
    //Problem Statement: Design a library management system that manages books.Each book has a
    //title, author, and ISBN number.The system should allow adding a book, removing a book, and
    //displaying all books.

    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Library library = new Library();

    //        library.AddBook("The Great Gatsby", "F. Scott Fitzgerald", "9780");
    //        library.AddBook("To Kill a Mockingbird", "Harper Lee", "9781");

    //        library.DisplayBooks();

    //        library.RemoveBook("9780");

    //        library.DisplayBooks();

    //        library.RemoveBook("1234");

    //        library.RemoveBook("97800");
    //        library.DisplayBooks();

    //        Console.ReadLine();
    //    }
    //}

    //Assignment 4: Banking System
    //Problem Statement: Create a simple banking system that allows account creation and basic
    //transactions.Each account has an account number, account holder name, and balance. Implement
    //deposit and withdrawal methods.Use getters and setters to manage access to the balance,
    //ensuring it cannot be set to a negative value.

    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        BankAccount account = new BankAccount("1000234", "Shamiya", 1000);
    //        account.Deposit(500);
    //        account.Withdraw(200);
    //        account.Withdraw(1500);

    //        Console.ReadLine();
    //    }
    //}

    //Assignment 5: Student Management System
    //Problem Statement: Develop a student management system that stores student details.Each
    //student has a name, ID, and a list of grades.Implement methods to add a grade and calculate the
    //average grade.

    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Student student = new Student("Shamiya", "101");

    //        student.AddGrade(80);
    //        student.AddGrade(90);
    //        student.AddGrade(70);
    //        student.AddGrade(110);

    //        double average = student.CalculateAverageGrade();

    //        Console.WriteLine($"The average grade for {student.Name} (ID: {student.ID}) is {average}");

    //        Console.ReadLine();
    //    }
    //}

    //Assignment 6: Inventory System
    //Problem Statement: Create an inventory management system that manages items in a store.
    //Each item has a name, stock, and price. Implement methods to add, remove, and update items.
    //Use getters and setters to manage access to the stock and price, ensuring it cannot be set to a
    //negative value.

    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Inventory inventory = new Inventory();

    //        inventory.AddItem("phone", 50, 100);
    //        inventory.AddItem("TV", 40, 500);
    //        inventory.AddItem("Fridge", 30, 1000);

    //        Console.WriteLine("Items Now in Inventory : ");
    //        inventory.DisplayAllItems();

    //        inventory.RemoveItem("Phone");
    //        Console.WriteLine("After removing Phone, Items now : ");
    //        inventory.DisplayAllItems();

    //        inventory.UpdateStock("TV", 100);
    //        Console.WriteLine("After updating stocks for TV : ");
    //        inventory.DisplayAllItems();

    //        inventory.UpdatePrice("Fridge", 1500);
    //        Console.WriteLine("After updating price for Fridge : ");
    //        inventory.DisplayAllItems();

    //        Console.ReadLine();
    //    }
    //}

    //Assignment 7: E-commerce System

    //Problem Statement: Design an e-commerce system that manages products and orders.Each
    //product has a name, price, and stock quantity.Implement methods to create an order that reduces
    //stock quantity.Implement getters and setters to ensure that the price cannot be negative and the
    //stock cannot be less than zero.

    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Ecommerce.Product product1 = new Ecommerce.Product("phone", 1000, 10);
    //        Ecommerce.Product product2 = new Ecommerce.Product("tv", 400, 20);

    //        Ecommerce.Order order = new Ecommerce.Order();

    //        try
    //        {
    //            order.CreateOrder(product1, 2);
    //            order.CreateOrder(product2, 1);
    //            order.DisplayOrderDetails();
    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine($"Error: {ex.Message}");
    //        }

    //        Console.WriteLine($"Remaining stock for {product1.Name}: {product1.StockQuantity}");
    //        Console.WriteLine($"Remaining stock for {product2.Name}: {product2.StockQuantity}");

    //        Console.ReadLine();
    //    }
    //}

    //Assignment 8: Print Class
    //Problem Statement: Design a Print class that contains overloaded methods to print different
    //types of data: a string, an integer, and an array of integers.
    //in C # as a beginner firendly program easy to understand

    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Print printer = new Print();

    //        printer.PrintData("Hello, World!");

    //        printer.PrintData(10);

    //        int[] numbers = { 1, 2, 3, 4, 5 };
    //        printer.PrintData(numbers);

    //        Console.ReadLine();
    //    }
    //}

    //Assignment 9: Rectangle Class
    //Problem Statement: Create a Rectangle class with overloaded methods to calculate the area.
    //Implement methods that take either width and height or just one side length (for a square).

    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Rectangle rectangle = new Rectangle();

    //        double width = 5;
    //        double height = 10;
    //        double rectangleArea = rectangle.CalculateArea(width, height);
    //        Console.WriteLine($"Area of Rectangle = {rectangleArea}");

    //        double sideLength = 4;
    //        double squareArea = rectangle.CalculateArea(sideLength);
    //        Console.WriteLine($"Area of Square = {squareArea}");

    //        Console.ReadLine();
    //    }
    //}

    //Assignment 10: Time Class
    //Problem Statement: Create a Time class with overloaded methods to set the time.Implement
    //methods to set the time using hours and minutes, and another method to set the time using
    //seconds.
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Time time = new Time();

    //        time.SetTime(10, 30);
    //        time.DisplayTime();

    //        time.SetTime(3665);
    //        time.DisplayTime();

    //        Console.ReadLine();
    //    }
    //}

    //Assignment 11: Initializing a Static Field

    //Problem Statement: Create a class Bank that has a static field for the interest rate and a non -
    //static field for the account holder’s balance.Write a static constructor to initialize the interest
    //rate to a default value and a regular constructor for setting up the account balance.

    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Bank account1 = new Bank(1000);
    //        account1.DisplayAccountDetails();

    //        Bank.UpdateInterestRate(7);

    //        account1.DisplayAccountDetails();

    //        Console.ReadLine();
    //    }
    //}

    //Assignment 12: Counting Objects with Static and Instance Fields
    //Problem Statement: Create a class Car that counts how many instances of Car have been
    //created using a static counter.Initialize this counter using a static constructor.
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Number of Car : " + Car.GetCarCount());

    //        Car car1 = new Car();

    //        Car car2 = new Car();

    //        Car car3 = new Car();

    //        Console.WriteLine("Number of Car : " + Car.GetCarCount());

    //        Console.ReadLine();
    //    }
    //}


    //Assignment 13: Initializing Constants with Static Block
    //Problem Statement: Create a class MathOperations that initializes a static field representing the
    //value of Pi.Write a static constructor to assign this value.

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Pi = " + MathOperations.Pi);
    //        Console.ReadLine();
    //    }
    //}

    //Assignment 14: Initializing Configuration with Static Constructor
    //Problem Statement: Create a class Configuration to load system-wide settings(e.g., application
    //name) using a static constructor.Allow individual users to set preferences using an instance
    //constructor.

    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Displaying system-wide settings initialized by the static constructor
    //        Console.WriteLine($"Application Name: {Configuration.ApplicationName}");

    //        // Creating individual user configurations
    //        Configuration user1 = new Configuration("preference 1");
    //        user1.DisplayConfiguration();

    //        Configuration user2 = new Configuration("prefernce 2");
    //        user2.DisplayConfiguration();

    //        Console.ReadLine();
    //    }
    //}

    //Assignment15: Implementing and Understanding Copy Constructor
    //Problem Statement:
    //Write a C# program that implements a copy constructor. The program should:
    //1. Create a class with several fields.
    //2. Provide a constructor to initialize those fields.
    //3. Provide a copy constructor that allows the creation of a new object from an existing
    //object.
    //4. Demonstrate how the copy constructor works by comparing objects created using it with
    //objects created via direct assignment(which just copies references).

    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Creating an object using original constructor
    //        Person person1 = new Person("Riya", 22);
    //        Console.WriteLine("Original :");
    //        person1.DisplayInfo();

    //        // Creating an object using the copy constructor
    //        Person person2 = new Person(person1);
    //        Console.WriteLine("Copied :");
    //        person2.DisplayInfo();

    //        // Assigning person
    //        Person person3 = person1;
    //        Console.WriteLine("Assigned Person : ");
    //        person3.DisplayInfo();

    //        // Modifying the original object
    //        person1.Name = "Riya Rezlin";
    //        person1.Age = 26;

    //        // Showing the effect of modification on the copied and assigned objects
    //        Console.WriteLine("After modifying the original object:");
    //        Console.WriteLine("Original Person:");
    //        person1.DisplayInfo();

    //        Console.WriteLine("Copied person remaining unchanged : ");
    //        person2.DisplayInfo();

    //        Console.WriteLine("Assigned Person showing the changes : ");
    //        person3.DisplayInfo();

    //        Console.ReadLine();
    //    }
    //}

    //Assignment 16: Identifying the Need for Chained Constructors
    //Tasks:
    //1. Create a class named Car with the following:
    //o Fields for make, model, year, and price.
    //o Multiple constructors:
    // A constructor that initializes only the make.
    // A constructor that initializes make and model.
    // A constructor that initializes make, model, and year.
    // A constructor that initializes all fields: make, model, year, and price.
    //o Use constructor chaining to avoid duplicating the logic for initializing fields.
    //2. In the Main() method:
    //o Create several Car objects using different constructors.
    //o Display the details of each car to verify that all fields are initialized correctly.

    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Vehicle vehicle1 = new Vehicle("Toyota");
    //        Console.WriteLine("Vehicle 1:");
    //        vehicle1.Display();

    //        Console.WriteLine();

    //        Vehicle vehicle2 = new Vehicle("Honda", "Civic");
    //        Console.WriteLine("Vehicle 2:");
    //        vehicle2.Display();

    //        Console.WriteLine();

    //        Vehicle vehicle3 = new Vehicle("Toyota", "LC", 2020);
    //        Console.WriteLine("Vehicle 3:");
    //        vehicle3.Display();

    //        Console.WriteLine();

    //        Vehicle vehicle4 = new Vehicle("BMW", "X5", 2021, 10000);
    //        Console.WriteLine("Vehicle 4:");
    //        vehicle4.Display();
    //        Console.ReadLine();
    //    }
    //}


    //Assignment 17: Understanding the Need for Constructor Overloading
    //Problem Statement: 
    //Write a C# program that models a Product class with overloaded constructors. The class should: 
    //1. Provide flexibility in product initialization based on the availability of price and discount
    //information.
    //2. Use constructor overloading to handle cases where only basic product information is 
    //available, as well as cases where detailed information(price and discount) is provided.
    //Tasks: 
    //1. Create a class named Product with the following: 
    //o Fields for name, price, and discount.
    //o Three constructors: 
    // A constructor that initializes only the name.
    // A constructor that initializes name and price.
    // A constructor that initializes name, price, and discount. 
    //2. Implement a method CalculateFinalPrice() that computes the final price after applying
    //the discount (if applicable). 
    //3. In the Main() method: 
    //o Create different Product objects using various constructors.
    //o Display the details of each product, including the final price after any applicable
    //discount.

    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Product p1 = new Product("TV");
    //        Product p2 = new Product("laptop", 5000);
    //        Product p3 = new Product("phone", 3000, 10);
    //        Console.WriteLine("Product 1 : ");
    //        p1.Display();
    //        Console.WriteLine("Product 2 : ");
    //        p2.Display();
    //        Console.WriteLine("Product 3 : ");
    //        p3.Display();
    //        Console.ReadLine();
    //    }
    //}


    //Assignment 18: Exploring Different Ways to Initialize Objects
    //Problem Statement: 
    //Write a C# program that demonstrates different ways to initialize an object of a class. The class 
    //should represent a Product with properties such as Name, Price, and Category.Implement the
    //following methods of object initialization: 
    //1. Constructor initialization. 
    //2. Object initializer syntax.
    //3. Static factory method.
    //4. Anonymous types. 
    //5. Reflection.
    //6. Default values in constructors.
    //Tasks: 
    //1. Create a class named Product with the following: 
    //o Properties for Name, Price, and Category.
    //o A constructor that initializes all three properties.
    //o A static method to create a Product object. 
    //o Use reflection to dynamically create a Product object. 
    //o Implement a constructor that provides default values for the properties.
    //2. In the Main() method: 
    //o Create instances of the Product class using the different initialization techniques
    //mentioned above.
    //o Display the details of each product.

    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //1.Constructor initialization
    //        Product2 product1 = new Product2("TV", 250, "Electronics");
    //        Console.WriteLine("Constructor initialization");
    //        product1.Display();

    //        //2.Object initializer syntax
    //        Product2 product2 = new Product2 { Name = "Apple", Price = 20, Category = "Fruits" };
    //        Console.WriteLine("Object initializer syntax");
    //        product2.Display();

    //        //3.Static factory method
    //        Product2 product3 = Product2.CreateProduct("Orange", 25, "Fruits");
    //        Console.WriteLine("Static factory method");
    //        product3.Display();

    //        //4.Anonymous types
    //        var Anonymous = new { Name = "Fridge", Price = 150, Category = "Electronics" };
    //        Console.WriteLine("Anonymous types");
    //        Console.WriteLine($"Name : {Anonymous.Name}, Price : {Anonymous.Price}, Category : {Anonymous.Category}");

    //        //5.Reflection
    //        Type productType = typeof(Product2);
    //        Product2 product4 = (Product2)Activator.CreateInstance(productType, new object[] { "Laptop", 2500, "Electronics" });
    //        Console.WriteLine("Reflection");
    //        product4.Display();

    //        //6.Default values in constructors
    //        Product2 product5 = new Product2();
    //        Console.WriteLine("Default values in constructors");
    //        product5.Display();
    //        Console.ReadLine();
    //    }
    //}


    //Assignment 19: Exploring Initialization Using Tuples and Records
    //Problem Statement: 
    //Write a C# program that demonstrates object initialization using tuples and records. Create a 
    //simple model for Student with properties like Name, Age, and Grade.Use tuples and records to
    //initialize and work with this model.
    //Tasks: 
    //1. Create a Student class using the record keyword with properties Name, Age, and Grade.
    //2. Use tuples to store and retrieve student details. 
    //3. Create a method that accepts a tuple as a parameter and returns a Student record.
    //4. Display the details of the students.


    //internal class Program
    //{
    //    // Step 1: Create a Student record with properties Name, Age, and Grade
    //    public record Student(string Name, int Age, string Grade);

    //    // Step 3: Create a method that accepts a tuple as a parameter and returns a Student record
    //    public static Student CreateStudent((string Name, int Age, string Grade) studentTuple)
    //    {
    //        // Initialize the Student record using the tuple values
    //        return new Student(studentTuple.Name, studentTuple.Age, studentTuple.Grade);
    //    }

    //    static void Main(string[] args)
    //    {
    //        // Step 2: Use tuples to store and retrieve student details
    //        var student1Tuple = ("Alice", 20, "A");
    //        var student2Tuple = ("Bob", 21, "B");

    //        // Step 3: Create Student records using the tuples
    //        Student student1 = CreateStudent(student1Tuple);
    //        Student student2 = CreateStudent(student2Tuple);

    //        // Step 4: Display the details of the students
    //        Console.WriteLine("Student Details:");
    //        Console.WriteLine($"Name: {student1.Name}, Age: {student1.Age}, Grade: {student1.Grade}");
    //        Console.WriteLine($"Name: {student2.Name}, Age: {student2.Age}, Grade: {student2.Grade}");
    //    }
    //}

    //Assignment 20: Shopping Cart
    //Problem Statement: 
    //You need to create a Shopping Cart class that holds a list of Product objects.The Product class
    //will be a nested class. The system should allow users to add products to the cart and display the
    //total price.
    //Tasks: 
    //1. Create a ShoppingCart class that contains: 
    //o A list of Product objects.
    //o Methods to add products and calculate the total price.
    //2. Create a nested Product class with properties for Name, Price, and Quantity.
    //3. Demonstrate adding products and displaying the total price in the Main() method.
    //


    //internal class Program
    //{
    //    static void Main()
    //    {
    //        ShoppingCart cart = new ShoppingCart();

    //        cart.AddProduct(new ShoppingCart.Product("Bread", 10, 5));
    //        cart.AddProduct(new ShoppingCart.Product("Butter", 20, 2));
    //        cart.AddProduct(new ShoppingCart.Product("Milk", 60, 3));

    //        cart.DisplayCart();
    //        Console.ReadLine();
    //    }
    //}


    //Assignment 21: Banking System
    //Problem Statement: 
    //You need to create a Bank class that contains a list of Customer objects.Each Customer can have
    //multiple Account objects (nested class). Implement methods to add customers, add accounts, and
    //display customer account details.
    //Tasks: 
    //1. Create a Bank class with :
    //o A list of Customer objects.
    //o Methods to add customers and accounts, and to display customer details.
    //2. Create a nested Customer class with properties for Name and a list of accounts.
    //3. Create a nested Account class with properties for AccountNumber and Balance.
    //4. Demonstrate the functionality in the Main() method.


    //internal class Program
    //{
    //    static void Main()
    //    {
    //        Bank2 bank = new Bank2();

    //        bank.AddCustomer("Shamiya");
    //        bank.AddCustomer("Riya");

    //        bank.AddAccountToCustomer("Shamiya", 1234, 1000);
    //        bank.AddAccountToCustomer("Shamiya", 6543, 2000);
    //        bank.AddAccountToCustomer("Riya", 2222, 1500);
    //        bank.AddAccountToCustomer("Thabsi", 4444, 3000);
    //        bank.DisplayCustomerDetails();
    //        Console.ReadLine();
    //    }
    //}


    //Assignment 22: University System
    //Problem Statement: 
    //You need to create a University class that holds a list of Department objects.Each Department
    //can have multiple Course objects (nested class). Implement methods to add departments, add
    //courses, and display course information.
    //Tasks: 
    //1. Create a University class with :
    //o A list of Department objects.
    //o Methods to add departments and courses, and to display course details.
    //2. Create a nested Department class with properties for Name and a list of courses.
    //3. Create a nested Course class with properties for CourseName, CourseCode, and Credits.
    //4. Demonstrate the functionality in the Main() method.

    //class Program
    //{
    //    static void Main()
    //    {
    //        University university = new University();


    //        university.AddDepartment("CSE");
    //        university.AddDepartment("EEE");


    //        university.AddCourseToDepartment("CSE", "Java", "CS305", 5);
    //        university.AddCourseToDepartment("CSE", "Data Structures Algorithm", "CS302", 2);
    //        university.AddCourseToDepartment("EEE", "LSD", "EE301", 2);
    //        university.AddCourseToDepartment("EC", "LSD", "EC305", 3);

    //        university.DisplayCourseDetails();
    //        Console.ReadLine();
    //    }
    //}
}
