using System.Collections.Generic;
using System;

namespace ListExercise2
{
    class Program
    {
        private static void Main(string[] args)
        {
            var colors = new List<string>();
            colors.Add("Red");
            colors.Add("Green");
            colors.Add("Orange");
            colors.Add("White");
            colors.Add("Black");

            for (int element = 0; element < colors.Count; element++) 
            {
                Console.WriteLine(colors[element]);
            }
        }
    }
}
