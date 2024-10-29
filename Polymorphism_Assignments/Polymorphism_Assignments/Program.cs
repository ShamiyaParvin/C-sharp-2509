using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Assignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assignment 1: To demonstrate Polymorphism and its Advantages
            //Create a C# program demonstrating polymorphism by using a base class Shape and derived 
            //classes Circle and Rectangle.Each derived class should implement a method Draw(). Show
            //how polymorphism helps in calling the correct method based on the object type.

            //Shape myShape;
            //myShape = new Circle();
            //myShape.Draw();
            //// Creating a Rectangle object and calling the Draw method
            //myShape = new Rectangle();
            //myShape.Draw();
            //Console.ReadLine();


            //Assignment 2.Method Overloading and its uses
            //Create a C# program to show method overloading by implementing a Multiply method with 
            //different parameter types, numbers and order. 

            //Calculator calc = new Calculator();
            //Console.WriteLine("two integers: " + calc.Multiply(10, 5));
            //Console.WriteLine("three integers: " + calc.Multiply(2, 10, 5));
            //Console.WriteLine("Multiply two doubles: " + calc.Multiply(5.5, 4.0));
            //Console.WriteLine("Multiply int and double: " + calc.Multiply(3, 5.5));
            //Console.WriteLine("Multiply double and int: " + calc.Multiply(5.5, 3));
            //Console.ReadLine();


            //Assignment 3.Method Overriding
            //Write a program demonstrating method overriding by creating a base class Vehicle and a derived
            //class Car that overrides the Drive() method.

            //Vehicle myVehicle = new Vehicle();
            //myVehicle.Drive();
            //Car myCar = new Car();
            //myCar.Drive();
            //// Using base class reference to hold derived class object
            //Vehicle vehicle = new Car();
            //vehicle.Drive();
            //Console.ReadLine();


            //Assignment 4.Scenario of Overriding
            //Consider a scenario of payment processing where different payment methods(e.g.,
            //CreditCardPayment, PayPalPayment) override the ProcessPayment() method of a base class
            //Payment. Write a C# program to demonstrate this scenario. 

            //Payment payment;
            //// Using CreditCardPayment
            //payment = new CreditCardPayment();
            //payment.ProcessPayment();
            //// Using PayPalPayment
            //payment = new PayPalPayment();
            //payment.ProcessPayment();
            //Console.ReadLine();


            //Assignment 5.Polymorphism with Static Data and Methods.
            //Create a C# program that demonstrates polymorphism using a base class Employee and derived 
            //classes Manager and Developer.Include a static field to keep track of the total number of
            //employees and a static method to display the total count. Use method overriding to demonstrate
            //polymorphism, while also explaining the need for static members in this context.

            //Employee emp1 = new Manager();
            //Employee emp2 = new Developer();
            //emp1.DisplayInfo();
            //emp2.DisplayInfo();
            //// Displaying total number of employees
            //Employee.DisplayTotalEmployees();
            //Console.ReadLine();


            //Assignment 6.Polymorphism with Arrays as Properties in a Class
            //Create a C# program demonstrating polymorphism using a base class Employee and derived 
            //classes Manager and Developer.In this program, each employee should have a collection of
            //tasks(stored in an array) assigned to them.Use arrays as properties in the class to handle this
            //data, and demonstrate how polymorphism and arrays work together in the solution. (class - Employee2)

            ////Create instances of Manager and Developer and assign tasks
            //Manager2 manager = new Manager2();
            //manager.Tasks = new string[] { "Project planning", "conduct meeting" };
            //Developer2 developer = new Developer2();
            //developer.Tasks = new string[] { "Code", "test" };
            ////Demonstrating polymorphism:- each class calls its own ShowTasks method
            //Console.WriteLine("Displaying Tasks of each Employee:");
            //Employee2[] employees = { manager, developer };
            //foreach (var employee in employees)
            //{
            //    employee.ShowTasks();
            //    Console.WriteLine();
            //}
            //Console.ReadLine();


            //Assignment 7: Understanding Early Binding and Late Binding in C# 
            //Create a C# program that demonstrates early binding (compile-time polymorphism) using 
            //method overloading and late binding(runtime polymorphism) using method overriding. This
            //will help illustrate the differences between the two concepts in the context of polymorphism. 

            // Early Binding
            //Figure figure = new Figure();
            //double circleArea = figure.Area(5); // Calls the method for Circle
            //double rectangleArea = figure.Area(4, 6); // Calls the method for Rectangle
            //Console.WriteLine($"Area of Circle: {circleArea}");
            //Console.WriteLine($"Area of Rectangle: {rectangleArea}");
            //// Late Binding
            //Figure circle = new Circle2();
            //Figure rectangle = new Rectangle2();
            //circle.Display();
            //rectangle.Display();
            //Console.ReadLine();


            //Assignment 8.Achieving Runtime Polymorphism with Abstract Classes and
            //Interfaces in C# 
            //Create a C# program that demonstrates how runtime polymorphism is achieved using abstract 
            //classes and interfaces.Define an abstract class Shape and an interface IShape, implementing
            //these in derived classes to showcase polymorphism.  (class :- shape2)

            //Shape2 circle = new Circle3(5);
            //Shape2 rectangle = new Rectangle3(4, 2);
            //// Displaying details and area of the shapes
            //circle.Display();
            //Console.WriteLine($"Area of Circle: {circle.Area()}");
            //Console.WriteLine($"Perimeter of Circle: {((IShape)circle).Perimeter()}");
            //Console.WriteLine();
            //rectangle.Display();
            //Console.WriteLine($"Area of Rectangle: {rectangle.Area()}");
            //Console.WriteLine($"Perimeter of Rectangle: {((IShape)rectangle).Perimeter()}");
            //Console.ReadLine();


            //Assignment 9.Demonstrating the Need for Multiple Inheritance of Interfaces
            //Create a C# program that demonstrates the concept of multiple inheritance through interfaces. 
            //The program will define two interfaces, IMovable and IDrawable, and implement them in a class
            //Car that showcases how a class can inherit from multiple interfaces.

            //Car4 car = new Car4("Toyota");
            //car.Move(50);
            //car.Draw();
            //Console.ReadLine();


            //Assignment 10.Polymorphism in C# with Readonly Property 
            //Create a C# program that demonstrates polymorphism with a readonly property. Define a base 
            //class and derived classes where each class provides specific behavior for a method, while using a 
            //readonly property to ensure that certain values cannot be modified after initialization. (class :- Shape4)

            //// Create instances of Circle and Square
            //Shape4 myCircle = new Circle4(5);
            //Shape4 mySquare = new Square(4);
            //// Display the name and area of each shape
            //Console.WriteLine($"{myCircle.Name} Area: {myCircle.Area()}");
            //Console.WriteLine($"{mySquare.Name} Area: {mySquare.Area()}");
            //Console.ReadLine();

        }
    }
}
