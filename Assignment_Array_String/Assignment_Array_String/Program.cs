using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment_Array_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //C# ASSIGNMENTS ON ARRAYS & STRINGS

            //Array Manipulations

            //Assignment 1.Write C# programs on Matrix addition, Matrix Multiplication and Matrix
            //Transpose.

            //// Addition ==>
            //Console.Write("Enter the number of rows: ");
            //int rows = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter the number of columns: ");
            //int columns = Convert.ToInt32(Console.ReadLine());

            //int[,] firstMatrix = new int[rows, columns];
            //Console.WriteLine("Enter elements to the First Matrix: ");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        Console.Write($"Element[{i}][{j}]: ");
            //        firstMatrix[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine("Matrix 1 : ");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        Console.Write($"{firstMatrix[i, j]}  ");
            //    }
            //    Console.WriteLine();
            //}

            //int[,] secondMatrix = new int[rows, columns];
            //Console.WriteLine("\nEnter elements to the second matrix: ");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        Console.Write($"Element[{i},{j}]: ");
            //        secondMatrix[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine("Matrix 2 : ");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        Console.Write($"{secondMatrix[i, j]}  ");
            //    }
            //    Console.WriteLine();
            //}

            //int[,] matrixAddition = new int[rows, columns];
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        matrixAddition[i, j] = firstMatrix[i, j] + secondMatrix[i, j];
            //    }
            //}
            //Console.WriteLine("Matrix Addition : ");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        Console.Write($"{matrixAddition[i, j]}  ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();

            // Matrix Multiplication ==>

            //Console.Write("Enter the number of rows for the first matrix: ");
            //int firstRows = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter the number of columns for the first matrix: ");
            //int firstColumns = Convert.ToInt32(Console.ReadLine());

            //int[,] firstMatrix = new int[firstRows, firstColumns];
            //Console.WriteLine("Enter elements for the First Matrix: ");
            //for (int i = 0; i < firstRows; i++)
            //{
            //    for (int j = 0; j < firstColumns; j++)
            //    {
            //        Console.Write($"Element[{i}][{j}]: ");
            //        firstMatrix[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("Matrix 1 : ");
            //for (int i = 0; i < firstRows; i++)
            //{
            //    for (int j = 0; j < firstColumns; j++)
            //    {
            //        Console.Write($"{firstMatrix[i, j]}  ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.Write("Enter the number of rows for the second matrix: ");
            //int secondRows = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter the number of columns for the second matrix: ");
            //int secondColumns = Convert.ToInt32(Console.ReadLine());

            //if (firstColumns != secondRows)
            //{
            //    Console.WriteLine("Matrix multiplication is not possible. The number of columns in the first matrix must equal the number of rows in the second matrix");
            //    return;
            //}

            //int[,] secondMatrix = new int[secondRows, secondColumns];
            //Console.WriteLine("\nEnter elements for the Second Matrix: ");
            //for (int i = 0; i < secondRows; i++)
            //{
            //    for (int j = 0; j < secondColumns; j++)
            //    {
            //        Console.Write($"Element[{i}][{j}]: ");
            //        secondMatrix[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("Matrix 2 : ");
            //for (int i = 0; i < secondRows; i++)
            //{
            //    for (int j = 0; j < secondColumns; j++)
            //    {
            //        Console.Write($"{secondMatrix[i, j]}  ");
            //    }
            //    Console.WriteLine();
            //}

            //int[,] matrixMultiplication = new int[firstRows, secondColumns];
            //for (int i = 0; i < firstRows; i++)
            //{
            //    for (int j = 0; j < secondColumns; j++)
            //    {
            //        matrixMultiplication[i, j] = 0;
            //        for (int k = 0; k < firstColumns; k++)
            //        {
            //            matrixMultiplication[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
            //        }
            //    }
            //}
            //Console.WriteLine("Matrix Multiplication : ");
            //for (int i = 0; i < firstRows; i++)
            //{
            //    for (int j = 0; j < secondColumns; j++)
            //    {
            //        Console.Write($"{matrixMultiplication[i, j]}  ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();

            // Matrix transpose ==>

            //Console.Write("Enter the number of rows: ");
            //int rows = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter the number of columns: ");
            //int columns = Convert.ToInt32(Console.ReadLine());

            //int[,] originalMatrix = new int[rows, columns];
            //Console.WriteLine("Enter elements for the Matrix: ");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        Console.Write($"Element[{i}][{j}]: ");
            //        originalMatrix[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("Original Matrix => ");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        Console.Write($"{originalMatrix[i, j]}  ");
            //    }
            //    Console.WriteLine();
            //}

            //int[,] transposedMatrix = new int[columns, rows];
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        transposedMatrix[j, i] = originalMatrix[i, j];
            //    }
            //}

            //Console.WriteLine("Transposed Matrix => ");
            //for (int i = 0; i < columns; i++)
            //{
            //    for (int j = 0; j < rows; j++)
            //    {
            //        Console.Write($"{transposedMatrix[i, j]}  ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();


            //Assignment 2.Write C# programs to sort an array using bubble sort and insertion sort.


            //int[] array = { 10, 24, 12, 30, 59, 32, 20, 60 };
            //Console.WriteLine("Original array : ");
            //foreach (var element in array)
            //{
            //    Console.Write(element + " ");
            //}
            //Console.WriteLine();

            //// bubble sort ==>
            //int n = array.Length;
            //for (int i = 0; i < n - 1; i++)
            //{
            //    for (int j = 0; j < n - i - 1; j++)
            //    {
            //        if (array[j] > array[j + 1])
            //        {
            //            int temp = array[j];
            //            array[j] = array[j + 1];
            //            array[j + 1] = temp;
            //        }
            //    }
            //}

            //Console.WriteLine("Sorted array using Bubble Sort:");
            //foreach (var element in array)
            //{
            //    Console.Write(element + " ");
            //}
            //Console.WriteLine();

            //// insertion sort ==>
            //for (int i = 1; i < n; i++)
            //{
            //    int key = array[i];
            //    int j = i - 1;
            //    while (j >= 0 && array[j] > key)
            //    {
            //        array[j + 1] = array[j];
            //        j--;
            //    }
            //    array[j + 1] = key;
            //}

            //Console.WriteLine("Sorted array using Insertion Sort:");
            //foreach (var item in array)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            //Console.ReadLine();


            //Assignment 3.Write C# programs to search an array using linear search and binary
            //search.

            //// Linear search
            //int[] arr = { 12, 34, 56, 23, 45, 67, 89, 10 };

            //Console.Write("Enter the element to search: ");
            //int target = Convert.ToInt32(Console.ReadLine());

            //bool found = false;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] == target)
            //    {
            //        Console.WriteLine($"Element {target} found at index {i}");
            //        found = true;
            //        break;
            //    }
            //}

            //if (!found)
            //{
            //    Console.WriteLine($"Element {target} not found in the array");
            //}
            //Console.ReadLine();


            //binary search ==>

            //int[] arr = { 10, 12, 23, 34, 45, 56, 67, 89 };

            //Console.Write("Enter the element to search: ");
            //int target = Convert.ToInt32(Console.ReadLine());

            //int left = 0;
            //int right = arr.Length - 1;

            //bool found = false;
            //while (left <= right)
            //{
            //    int mid = left + (right - left) / 2;

            //    if (arr[mid] == target)
            //    {
            //        Console.WriteLine($"Element {target} found at index {mid}");
            //        found = true;
            //        break;
            //    }
            //    else if (arr[mid] < target)
            //    {
            //        left = mid + 1;
            //    }
            //    else
            //    {
            //        right = mid - 1;
            //    }
            //}

            //if (!found)
            //{
            //    Console.WriteLine($"Element {target} not found in the array");
            //}
            //Console.ReadLine();


            //Assignment 4.Array Calculations: write C# programs for finding median, mode value,
            //highest, second highest and duplicate elements in an array.

            //int[] array = { 7, 3, 1, 1, 2, 9, 4, 6, 4, 4 };

            //// Finding Median
            //Array.Sort(array);
            //double median;
            //int n = array.Length;
            //if (n % 2 != 0)
            //{
            //    median = array[n / 2];
            //}
            //else
            //{
            //    median = (array[(n - 1) / 2] + array[n / 2]) / 2.0;
            //}
            //Console.WriteLine("Median = " + median);

            //// Finding Mode
            //Dictionary<int, int> frequency = new Dictionary<int, int>();
            //foreach (int num in array)
            //{
            //    if (frequency.ContainsKey(num))
            //    {
            //        frequency[num]++;
            //    }
            //    else
            //    {
            //        frequency[num] = 1;
            //    }
            //}
            //int mode = array[0];
            //int maxCount = 0;

            //foreach (var item in frequency)
            //{
            //    if (item.Value > maxCount)
            //    {
            //        maxCount = item.Value;
            //        mode = item.Key;
            //    }
            //}
            //Console.WriteLine($"Mode : {mode}");


            //// Finding Highest and Second Highest

            //int highest = array[array.Length - 1];
            //int secondHighest = array[array.Length - 2];
            //Console.WriteLine("Highest = " + highest);
            //Console.WriteLine("Second Highest = " + secondHighest);

            //// Finding Duplicates
            //List<int> duplicates = new List<int>();
            //foreach (var item in frequency)
            //{
            //    if (item.Value > 1)
            //    {
            //        duplicates.Add(item.Key);
            //    }
            //}
            //if (duplicates.Count > 0)
            //{
            //    Console.Write("Duplicates = ");
            //    foreach (int duplicate in duplicates)
            //    {
            //        Console.WriteLine(duplicate);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("No Duplicates found");
            //}
            //Console.ReadLine();



            // STRING MANIPULATIONS

            //Assignment 5.Write a C# programs to count vowels, consonants and special characters.

            //Console.WriteLine("Enter a string: ");
            //string inputString = Console.ReadLine();
            //inputString = inputString.ToLower();
            //int countVowels = 0;
            //int countConsonents = 0;
            //int countSpecialCharacter = 0;
            //foreach (var ch in inputString)
            //{
            //    if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            //    {
            //        countVowels++;
            //    }
            //    else if (ch >= 'a' && ch <= 'z')
            //    {
            //        countConsonents++;
            //    }
            //    else if (ch != ' ' && ch != '\t' && ch != '\n' && (ch < '0' || ch > '9'))
            //    {
            //        countSpecialCharacter++;
            //    }
            //}
            //Console.WriteLine($"Number of Vowels: {countVowels}");
            //Console.WriteLine($"Number of Consonents: {countConsonents}");
            //Console.WriteLine($"Number of Special characters: {countSpecialCharacter}");
            //Console.ReadLine();


            //Assignment 6.Write a C# program to reverse a string.

            //Console.WriteLine("Enter a string: ");
            //string inputString = Console.ReadLine();
            //string reversedString = "";
            //foreach (char ch in inputString)
            //{
            //    reversedString = ch + reversedString;
            //}
            //Console.WriteLine($"Reversed string : {reversedString}");
            //Console.ReadLine();


            //Assignment 7.Write a C# program to find substring occurrence within a main string.

            //Console.WriteLine("Enter a string: ");
            //string inputString = Console.ReadLine();
            //Console.WriteLine("Enter a substring to find the occurance with the string: ");
            //string subString = Console.ReadLine();
            //int count = 0;
            //int startIndex = 0;
            //while ((startIndex = inputString.IndexOf(subString, startIndex)) != -1)
            //{
            //    count++;
            //    startIndex += subString.Length;
            //}
            //Console.WriteLine($"Occurance of '{subString}' : {count}");
            //Console.ReadLine();


            //Assignment 8.Write a C# program to convert string to uppercase, lowercase, and title case.

            //Console.WriteLine("Enter a string to convert it into uppercase, lowercase and title case:");
            //string inputString = Console.ReadLine();

            //string upperCase = inputString.ToUpper();
            //Console.WriteLine("uppercase : " + upperCase);

            //string lowerCase = inputString.ToLower();
            //Console.WriteLine("Lowercase : " + lowerCase);

            //string[] words = inputString.Split(' ');

            //// Loop through the words and convert each word to title case
            //for (int i = 0; i < words.Length; i++)
            //{
            //    // Capitalize the first letter and make the rest lowercase
            //    if (words[i].Length > 0)
            //    {
            //        words[i] = Char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
            //    }
            //}

            //string titleCase = string.Join(" ", words);

            //// Output the title case result
            //Console.WriteLine($"Title Case: {titleCase}");
            //Console.ReadLine();

            //Assignment 9.Write a C# program to remove whitespace from a string.

            //Console.WriteLine("Enter a string : ");
            //string inputString = Console.ReadLine();
            //string resultString = "";
            //foreach (char ch in inputString)
            //{
            //    if (!char.IsWhiteSpace(ch))
            //    {
            //        resultString += ch;
            //    }
            //}
            //Console.WriteLine("After removing White Space : " + resultString);
            //Console.ReadLine();


            //Assignment 10.Write a C# program to replace all occurrences of a substring.

            //Console.WriteLine("Enter a string : ");
            //string inputString = Console.ReadLine();
            //Console.WriteLine("Enter a substring to replace : ");
            //string oldSubString = Console.ReadLine();
            //Console.WriteLine("Enter the new substring : ");
            //string newSubString = Console.ReadLine();
            //Console.WriteLine();
            //Console.WriteLine(inputString.Replace(oldSubString, newSubString));
            //Console.ReadLine();


            //Assignment 11.Write a C# program to find the longest word in a sentence.

            //Console.WriteLine("Enter a string : ");
            //string inputString = Console.ReadLine();

            //string[] words = inputString.Split(' ');
            //string longestWord = "";
            //int maxLength = 0;
            //foreach (string word in words)
            //{
            //    if (word.Length >= maxLength)
            //    {
            //        longestWord = word;
            //        maxLength = word.Length;
            //    }
            //}
            //Console.WriteLine("Longest word in this string : " + longestWord);
            //Console.ReadLine();


            //Assignment 12.Write a C# program to count words in a sentence.

            //Console.Write("Enter a string : ");
            //string inputString = Console.ReadLine();

            //string[] words = inputString.Split(' ');
            //int wordCount = 0;
            //foreach (string word in words)
            //{
            //    wordCount++;
            //}
            //Console.WriteLine("Total number of words = " + wordCount);
            //Console.ReadLine();


            //Assignment 13.Write a C# program to remove duplicate characters from a string.

            //Console.Write("Enter a string : ");
            //string inputString = Console.ReadLine();
            //string resultString = "";
            //foreach (char ch in inputString)
            //{
            //    if (!resultString.Contains(ch))
            //    {
            //        resultString += ch;
            //    }
            //}
            //Console.WriteLine("String after removing all duplicates : " + resultString);
            //Console.ReadLine();


            //Assignment 14.Write a C# program to check if two strings are anagrams.

            //Console.Write("Enter first string : ");
            //string string1 = Console.ReadLine();
            //Console.Write("Enter second string : ");
            //string string2 = Console.ReadLine();

            //string1 = string1.Replace(" ", "").ToLower();
            //string2 = string2.Replace(" ", "").ToLower();

            //char[] array1 = string1.ToCharArray();
            //char[] array2 = string2.ToCharArray();
            //Array.Sort(array1);
            //Array.Sort(array2);

            //bool isAnagram = true;
            //for (int i = 0; i < array1.Length; i++)
            //{
            //    if (array1[i] != array2[i])
            //    {
            //        isAnagram = false;
            //        break;
            //    }
            //}

            //if (isAnagram)
            //{
            //    Console.WriteLine("The strings are Anagram");
            //}
            //else
            //{
            //    Console.WriteLine("The strings are not Anagram");
            //}
            //Console.ReadLine();


            //Assignment 15.Write a C# program to find the frequency of each character in a string.

            //Console.WriteLine("Enter a string : ");
            //string inputstring = Console.ReadLine();
            //Dictionary<char, int> frequency = new Dictionary<char, int>();

            //foreach (char c in inputstring)
            //{
            //    if (frequency.ContainsKey(c))
            //    {
            //        frequency[c]++;
            //    }
            //    else
            //    {
            //        frequency[c] = 1;
            //    }
            //}

            //Console.WriteLine("Character Frequency ==>");
            //foreach (var item in frequency)
            //{
            //    Console.WriteLine($"Character : {item.Key} = {item.Value} times");
            //}
            //Console.ReadLine();


            //Assignment 16.Write a C# program to find the first non-repeating character in a string.

            //Console.WriteLine("Enter a string:");
            //string inputString = Console.ReadLine();

            //Dictionary<char, int> frequency = new Dictionary<char, int>();
            //foreach (char c in inputString)
            //{
            //    if (frequency.ContainsKey(c))
            //    {
            //        frequency[c]++;
            //    }
            //    else
            //    {
            //        frequency[c] = 1;
            //    }
            //}
            //char firstNonRepeating = '\0';
            //bool found = false;
            //foreach (char c in inputString)
            //{
            //    if (frequency[c] == 1)
            //    {
            //        firstNonRepeating = c;
            //        found = true;
            //        break;
            //    }
            //}
            //if (found == true)
            //{
            //    Console.WriteLine($"The first non-repeating character is: {firstNonRepeating}");
            //}
            //else
            //{
            //    Console.WriteLine("No non-repeating character found");
            //}

            //Console.ReadLine();


            //Assignment 17.Write a C# program to reverse words in a sentence.

            //string sentence = "Hello world";
            //string[] words = sentence.Split(' ');
            //for (int i = 0; i < words.Length; i++)
            //{
            //    char[] wordArray = words[i].ToCharArray(); // Convert each word to char array
            //    Array.Reverse(wordArray); // Reverse the char array (word)
            //    words[i] = new string(wordArray); // Convert the char array back to string
            //}

            //Array.Reverse(words);

            ////Join the words back together to form the final sentence
            //string reversedSentence = string.Join(" ", words);

            //// Output the reversed sentence
            //Console.WriteLine($"Reversed sentence: {reversedSentence}");
            //Console.ReadLine();


            // Assignment 18.Write a C# program to check if a string contains only digits.

            //Console.Write("Enter a string: ");
            //string input = Console.ReadLine();

            //bool isOnlyDigits = true;
            //foreach (char c in input)
            //{
            //    if (!char.IsDigit(c))
            //    {
            //        isOnlyDigits = false;
            //        break;
            //    }
            //}
            //if (isOnlyDigits)
            //{
            //    Console.WriteLine("The string contains only digits");
            //}
            //else
            //{
            //    Console.WriteLine("The string contains characters other than digits");
            //}
            //Console.ReadLine();

        }
    }
}