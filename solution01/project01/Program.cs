using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace project01
{
    // =======================
    // Movie Class
    // =======================
    class Movie
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public int Rating { get; set; }

        public Movie(string title, string genre, int year, int rating)
        {
            Title = title;
            Genre = genre;
            Year = year;

            if (rating < 1 || rating > 10)
                Rating = 5;
            else
                Rating = rating;
        }
    }

    // =======================
    // User Class
    // =======================
    class User
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public User(string name, int age)
        {
            Name = name;
            Age = age;

            Console.WriteLine($"Welcome {Name}!");
        }
    }


    // =======================
    // Review Class
    // =======================
    class Review
    {
        public string UserName { get; set; }
        public string MovieTitle { get; set; }
        public string Comment { get; set; }
        public int Rate { get; set; }

        public Review(string userName, string movieTitle, string comment, int rate)
        {
            UserName = userName;
            MovieTitle = movieTitle;
            Comment = comment;
            Rate = rate;
        }
    }
    // =======================
    // Program (YOUR CODE - NO CHANGES)
    // =======================
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
            reviews.Add(r1);

            // Display Movies
            Console.WriteLine("\nMovies:");
            foreach (var m in movies)
            {
                Console.WriteLine($"{m.Title} - {m.Rating}");
            }

            // Display Reviews
            Console.WriteLine("\nReviews:");
            foreach (var r in reviews)
            {
                Console.WriteLine($"{r.UserName} rated {r.MovieTitle}: {r.Rate} - {r.Comment}");
            }
        }
    }
}