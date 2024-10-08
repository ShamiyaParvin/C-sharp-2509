using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your annual salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            double taxableIncome = salary;
            double taxAmount = 0;

            if (age >= 60)
            {
                taxableIncome -= 5000;
            }

            if (taxableIncome < 10000)
            {
                taxAmount = 0;
            }
            else if (taxableIncome >= 10000 && taxableIncome <= 50000)
            {
                taxAmount = taxableIncome * 0.10;
            }
            else if (taxableIncome > 50000)
            {
                taxAmount = taxableIncome * 0.20;
            }

            Console.WriteLine($"The tax amount to be paid is: ${taxAmount:F2}");
            Console.ReadLine();
        }


    }
}

/*
 1)
 Console.WriteLine("Hello World!!");
 Console.WriteLine("enter your name: ");
 string name = Console.ReadLine();
 Console.WriteLine("Hello "+name);
 Console.ReadLine();


2)
Console.WriteLine("Enter full name:");
string name = Console.ReadLine();
Console.WriteLine("Enter your age:");
string age = Console.ReadLine();
Console.WriteLine($"Hello {name} ! You are {age} years old");
Console.WriteLine("What's your favourite color?");
string color = Console.ReadLine();
Console.WriteLine($"your favourite color is {color}");
Console.ReadLine();


3)
Console.WriteLine("Enter number1:");
string a = Console.ReadLine();
int num1 = Convert.ToInt32(a);
Console.WriteLine("Enter number2:");
string b = Console.ReadLine();
int num2 = Convert.ToInt32(b);

int sum = num1 + num2;
int difference = num1 - num2;
double mult = num1 * num2;
Console.WriteLine($"Sum is {sum}");
Console.WriteLine($"difference is {difference}");
Console.WriteLine($"Multiplication is {mult}");
if (num2 != 0)
{
    double div = num1 / num2;
    Console.WriteLine($"Division: {div}");
}
else
{
    Console.WriteLine("division by zero is not allowed");
}
Console.ReadLine();


4)
Console.WriteLine("Enter temperature:");
string a = Console.ReadLine();
int celcius = Convert.ToInt32(a);
double farenheit = ((celcius*9)/5) + 32);
Console.WriteLine($"Farenheit is {farenheit}");
Console.ReadLine();


5)
Console.WriteLine("Enter principle amount:");
string a = Console.ReadLine();
double p = Convert.ToDouble(a);

Console.WriteLine("Enter the rate of interest:");
string b = Console.ReadLine();
double r = Convert.ToDouble(b);

Console.WriteLine("Enter time in years");
string c = Console.ReadLine();
double t = Convert.ToDouble(c);

double simpleinterest = ((p*r*t)/100);
            
Console.WriteLine($"Simple Interest is {simpleinterest}");
    
Console.ReadLine();


6)
            Console.WriteLine("Enter the radius: ");
            string a = Console.ReadLine();
            double radius = Convert.ToDouble(a);
            const double Pi_ = 3.14159;
            double area = (Pi_ * radius * radius);
            Console.WriteLine($"Area is {area}");
            Console.ReadLine();


7)
            Console.WriteLine("Enter the number of seconds: ");
            string a = Console.ReadLine();
            int Totalseconds = Convert.ToInt32(a);
            int hours = (Totalseconds / 3600);
            int minutes = ((Totalseconds % 3600) / 60);
            int seconds = Totalseconds % 60;

            Console.WriteLine($"Time = {hours} hours, {minutes} minutes, {seconds} seconds");
            Console.ReadLine();


8)
            Console.WriteLine("Enter a string: ");
            string a = Console.ReadLine();
            int characters = a.Replace(" ", "").Length;
            
            Console.WriteLine($"Number of characters = {characters}");
            Console.ReadLine();


9)
            Console.WriteLine("Enter weight in kilograms: ");       
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter HEight in meters: ");
            double height = Convert.ToDouble(Console.ReadLine());
            double BMI = (weight / (height * height));
            Console.WriteLine($"BMI value is {BMI}");
            Console.ReadLine();


10)
            int number1 = 5;
            float number2 = 5.25f;
            double number3 = 9.8733526;
            char character1 = 'a';
            string string1 = "hello";
            bool bool1 = false;

            Console.WriteLine($"int: {number1}, type is {number1.GetType()}");
            Console.WriteLine($"float: {number2}, type is {number2.GetType()}");
            Console.WriteLine($"double: {number3}, type is {number3.GetType()}");
            Console.WriteLine($"char: {character1}, type is {character1.GetType()}");
            Console.WriteLine($"string: {string1}, type is {string1.GetType()}");
            Console.WriteLine($"bool: {bool1}, type is {bool1.GetType()}");
            Console.ReadLine();


11)
            Console.WriteLine("Enter the length of the rectangle:");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the breadth of the rectangle:");
            double width = Convert.ToDouble(Console.ReadLine());
            double rectangleArea = length * width;

            Console.WriteLine($"Area of the rectangle = {rectangleArea}");

            Console.WriteLine("Enter the radius of circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            const double Pi_ = 3.14159;
            double circleArea = Pi_ * radius * radius;

            Console.WriteLine($"Area of the circle is {circleArea}");
            Console.ReadLine();


12)
            const double PI = 3.14159;
            const int daysInweek = 7;
            Console.WriteLine("Enter the radius of circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double circumference = 2*PI*radius;

            Console.WriteLine($"Circumference of the circle is {circumference} and the number of days in a week = {daysInweek}");
            Console.ReadLine();


13)
           const double inchToCm = 2.54;

            Console.Write("Enter the width of the rectangle in inches: ");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the height of the rectangle in inches: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double areaInInches = width * height;
            double areaInCm = ((width * inchToCm) * (height * inchToCm));

            Console.WriteLine("The area of the rectangle is: ");
            Console.WriteLine($"{areaInInches} square inches");
            Console.WriteLine($"{areaInCm} square centimeters");
            Console.ReadLine();


14)
            Console.WriteLine("Enter name of the Employee: ");
            string employeeName = Console.ReadLine();
            Console.WriteLine("Enter the age of employee: ");
            int employeeAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter employee's monthly salary: ");
            int employeeSalary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Employee Information:");
            Console.WriteLine($"Name : {employeeName}");
            Console.WriteLine($"Age : {employeeAge}");
            Console.WriteLine($"Monthly salary : {employeeSalary}");
            Console.ReadLine();


15)
            int firstNumber = 5;
            int secondNumber = 3;
            int sum = firstNumber + secondNumber;
            Console.WriteLine($"Sum is {sum}");
            Console.ReadLine();



16)
            int number = 10;
            string name = "Shamiya";
            Console.WriteLine("Number: " + number);
            Console.WriteLine("Name is " + name);


17)
            Console.WriteLine("Enter the base value: ");
            double baseNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the exponent value: ");
            double exponentValue = Convert.ToDouble(Console.ReadLine());

            double power = Math.Pow(baseNumber, exponentValue);
            Console.WriteLine($"{baseNumber} raised to {exponentValue} is {power}");
            Console.ReadLine();


18)
            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your country: ");
            string citizen = Console.ReadLine().ToLower();

            if ((age >= 18) && (citizen=="india"))
            {
                Console.WriteLine("You are eligible to vote");
            }
            else
            {
                Console.WriteLine("You are not eligible to vote");
            }
            Console.ReadLine();


19)
            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your income in a year: ");
            double income = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Do you have any outstanding loans(yes/no)? ");
            string loanStatus = Console.ReadLine().ToLower();

            if ((age >= 21) && (income>=30000) && (loanStatus=="no"))
            {
                Console.WriteLine("You are eligible for this loan");
            }
            else
            {
                Console.WriteLine("You are not eligible for this loan");
            }
            Console.ReadLine();


20)
            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many years of work experience do you have(in years)? ");
            int workExperience = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you have a college degree(yes/no)? ");
            string collegeDegree = Console.ReadLine().ToLower();

            if ((18 <= age && age <= 35) && (workExperience>=2) && ((collegeDegree=="yes") || (workExperience>=5)))
            {
                Console.WriteLine("You are eligible to apply for this job");
            }
            else
            {
                Console.WriteLine("You are not eligible to apply for this job");
            }
            Console.ReadLine();


21)
            Console.WriteLine("Enter a character: ");
            char character = Console.ReadKey().KeyChar;
            character = char.ToLower(character);
            Console.WriteLine();

            if (character == 'a' || character == 'e' || character == 'i' || character =='o' || character == 'u')
            {
                Console.WriteLine($"{character} is a vowel");
            }
            else
            {
                Console.WriteLine($"{character} is a consonent");
            }
            Console.ReadKey();


22)
            Console.WriteLine("Enter a number: ");
            double number = Convert.ToDouble(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine($"{number} is a positive number.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"{number} is a negative number.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }
            Console.ReadLine();


23)
            Console.WriteLine("Enter a number: ");
            double number = Convert.ToDouble(Console.ReadLine());

            if (number%5==0 && number%11==0)
            {
                Console.WriteLine($"{number} is divisible by 5 and 11");
            }
            else
            {
                Console.WriteLine("The number is not divisible by both 5 and 11.");
            }
            Console.ReadLine();



24)
            Console.WriteLine("Enter first number: ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Select an operator (+,-,*,/): ");
            char operatorSelected = Console.ReadKey().KeyChar;
            Console.WriteLine();
            double result;

            if (operatorSelected == '+')
            {
                result = firstNumber + secondNumber;
                Console.WriteLine(result);
            }
            else if (operatorSelected == '-')
            {
                result = firstNumber - secondNumber;
                Console.WriteLine(result);
            }
            else if (operatorSelected == '*')
            {
                result = firstNumber * secondNumber;
                Console.WriteLine(result);
            }
            else if (operatorSelected == '/')
            {
                result = firstNumber / secondNumber;
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("invalid operator");
            }
            Console.ReadLine();



25)
            Console.WriteLine("Enter marks: ");
            int marks = Convert.ToInt32(Console.ReadLine());

            char grade;

            if (marks >= 90)
            {
                grade = 'A';
            }
            else if (marks >= 80)
            {
                grade = 'B';
            }
            else if (marks >= 70)
            {
                grade = 'C';
            }
            else if (marks >= 60)
            {
                grade = 'D';
            }
            else
            {
                grade = 'F';
            }

            Console.WriteLine($"grade is {grade}");

            Console.ReadLine();


26)
            Console.WriteLine("Enter first variable: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second variable: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Before swapping: {firstNumber}");
            Console.WriteLine(secondNumber);

            int temporaryVariable = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temporaryVariable;

            Console.WriteLine($"After swapping: {firstNumber}");
            Console.WriteLine(secondNumber);

            // without using third variable ==>
            Console.WriteLine("Enter first variable: ");
            int firstVariable = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second variable: ");
            int secondVariable = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Before swapping: {firstVariable}");
            Console.WriteLine(secondVariable);

            firstVariable = firstVariable + secondVariable;
            secondVariable = firstVariable - secondVariable;
            firstVariable = firstVariable - secondVariable;
            Console.WriteLine($"After swapping: {firstVariable}");
            Console.WriteLine(secondVariable);
            Console.ReadLine();

27)
            Console.Write("Enter the first number: ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());

            double sum = firstNumber + secondNumber;
            double subtraction = firstNumber - secondNumber;
            double multiplication = firstNumber * secondNumber;
            double division = firstNumber / secondNumber;
            double modulus = firstNumber % secondNumber;
            double incrementFirstNumber = ++firstNumber;
            double incrementSecondNumber = ++secondNumber;
            double decrementFirstNumber = --firstNumber;
            double decrementSecondNumber = --secondNumber;

            Console.WriteLine($"{firstNumber} + {secondNumber} = {sum}");
            Console.WriteLine($"{firstNumber} - {secondNumber} = {subtraction}");
            Console.WriteLine($"{firstNumber} * {secondNumber} = {multiplication}");
            Console.WriteLine($"{firstNumber} / {secondNumber} = {division}");
            Console.WriteLine($"{firstNumber} % {secondNumber} = {modulus}");
            Console.WriteLine($"Incrementing {firstNumber}: {incrementFirstNumber}");
            Console.WriteLine($"Incrementing {secondNumber}: {incrementSecondNumber}");
            Console.WriteLine($"decrementing {firstNumber}: {decrementFirstNumber}");
            Console.WriteLine($"decrementing {secondNumber}: {decrementSecondNumber}");

            Console.ReadLine();


28)
            Console.WriteLine("Enter the first number: ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the third number: ");
            double thirdNumber = Convert.ToDouble(Console.ReadLine());

            double average = (firstNumber + secondNumber + thirdNumber) / 3;

            Console.WriteLine($"The average is {average:F2}");

            Console.ReadLine();



29)
            double eur = 1;
            double usd = eur * 0.85;
            Console.Write("Enter amount in USD: ");
            double amountinUsd = Convert.ToDouble(Console.ReadLine());

            eur = usd * amountinUsd;
            Console.WriteLine("Amount in EUR="+eur);
            Console.ReadLine();


30)
            Console.WriteLine("Enter a number: ");
            int inputNumber = Convert.ToInt32(Console.ReadLine());

            if (inputNumber>=1 && inputNumber<=100)
            {
                Console.WriteLine($"{inputNumber} belong in the range of 1 and 100");
                if (inputNumber%2==0)
                {
                    Console.WriteLine($"{inputNumber} is even");
                }
                else
                {
                    Console.WriteLine($"{inputNumber} is odd");
                }
            }
            else
            {
                Console.WriteLine($"{inputNumber} doesn't belong in the range of 1 to 100");
            }
            Console.ReadLine();


31)
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine($"{number} is divisible by 3 and 5.");
            }
            else
            {
                Console.WriteLine($"{number} is not divisible by both 3 and 5.");
            }

            Console.ReadLine();



32)
            Console.WriteLine("ENter a year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if ((year%400==0) || ((year%100!=0) && (year%4==0)))
            {
                Console.WriteLine($"{year} is a Leap Year");
            }
            else
            {
                Console.WriteLine($"{year} is a Leap Year");
            }
            Console.ReadLine();



33)
            Console.WriteLine("Enter a number: ");
            Double number = Convert.ToDouble(Console.ReadLine());

            if (number > 0)
            {
                if (number % 2 == 0)
                {
                    if (number > 50)
                    {
                        Console.WriteLine($"{number} is positive, even, and greater than 50.");
                    }
                    else
                    {
                        Console.WriteLine($"{number} is positive and even but not greater than 50.");
                    }
                }
                else
                {
                    Console.WriteLine($"{number} is positive but not even.");
                }
            }
            else
            {
                Console.WriteLine($"{number} is not positive.");
            }
            Console.ReadLine();


34) Write a program that accepts the grades (marks) of a student in three subjects. The program
should determine the following:
1. If the student has passed in all subjects (passing mark is 40 in each subject).
2. If the student has passed, check if the average grade is 70 or above. If so, print
"Distinction".
3. If the student has not passed in any subject, print the number of subjects failed.

            int subject1, subject2, subject3;
            Console.Write("Enter marks for Subject 1: ");
            subject1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter marks for Subject 2: ");
            subject2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter marks for Subject 3: ");
            subject3 = Convert.ToInt32(Console.ReadLine());

            int passMark = 40;
            int failedSubjects = 0;

            if (subject1 < passMark) failedSubjects++;
            if (subject2 < passMark) failedSubjects++;
            if (subject3 < passMark) failedSubjects++;
            if (failedSubjects == 0)
            {
                double average = (subject1 + subject2 + subject3) / 3.0;
                if (average >= 70)
                {
                    Console.WriteLine("Congratulations! You have passed with Distinction.");
                }
                else
                {
                    Console.WriteLine("You have passed all subjects.");
                }
            }
            else
            {
                Console.WriteLine($"You have failed in {failedSubjects} subject(s).");
            }
            Console.ReadLine();


35) Write a program that calculates the tax to be paid based on the annual salary of an employee. The
tax rules are as follows:
1. If the salary is less than $10,000, no tax is applied.
2. If the salary is between $10,000 and $50,000, a 10% tax is applied.
3. If the salary is above $50,000, a 20% tax is applied.
4. If the employee is a senior citizen (aged 60 or above), they get an additional tax
exemption of $5,000 from their taxable income.
5. Your program should
 Prompt the user to enter their annual salary and age.
 Use nested if statements to calculate the appropriate tax based on the salary and age.
 Print the tax amount to be paid.


            Console.Write("Enter your annual salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            double taxableIncome = salary;
            double taxAmount = 0;

            if (age >= 60)
            {
                taxableIncome -= 5000;
            }

            if (taxableIncome < 10000)
            {
                taxAmount = 0;
            }
            else if (taxableIncome >= 10000 && taxableIncome <= 50000)
            {
                taxAmount = taxableIncome * 0.10;
            }
            else if (taxableIncome > 50000)
            {
                taxAmount = taxableIncome * 0.20;
            }

            Console.WriteLine($"The tax amount to be paid is: ${taxAmount:F2}");
            Console.ReadLine();


*/
