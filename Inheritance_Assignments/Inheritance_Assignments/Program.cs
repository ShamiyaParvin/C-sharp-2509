using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inheritance_Assignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lab 1.Single Inheritance
            //In Single Inheritance, a derived class inherits from a single base class.
            //Problem:
            //Create a base class Person with properties like Name and Age. Derive a class Student from
            //Person and add a property Grade. Create objects and display the data.

            //// Creating an object of the Person class
            //Person person1 = new Person("Shamiya", 23);
            //person1.Display();
            //// Creating an object of the Student class
            //Student student2 = new Student("Riya", 22, 85.5);
            //student2.DisplayStudent();
            //Console.ReadLine();


            //Lab 2.Multilevel Inheritance
            //In Multilevel Inheritance, a class is derived from another derived class.
            //Problem:
            //Create a base class Animal with a method Eat(). Derive a class Dog that inherits Animal and add
            //a method Bark(). Further derive a class Puppy from Dog and add a method Weep(). Show the
            //behavior.

            //Puppy pup1 = new Puppy();
            //pup1.Eat();
            //pup1.Bark();
            //pup1.Weep();
            //Console.ReadLine();


            //Lab 3.Multiple Inheritance(via Interfaces)
            //C# does not support multiple inheritance directly, but it can be achieved using interfaces.
            //Problem:
            //Create two interfaces IPrintable and IScannable with respective methods Print() and Scan().
            //Implement both interfaces in a class PrinterScanner.

            //PrinterScanner obj1 = new PrinterScanner();
            //obj1.Print();
            //obj1.Scan();
            //Console.ReadLine();


            //Lab 4.Hierarchical Inheritance
            //In Hierarchical Inheritance, multiple derived classes inherit from a single base class.
            //Problem:
            //Create a base class Shape with a method Draw(). Create two derived classes Circle and
            //Rectangle, both inheriting from Shape, and override the Draw() method to show specific
            //behavior.

            //Shape circle = new Circle();
            //Shape rectangle = new Rectangle();
            //circle.Draw();
            //rectangle.Draw();
            //Console.ReadLine();


            //Lab 5.Hybrid Inheritance(Using Interfaces)
            //Hybrid inheritance combines multiple types of inheritance.Since C# doesn't support direct
            //multiple inheritance, hybrid inheritance is implemented using interfaces.
            //Problem:
            //Create two interfaces IMovable and IRechargeable. Create a class Vehicle implementing
            //IMovable and derive ElectricCar from Vehicle implementing both interfaces.

            //ElectricCar car1 = new ElectricCar();
            //car1.Move();
            //car1.Recharge();
            //Console.ReadLine();


            //Lab 6.Overriding Methods in Inheritance
            //Demonstrate method overriding where a base class method is overridden in the derived class.
            //Problem:
            //Create a class Employee with a method Work(). Derive a class Manager that overrides the
            //Work() method to show a different implementation.

            //Employee employee = new Employee();
            //employee.Work();
            //Manager manager = new Manager();
            //manager.Work();
            //Console.ReadLine();


            //Lab 7.Abstract Classes
            //Create an abstract class and demonstrate inheritance with abstract methods.
            //Problem:
            //Create an abstract class Vehicle with an abstract method Drive(). Create two derived classes Car
            //and Bike that implement the Drive() method.

            //Vehicle_2 car = new Car();
            //car.Drive();
            //Vehicle_2 bike = new Bike();
            //bike.Drive();
            //Console.ReadLine();


            //Lab 8.Sealed Classes
            //Create a class that cannot be inherited using the sealed keyword.
            //Problem:
            //Create a sealed class MathOperations with a method Add(). Show that it cannot be inherited.

            //MathOperations obj1 = new MathOperations();
            //int sum = obj1.Add(5, 10);
            //Console.WriteLine(sum);
            //Console.ReadLine();


            //Lab 9.Constructor Chaining
            //Demonstrate how constructors are called in a class hierarchy.
            //Problem:
            //Create a base class Person with a parameterized constructor.Create a derived class Employee
            //that calls the base class constructor.

            //Employee_2 employee = new Employee_2("Shamiya", 101);
            //Console.ReadLine();


            //Lab 10.Interface Inheritance
            //Demonstrate that one interface can inherit from another.
            //Problem:
            //Create an interface IDriveable with a method Drive(). Create another interface IRaceable that
            //inherits from IDriveable and adds a method Race().

            //RaceableCar car = new RaceableCar();
            //car.Drive();
            //car.Race();
            //Console.ReadLine();


            //Lab 11. IS-A Relationship (Inheritance)
            //Problem:
            //Create a base class Animal with properties like Name and methods like Eat(). Create a derived class
            //Dog that inherits from Animal and adds its own method Bark(). Show how the IS-A relationship
            //works.

            //Dog_2 dog1 = new Dog_2();
            //dog1.Name = "Ron";
            //dog1.Eat();
            //dog1.Bark();
            //Console.ReadLine();


            //Lab 12.HAS - A Relationship(Composition)
            //Problem:
            //Create a class Engine with properties like HorsePower.Create a class Car that contains an instance
            //of Engine and shows the HAS-A relationship.Demonstrate how the Car can use its Engine to show
            //engine-related details.

            //Car_3 car = new Car_3("Toyota", 300);
            //car.ShowCarDetails();
            //Console.ReadLine();


            //Lab 13.Calling Base Class Method Using base
            //Problem:
            //Create a base class Person with a method DisplayInfo(). Derive a class Employee that overrides
            //DisplayInfo() but still calls the base class's DisplayInfo() using base.

            //Employee_3 employee = new Employee_3();
            //employee.Name = "Shamiya";
            //employee.Id = 100;
            //employee.DisplayInfo();
            //Console.ReadLine();


            //Lab 14.Accessing Base Class Variable Using base
            //Problem:
            //Create a base class Person with a property Name.In the derived class Student, hide the Name
            //property using the new keyword and use base to access the base class's Name property.

            //Student_1 student = new Student_1();
            //student.Name = "Shamiya";
            //student.Display();
            //Console.ReadLine();


            //Lab 15.Calling Base Class Constructor Using base
            //This assignment demonstrates how to use the base keyword to call the base class constructor
            //from the derived class constructor.

            //Problem:
            //Create a base class Vehicle with a constructor that accepts brand.Derive a class Car that passes
            //values to the base class constructor using base.

            //Car_ myCar = new Car_("Toyota", "Corolla");
            //Console.ReadLine();

        }
    }
}
