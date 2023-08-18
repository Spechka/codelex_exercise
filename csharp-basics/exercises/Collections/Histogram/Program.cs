using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        private const string Path = "midtermscores.txt";

        private static void Main(string[] args)
        {
            List<string> readText = File.ReadAllText(Path).Split(' ').ToList();
            List<int> score = GetScore(readText);

            DisplayScore(score, 0, 9);
            DisplayScore(score, 10, 19);
            DisplayScore(score, 20, 29);
            DisplayScore(score, 30, 39);
            DisplayScore(score, 40, 49);
            DisplayScore(score, 50, 59);
            DisplayScore(score, 60, 69);
            DisplayScore(score, 70, 79);
            DisplayScore(score, 80, 89);
            DisplayScore(score, 90, 99);
            DisplayScore(score, 100, 100);

            Console.ReadKey();
        }

        public static List<int> GetScore(List<string> textInfo)
        {
            List<int> score = new List<int>();

            foreach (var input in textInfo)
            {
                score.Add(Int32.Parse(input));
            }

            return score;
        }

        public static void DisplayScore(List<int> scores, int min, int max)
        {
            string scoresInLimits = new string('*', scores.Where(
                score => score >= min && score <= max).Count());
            Console.WriteLine($"{min}-{max}: {scoresInLimits}");
        }
    }
}
