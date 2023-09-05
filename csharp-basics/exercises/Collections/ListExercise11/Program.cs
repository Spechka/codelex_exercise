using System;
using System.Collections.Generic;
using System.Linq;

namespace ListExercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            var values = new List<string>() { "Apple", "Banana", "Cherry", "Date", "Grape", "Lemon", "Mango", "Orange", "Peach", "Strawberry" };
            list.AddRange(values);

            list.Insert(4, "FIVE");

            var lastValue = list.Count - 1;
            list[lastValue] = "LAST";

            list.Sort();

            list.Contains("Foobar");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
