using System;
using System.Collections.Generic;

namespace Exercise10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> stringSet = new HashSet<string>();

            stringSet.Add("Nintendo");
            stringSet.Add("Sony");
            stringSet.Add("Microsoft");
            stringSet.Add("Sega");
            stringSet.Add("Kojima Productions");

            Console.WriteLine("Items in the HashSet:\n");
            foreach (var item in stringSet)
            {
                Console.WriteLine(item);
            }

            stringSet.Clear();
            Console.WriteLine("\nItems removed from the HashSet.");

            stringSet.Add("Sega");
            stringSet.Add("Sega");

            Console.WriteLine("\nItems in the HashSet after adding a duplicated value:");
            foreach (var item in stringSet)
            {
                Console.WriteLine(item);
            }
        }
    }
}
