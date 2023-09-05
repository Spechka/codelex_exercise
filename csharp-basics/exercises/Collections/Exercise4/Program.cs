using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            var names = "";

            while (true)
            {
                Console.WriteLine("Enter a Name:");
                names = Console.ReadLine();
                list.Add(names);

                if (names == "") break;
            }

            var uniqueNames = list.Distinct().ToList();
            Console.WriteLine($"Unique names :{string.Join(" ", uniqueNames)}");
        }
    }
}
