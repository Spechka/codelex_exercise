using System;

namespace Exercise_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter minutes to convert them into a number of years and days.");

            decimal minutes = int.Parse(Console.ReadLine());

            Console.WriteLine($"years: {Math.Round((minutes / 525600), 6)}\nDays: {Math.Round(minutes / 1440, 6)}");
        }
    }
}
