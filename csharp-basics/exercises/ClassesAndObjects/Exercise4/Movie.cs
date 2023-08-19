using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    internal class Movie
    {
        private string _title;

        private string _studio;

        private string _rating;

        public Movie(string title, string studio, string rating)
        {
            _title = title;
            _studio = studio;
            _rating = rating;
        }

        public static Movie WithDefaultRating(string title, string studio)
        {
            return new Movie(title, studio, "PG");
        }

        public static Movie[] GetPG(Movie[] movies)
        {
            List<Movie> pgMovies = new List<Movie>();

            foreach (Movie movie in movies)
            {
                if (movie._rating == "PG")
                {
                    pgMovies.Add(movie);
                }
            }

            return pgMovies.ToArray();
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Title: {_title}, Studio: {_studio}, Rating: {_rating}");
        }

        public static void PrintMovies(Movie[] movies)
        {
            foreach (Movie film in movies)
            {
                film.PrintInfo();
            }
        }
    }
}
