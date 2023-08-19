using System;
using System.Linq;

namespace ReplaceSubstring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var words = new[] { "near", "speak", "tonight", "weapon", "customer", "deal", "lawyer" };

            var fixedWords = words.Select(c => c.Replace("ea", "*"));

            Console.WriteLine(string.Join(", ", fixedWords));
        }
    }
}
