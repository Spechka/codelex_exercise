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

            var distinctValues = values.GroupBy(x => x)
                                       .Where(g => g.Count() == 1)
                                       .Select(g => g.Key)
                                       .ToList();

            foreach (var value in distinctValues)
            {
                Console.WriteLine(value);
            }
        }
    }
}
