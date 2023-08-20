using System;
using System.Collections.Generic;
using System.Linq;

namespace UniqueValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var values = new List<string> { "Hi", "Meow", "Hello", "Meow", "Hi!", "Meow", "Hi", "Bye" };

            var distinctValues = values.Distinct().ToList();

            var unique = distinctValues.Where(v => !distinctValues.Any(v2 => v != v2 && v2.Contains(v))).ToList();

            Console.WriteLine(string.Join(", ", unique));
        }
    }
}
