using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    internal class Movie
    {
        public string Title { get; set; }

        public string Studio { get; set; }

        public string Rating { get; set; }

        public Movie(string title, string studio, string rating)
        {
            Title = title;
            Studio = studio;
            Rating = rating;
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
                if (movie.Rating == "PG")
                {
                    pgMovies.Add(movie);
                }
            }

            return pgMovies.ToArray();
        }
    }
}
