using System;
using System.Collections.Generic;

namespace ListExercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            List<string> list = new List<string>() { "add", "some", "elements"};
            string[] colors = { "red", "blue", "green", "pink", "purple" };
            list.AddRange(colors);

            Console.WriteLine(string.Join(", ", list));
        }
    }
}
