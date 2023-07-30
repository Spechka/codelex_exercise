using System;

namespace GetTheCentury
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a year between 1000 - 2010 to get the correct century:");
            int input = int.Parse(Console.ReadLine());
            int century = (input - 1) / 100 + 1;

            if (input >= 1000 && input <= 2010)
            {
                Console.WriteLine($"The year {input} is in the {century} century.");
            }
            else
            {
                Console.WriteLine("Input a year between 1000 - 2010.");
            }
        }
    }
}
