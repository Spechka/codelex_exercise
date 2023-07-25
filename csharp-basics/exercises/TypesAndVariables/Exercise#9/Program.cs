using System;

namespace Exercise_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input distance in meters:");
            decimal meters = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Input hours:");
            decimal hours = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Input minutes:");
            decimal minutes = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Input seconds:");
            decimal seconds = decimal.Parse(Console.ReadLine());

            decimal totalTimeInSeconds = hours * 3600 + minutes * 60 + seconds;
            decimal speedInMetersPerSecond = meters / totalTimeInSeconds;
            decimal speedInKilometersPerHour = (meters / 1000) / (totalTimeInSeconds / 3600);
            decimal speedInMilesPerHour = (meters / 1609) / (totalTimeInSeconds / 3600);

            Console.WriteLine($"Your speed in meters/second is {speedInMetersPerSecond:F8}"); //':F8' format specifier that uses 8 decimal numbers. Math.Round but shorter
            Console.WriteLine($"Your speed in km/h is {speedInKilometersPerHour:F8}");
            Console.WriteLine($"Your speed in miles/h is {speedInMilesPerHour:F8}");
        }
    }
}
