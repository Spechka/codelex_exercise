using System;
using System.Collections.Generic;

namespace ListExercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            var colors = new List<string>
            {
                "Red",
                "Green",
                "Orange",
                "White",
                "Black"
            };

            bool white = colors.Contains("White");

            switch(white)
            {
                case false:
                    Console.WriteLine("The list doesn't contain 'White'");
                    break;
                case true:
                    Console.WriteLine("The list contains 'White'");
                    break;
            }
        }
    }
}
