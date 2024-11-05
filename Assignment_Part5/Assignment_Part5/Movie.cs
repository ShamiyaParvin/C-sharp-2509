using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Part5
{
    public class Movie
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public Movie(string title, int year)
        {
            Title = title;
            Year = year;
        }
        public void Display()
        {
            Console.WriteLine($"Title : {Title}, Year : {Year}");
        }
    }
    public class MovieLibrary
    {
        private Movie[] movieCollection;
        private int movieCount = 0;
        public MovieLibrary(int size)
        {
            movieCollection = new Movie[size];
        }
        public void AddMovie(Movie newMovie)
        {
            if (movieCount < movieCollection.Length)
            {
                movieCollection[movieCount] = newMovie;
                movieCount++;
            }
            else
            {
                Console.WriteLine("Movie library is full");
            }
        }
        public void DisplayMovies()
        {
            Console.WriteLine("Movies in the library : ");
            for (int i = 0; i < movieCount; i++)
            {
                movieCollection[i].Display();
            }
        }
    }
}