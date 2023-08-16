using System;
using System.Collections.Generic;
using System.Linq;

namespace UniqueValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ToDo: Given a non-empty list of strings, return a list that contains only unique (non-duplicate) strings.
            //ToDo: Example: ["abc", "xyz", "klm", "xyz", "abc", "abc", "rst"] → ["klm", "rst"]

            var values = new List<string> { "Hi", "Meow", "Hello", "Meow", "Hi!", "Meow", "Hi", "Bye" };

            var fixedValues = values.Distinct().ToList();

            Console.WriteLine(string.Join(", ", fixedValues));
        }
    }
}
