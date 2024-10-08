using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            int number = inputNumber;
            int digits = 0;
            int countDigits = 0;
            while (number != 0)
            {
                digits = number % 10;
                countDigits++;
                number /= 10;
            }

            Console.WriteLine($"Number of digits in {inputNumber} = {countDigits}");
            Console.ReadLine();
        }


    }
}



/*
1)
Write a C# program to print the multiplication table of a given number using the for loop.

            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Multiplication table of {number}:");

            int multiply = 1;
            for (int i=1; i<=10; i++)
            {
                multiply = number * i;
                Console.WriteLine($"{i} * {number} = {multiply}");
            }
            Console.ReadLine();


2) Write a C# program to display a right-angled triangle pattern using nested for loops.
            
            Console.WriteLine("Enter a number: ")
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i =0; i<number; i++)
            {
                for (int j=0; j<i+1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();


3) Sum of all even numbers between 1 and 100 using a while loop

            int sum = 0;
            int i = 2;
            while (i<=100)
            {
                sum = sum + i;
                i = i + 2;
            }
            Console.WriteLine($"Sum of all even numbers between 1 and 100 = {sum}");
            Console.ReadLine();

4) Write a C# program to print a multiplication table from 1 to 5 using nested while loops.
            int tableNumber = 1;
            int numbers = 1;
            int multiplication = 1;
            while (tableNumber<=5)
            {
                Console.WriteLine($"Multiplication Table of {tableNumber}: ");
                while(numbers<=10)
                {
                    multiplication = numbers * tableNumber;
                    Console.WriteLine($"{numbers} * {tableNumber} = {multiplication}");
                    numbers++;
                }
                numbers = 1;
                tableNumber++;
            }
            Console.ReadLine();

5) Write a C# program to keep asking the user to enter a positive number and print it. The program
should stop when the user enters a negative number.

            while(true)
            {
                Console.WriteLine("Enter a positive input number: ");
                int inputNumber = Convert.ToInt32(Console.ReadLine());
                if (inputNumber<0)
                {
                    Console.WriteLine("You entered a negative number!!");
                    break;
                }
                else
                {
                    Console.WriteLine($"You entered {inputNumber}");
                }
            }
            Console.ReadLine();

6) Write a C# program to create a basic menu-driven calculator using nested do-while loops. The
calculator should continue to ask the user for two numbers and an operation (+, -, *, /) until the
user chooses to exit.

            string exit;
            do
            {
                Console.WriteLine("Enter first number: ");
                double firstNumber = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter second number: ");
                double secondNumber = Convert.ToDouble(Console.ReadLine());

                do
                {
                    Console.WriteLine("Choose an operator(+,-,*,/): ");
                    char operation = Console.ReadKey().KeyChar;
                    Console.WriteLine();

                    if (operation == '+')
                    {
                        double sum = firstNumber + secondNumber;
                        Console.WriteLine(sum);
                        break;
                    }
                    else if (operation == '-')
                    {
                        double sub = firstNumber - secondNumber;
                        Console.WriteLine(sub);
                        break;
                    }
                    else if (operation == '*')
                    {
                        double multiplication = firstNumber * secondNumber;
                        Console.WriteLine(multiplication);
                        break;
                    }
                    else if (operation == '/')
                    {
                        if (secondNumber != 0)
                        {
                            double div = firstNumber / secondNumber;
                            Console.WriteLine(div);
                        }
                        else
                        {
                            Console.WriteLine("Division by zero can't be done");
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid operation");
                    }

                }
                while (true);

                Console.WriteLine("you want to exit(yes/no)? ");
                exit = Console.ReadLine().ToLower();

            }
            while (exit != "yes");

            Console.WriteLine("Exit");  
            Console.ReadLine();


7) Write a C# program to print all numbers from 1 to 100. Use the continue statement to skip
numbers that are divisible by 3, and use the break statement to stop the loop if the number
exceeds 50.

            for (int i=1; i<=100; i++)
            {
                if (i%3==0)
                {
                    continue;
                }
                if (i>50)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            Console.ReadLine();


8) Write a C# program to calculate the sum of all odd numbers between 1 and 100 using a for loop.

            int sum = 0;
            for (int i =1; i<=100; i++)
            {
                if (i%2 == 1)
                {
                    sum += i;
                }
                
            }
            Console.WriteLine("Sum of all odd numbers = " + sum);
            Console.ReadLine();

9) Write a C# program to calculate the factorial of a given number using a while loop.

            Console.WriteLine("Enter a Number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;
            int i = 1;
            while (i<=number)
            {
                factorial *= i;
                i++;
            }
            Console.WriteLine($"Factorial of {number} is {factorial}");
            Console.ReadLine();

10) Write a C# program to print a number pyramid using a nested while loop. Example for 5 rows:
1
2 2
3 3 3
4 4 4 4
5 5 5 5 5

            Console.WriteLine("Enter the number of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (i<=rows)
            {
                int j = 1;
                while (j<=i)
                {
                    Console.Write(i + " ");
                    j++;
                }
                Console.WriteLine();
                i++;
            }
            Console.ReadLine();

11) Write a C# program that generates a random number between 1 and 100. The user has to guess
the number, and the program should give hints ("too high" or "too low") until the user guesses
correctly. Use a nested do-while loop to allow the user to play multiple rounds.

            Random random = new Random();
            string playAgain;

            do
            {
                int randomNumber = random.Next(1, 101);
                int guess;
                int attempts = 0;

                Console.WriteLine("Selected a number between 1 and 100. Try to guess the number!");

                do
                {
                    Console.Write("Enter your guess: ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    attempts++;

                    if (guess > randomNumber)
                    {
                        Console.WriteLine("Too high!");
                    }
                    else if (guess < randomNumber)
                    {
                        Console.WriteLine("Too low!");
                    }
                    else
                    {
                        Console.WriteLine($"Correct! You guessed the number in {attempts} attempts.");
                    }

                } while (guess != randomNumber);

                Console.Write("Do you want to play again? (yes/no): ");
                playAgain = Console.ReadLine().ToLower();

            } while (playAgain == "yes");

            Console.WriteLine("Thank you for playing!");
            Console.ReadLine();

12) Write a C# program to create a simple calculator using a switch-case statement. The program
should handle addition, subtraction, multiplication, and division.

            double result;
            char operation;

            Console.WriteLine("Enter the first number: ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter an operation (+, -, *, /): ");
            operation = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.WriteLine("Enter the second number: ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());

            switch (operation)
            {
                case '+':
                    result = firstNumber + secondNumber;
                    Console.WriteLine($"{firstNumber} + {secondNumber} = {result}");
                    break;
                case '-':
                    result = firstNumber - secondNumber;
                    Console.WriteLine($"{firstNumber} - {secondNumber} = {result}");
                    break;
                case '*':
                    result = firstNumber * secondNumber;
                    Console.WriteLine($"{firstNumber} * {secondNumber} = {result}");
                    break;
                case '/':
                    if (secondNumber != 0)
                    {
                        result = firstNumber / secondNumber;
                        Console.WriteLine($"{firstNumber} / {secondNumber} = {result}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero can't be done");
                    }
                    break;
                default:
                    Console.WriteLine("Error: Invalid operation");
                    break;
            }

            Console.ReadLine();

13) Write a C# program that accepts a number from the user and calculates the sum of its digits using
a do-while loop.

            int sum = 0;
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            do
            {
                sum = sum + number % 10;
                number = number / 10;
            }
            while (number > 0);
            
            Console.WriteLine("The sum is" + sum);
            Console.ReadLine();

14) Write a C# program that accepts 10 numbers from the user and finds the largest number using a
for loop.

            int[] numbers = new int[10];
            int largest;
            Console.WriteLine("Enter 10 numbers:");

            for (int i = 0; i < 10; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            largest = numbers[0];

            for (int i = 0; i < 10; i++)
            {
                if (numbers[i]>largest)
                {
                    largest = numbers[i];
                }
                
            }
            Console.WriteLine($"Largest number is {largest}");
            Console.ReadLine();

15) Write a C# program to calculate the sum of squares of all numbers from 1 to a user-provided
number using a while loop.

            double sum = 0;
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (i<=number)
            {
                sum += (i * i);
                i++;
            }
            Console.WriteLine($"Sum of all number from 1 to {number} is {sum}");
            Console.ReadLine();

16) Write a C# program to simulate a countdown timer from 10 to 1 using a do-while loop,
displaying each second.

            int countDown = 10;
            do
            {
                Console.WriteLine(countDown);
                countDown--;
                Thread.Sleep(1000);
            }
            while (countDown >= 1);

            Console.WriteLine("Stop!!");
            Console.ReadLine();

17) Write a C# program to find and print the first multiple of 5 in a given list of numbers. Use the
break statement to exit the loop once a multiple of 5 is found.

            //Console.WriteLine("Enter numbers seperated by ',': ");
            //string input = Console.ReadLine();

            //int[] numbers = input.Split(',').Select(int.Parse).ToArray();

            int[] numbers = new int[] { 16, 2, 50, 8, 10, 11 };
            for (int i =0; i<numbers.Length; i++)
            {
                if (numbers[i]%5==0)
                {
                    Console.WriteLine("The first multiple of 5 is " + numbers[i]);
                    break;
                }
            }
            Console.ReadLine();

18) Write a C# program to print numbers from 1 to 20, but skip numbers that are divisible by 3 using
the continue statement.

             for (int i = 1; i<=20; i++)
            {
                if(i%3==0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.ReadLine();

19) Write a C# program to check if a given number is a palindrome using a while loop.

            Console.WriteLine("Enter a number to check if it is palindrome");
            int inputNumber = Convert.ToInt32(Console.ReadLine());

            int number = inputNumber;
            int reverse = 0;
            int digits = 0;
            while (number!=0)
            {
                digits = number % 10;
                reverse = (reverse * 10) + digits;
                number = number / 10;
            }
            if (reverse == inputNumber)
            {
                Console.WriteLine($"{inputNumber} is palindrome");
            }
            else
            {
                Console.WriteLine($"{inputNumber} is not palindrome");
            }
            Console.ReadLine();

20) Write a C# program to calculate the average of positive numbers entered by the user. The
program should stop when the user enters a negative number using a do-while loop.

            int numbers;
            int count = 0;
            int sum = 0;
            double average = 0;
            Console.WriteLine("Enter positive numbers (or a negative number to stop): ");
            do
            {
                numbers = Convert.ToInt32(Console.ReadLine());
                if (numbers >= 0)
                {
                    sum += numbers;
                    count++;
                }
            }
            while (numbers >= 0);

            if (count >0)
            {
                average = sum / count;
            }
            else
            {
                Console.WriteLine("No positive number entered");
            }
            Console.WriteLine("average = " + average);
            Console.ReadLine();

21) Write a C# program to reverse a given number using a do-while loop.

            Console.WriteLine("Enter a number: ");
            int inputNumber = Convert.ToInt32(Console.ReadLine());

            int number = inputNumber;
            int reverse = 0;
            int digits = 0;

            do
            {
                digits = number % 10;
                reverse = (reverse * 10) + digits;
                number = number / 10;
            }
            while (number != 0);
            Console.WriteLine($"Reverse of {inputNumber} is {reverse}");
            Console.ReadLine();

22) Write a C# program that presents a menu to the user for various string operations:
1. Reverse the string
2. Convert to uppercase
3. Convert to lowercase
4. Find the length of the string
Use a switch-case statement to implement this.

            Console.WriteLine("enter a string: ");
            string inputString = Console.ReadLine();
            Console.WriteLine("Choose any of the bellow operations");
            Console.WriteLine("1. Reverse the string\n2. Convert to uppercase\n3. Convert to lowercase\n4. Find the length of the string");

            Console.WriteLine("Choose an option from 1 to 4: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    string reversedString = "";
                    for (int i=inputString.Length-1; i>=0; i--)
                    {
                        reversedString += inputString[i];
                    }
                    Console.WriteLine($"Reversed string: {reversedString}");
                    break;

                case 2:
                    string upperString = inputString.ToUpper();
                    Console.WriteLine($"Converting to Uppercase: {upperString}");
                    break;
                case 3:
                    string lowerString = inputString.ToLower();
                    Console.WriteLine($"Converting to Lowercase: {lowerString}");
                    break;
                case 4:
                    int length = inputString.Length;
                    Console.WriteLine($"Length of the string: {length}");
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;

            }
            Console.ReadLine();

23) Write a C# program to print numbers from 1 to 50 but skip numbers that are divisible by 4 using
the continue statement.

            for (int i = 1; i<= 50; i++)
            {
                if (i%4==0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.ReadLine();

24) Write a C# program to print the first 10 numbers in the Fibonacci sequence using a for loop.

            // 0 1 1 2 3 5 8 13 21 .....

            int firstNumber = 0;
            int secondNumber = 1;
            
            for (int i = 0; i<10; i++)
            {
                Console.WriteLine(firstNumber + " ");
                int nextNumber = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = nextNumber;
            }
            Console.ReadLine();

25) Write a C# program to find all Armstrong numbers between 1 and 500 using a while loop. (An
Armstrong number is a number that is equal to the sum of the cubes of its digits).

            // 1 153 370 ....
            int number = 1;
            while (number <= 500)
            {

                int sumOfCubes = 0;
                int temp = number;

                while (temp > 0)
                {
                    int digit = temp % 10;
                    sumOfCubes += digit * digit * digit;
                    temp /= 10;
                }

                if (sumOfCubes == number)
                {
                    Console.WriteLine(number);
                }
                number++;
            }
            Console.ReadLine();


26) Write a C# program to create a menu-driven system for number conversions:
1. Binary to Decimal
2. Decimal to Binary
3. Decimal to Hexadecimal
Use a switch-case statement to implement this.

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Choose any one for this for Number convertion");
                Console.WriteLine("1. Binary to Decimal\n2. Decimal to Binary\n3. Decimal to Hexadecimal\n 4. Exit");
                Console.Write("Enter your choice (1-4): ");
                int choice = Convert.ToInt32(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter a binary number: ");
                        string binaryInput = Console.ReadLine();

                        bool binaryNumber = true;

                        for (int i = 0; i < binaryInput.Length; i++)
                        {
                            if (binaryInput[i] != '0' && binaryInput[i] != '1')
                            {
                                binaryNumber = false;
                                break;
                            }
                        }

                        if (binaryNumber)
                        {
                            int decimalOutput = Convert.ToInt32(binaryInput, 2);
                            Console.WriteLine($"Binary {binaryInput} to Decimal = {decimalOutput}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid binary number");
                        }
                        break;

                    case 2:
                        Console.WriteLine("Enter a decimal Number: ");
                        int decimalInput = Convert.ToInt32(Console.ReadLine());
                        string binaryOutput = Convert.ToString(decimalInput, 2);
                        Console.WriteLine($"Decimal {decimalInput} to Binary: {binaryOutput}");
                        break;

                    case 3:
                        Console.WriteLine("Enter a decimal Number: ");
                        decimalInput = Convert.ToInt32(Console.ReadLine());
                        string hexadecimalOutput = Convert.ToString(decimalInput, 16);
                        Console.WriteLine($"Decimal {decimalInput} to Hexa Decimal: {hexadecimalOutput}");
                        break;

                    case 4:
                        Console.WriteLine("Exiting");
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid choice! Please choose an option from 1-4");
                        break;
                }
            }
            Console.ReadLine();

27) Write a C# program to reverse a given string using a for loop.

            Console.WriteLine("Enter a string to be reversed: ");
            string inputString = Console.ReadLine();
            string reversed = "";
            for (int i = inputString.Length-1; i>=0; i--)
            {
                reversed += inputString[i];
            }
            Console.WriteLine(reversed);
            Console.ReadLine();

28) Write a C# program to count the number of vowels and consonants in a given string using a for
loop.

            Console.WriteLine("Enter a string: ");
            String inputString = Console.ReadLine().ToLower();

            int vowelsCount = 0;
            int consonentsCount = 0;
            for (int i =0; i<inputString.Length; i++)
            {
                if (inputString[i] == 'a' | inputString[i]=='e' | inputString[i]=='i' | inputString[i]=='o' | inputString[i]=='u')
                {
                    vowelsCount++;
                }
                else if (inputString[i]>='a' && inputString[i]<='z')
                {
                    consonentsCount++;
                }
            }
            Console.WriteLine($"Number of Consonents = {consonentsCount}\nNumber of Vowels = {vowelsCount}");
            Console.ReadLine();

29) Write a C# program to find the maximum and minimum of 5 numbers entered by the user using a
for loop.

            Console.WriteLine("Enter number 1: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int maxNumber = number;
            int minNumber = number;
            
            for (int i=2; i<=5 ; i++)
            {
                Console.WriteLine("Enter number " + i);
                number = Convert.ToInt32(Console.ReadLine());

                if (number>maxNumber)
                {
                    maxNumber = number;
                }
                else if (number<minNumber)
                {
                    minNumber = number;
                }
            }
            Console.WriteLine("Maximum number: " + maxNumber);
            Console.WriteLine("Minimum number: " + minNumber);
            Console.ReadLine();

30) Write a C# program to count the number of digits in a given number using a while loop.

            Console.WriteLine("Enter a number: ");
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            int number = inputNumber;
            int digits = 0;
            int countDigits = 0;
            while (number!=0)
            {
                digits = number % 10;
                countDigits++;
                number /= 10;
            }

            Console.WriteLine($"Number of digits in {inputNumber} = {countDigits}");
            Console.ReadLine();

*/
