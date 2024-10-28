using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Assignments_on_Class_Objects
{
    public class Library
    {
        private List<Book> books;

        public Library()
        {
            books = new List<Book>();
        }
        public string AddBook(string title, string author, string isbn)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(author) || string.IsNullOrWhiteSpace(isbn))
                {
                    throw new ArgumentException("Title or author or isbn can't be empty");
                }
                Book newBook = new Book(title, author, isbn);
                books.Add(newBook);
                return $"Book {title} added to the library";
            }
            catch (ArgumentException ex)
            {
                return $"Error: {ex.Message}";
            }
        }

        public void RemoveBook(string isbn)
        {
            try
            {
                Book bookToRemove = books.Find(book => book.ISBN == isbn);
                if (bookToRemove != null)
                {
                    books.Remove(bookToRemove);
                    Console.WriteLine($"Book {bookToRemove.Title} removed from the library");
                }
                else
                {
                    throw new ArgumentException($"No book found with ISBN: {isbn}");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        public void DisplayBooks()
        {
            try
            {
                if (books.Count == 0)
                {
                    throw new ArgumentException("No books in the library");
                }
                Console.WriteLine("Books in the library: ");
                foreach (var book in books)
                {
                    Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, ISBN: {book.ISBN}");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
