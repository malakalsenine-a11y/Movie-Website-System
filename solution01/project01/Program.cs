using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Movie Website System (Console App) Task:


            // Movies
            List<Movie> movies = new List<Movie>();     // قائشمة للافلام


            // انشاء الافلام m1,m2,m3
            Movie m1 = new Movie("Inception", "Sci-Fi", 2010, 9);
            Movie m2 = new Movie("Titanic", "Romance", 1997, 8);
            Movie m3 = new Movie("Interstellar", "Sci-Fi", 2014, 10);

            // يخزن الافلام داخل القائمة
            movies.Add(m1);
            movies.Add(m2);
            movies.Add(m3);

            //User

            User u1 = new User("Malak", 25);

            // Reviews
            List<Review> reviews = new List<Review>();

            Review r1 = new Review("Ali", "Inception", "Great movie!", 10);
            reviews.Add(r1)

                // Display Movies
            Console.WriteLine("\nMovies:");
            foreach (var m in movies)
            {
                Console.WriteLine($"{m.Title} - {m.Rating}");
            }
        }
    }
}
