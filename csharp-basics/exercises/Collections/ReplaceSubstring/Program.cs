using System;
using System.Linq;

namespace ReplaceSubstring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var words = new[] { "near", "speak", "tonight", "weapon", "customer", "deal", "lawyer" };

            var fixedWords = words.Select(c => c.Contains("ea") ? c.Replace("ea", "*") : c);

            Console.WriteLine(string.Join(", ", fixedWords));
        }
    }
}
