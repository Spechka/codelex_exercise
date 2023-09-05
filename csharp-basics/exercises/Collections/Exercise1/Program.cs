using System;
using System.Collections.Generic;

namespace Exercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            List<string> list = new List<string>() { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };

            Console.WriteLine(string.Join(", ", list));
            
            Console.WriteLine("=========================================");

            HashSet<string> set = new HashSet<string>() { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };

            Console.WriteLine(string.Join(", ", set));

            Console.WriteLine("=========================================");

            var dict = new Dictionary<string, string>()
            {
                { "USA", "Tesla" },
                { "Germany", "Audi, BMW, Mercedes, VolksWagen" },
                { "Japan", "Honda" }
            };

            Console.WriteLine(dict["USA"]);
            Console.WriteLine(dict["Germany"]);
            Console.WriteLine(dict["Japan"]);
        }
    }
}
