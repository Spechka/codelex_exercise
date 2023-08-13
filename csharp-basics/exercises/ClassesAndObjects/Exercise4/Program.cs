using System;

namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie movie = new Movie("Casino Royale", "Eon Productions", "PG-13");
            Movie movie_1 = new Movie("Glass", "Buena Vista International", "PG-13");
            Movie movie_2 = new Movie("Spider-Man: Into the Spider-Verse", "Columbia Pictures", "PG");

            Movie[] allMovies = new Movie[] { movie, movie_1, movie_2 };

            Movie[] pgMovies = Movie.GetPG(allMovies);

            Console.WriteLine("PG-rated Movies:");
            foreach (Movie film in pgMovies)
            {
                Console.WriteLine($"Title: {film.Title}, Studio: {film.Studio}, Rating: {film.Rating}");
            }
        }
    }
}
