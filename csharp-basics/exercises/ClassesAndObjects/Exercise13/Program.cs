using System;
using System.Collections.Generic;

namespace Exercise13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================  First Drink");
            Smoothie s1 = new Smoothie(new List<string>() { "Banana" });

            Console.WriteLine($"Ingredients: {s1.Ingredients}"); // ➞ { "Banana" }
            Console.WriteLine($"Cost: £{s1.GetCost():F2}");   // ➞ "£0.50"
            Console.WriteLine($"Price: £{s1.GetPrice():F2}");  // ➞ "£1.25"
            Console.WriteLine($"Name: {s1.GetName()}");   // ➞ "Banana Smoothie"

            Console.WriteLine("\n=================  Second Drink");

            Smoothie s2 = new Smoothie(new List<string>() { "Raspberries", "Strawberries", "Blueberries" });

            Console.WriteLine($"Ingredients: {s2.Ingredients}"); // ➞ { "Raspberries", "Strawberries", "Blueberries" }
            Console.WriteLine($"Cost: £{s2.GetCost():F2}");   // ➞ "£3.50"
            Console.WriteLine($"Price: £{s2.GetPrice():F2}");  // ➞ "£8.75"
            Console.WriteLine($"Name: {s2.GetName()}");   // ➞ "Blueberry Raspberry Strawberry Fusion"

            Console.ReadKey();
        }
    }
}
