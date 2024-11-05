using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Part5
{
    public class Library
    {
        public string[] books;
        private int booksCount = 0;
        public Library(int size)
        {
            books = new string[size];
        }
        public void AddBook(string title)
        {
            if (booksCount < books.Length)
            {
                books[booksCount] = title;
                booksCount++;
            }
            else
            {
                Console.WriteLine("Library is full");
            }
        }
        public void DisplayBooks()
        {
            Console.WriteLine("Books in the library:");
            foreach(var book in books)
            {
                Console.WriteLine(book);
            }
        }
    }
    public class Classroom
    {
        private string[,] seats;
        public Classroom(int rows, int columns)
        {
            seats = new string[rows, columns];
        }
        public void AssignSeat(int row, int column, string studentName)
        {
            if (row < seats.GetLength(0) && column < seats.GetLength(1))
            {
                seats[row, column] = studentName;
            }
            else
            {
                Console.WriteLine("Invalid seat position");
            }
        }
        public void DisplaySeating()
        {
            Console.WriteLine("Classroom seating Arragement: ");
            for (int i = 0; i < seats.GetLength(0); i++)
            {
                for (int j = 0; j < seats.GetLength(1); j++)
                {
                    Console.Write(seats[i, j] != null ? $"{seats[i, j],-10}" : "Empty     ");
                }
                Console.WriteLine();
            }
        }
    }
}
