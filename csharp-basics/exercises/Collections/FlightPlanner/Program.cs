using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace FlightPlanner
{
    class Program
    {
        private const string Path = "flights.txt";
        public static List<string> readText = File.ReadAllLines(Path).ToList();
        public static List<List<string>> information = new List<List<string>>();
        public static HashSet<Airport> ports = new HashSet<Airport>();
        public static List<Airport> route = new List<Airport>();

        private static void Main(string[] args)
        {
            SaveInfo();
            CreateAirports();
            Airport start;
            Airport current;

            DisplayCityes();
            Console.Write("Enter name of city where to start : ");
            string userInput = Console.ReadLine();
            Console.Clear();
            start = ports.Where(port => port.AirportName == userInput).First();
            start.DisplayDestinations();

            while (true)
            {
                Console.Write("Enter next destination : ");
                userInput = Console.ReadLine();
                Console.Clear();
                current = ports.Where(port => port.AirportName == userInput).First();
                route.Add(current);

                if (current.AirportName == start.AirportName)
                {
                    Console.Clear();
                    Console.WriteLine("You've reached the start!");
                    Console.WriteLine("-------- Route taken : ");
                    DisplayRoute();
                    break;
                }

                current.DisplayDestinations();
            }

            Console.ReadKey();
        }

        public static void SaveInfo()
        {
            for (int i = 0; i < readText.Count; i++)
            {
                information.Add(readText[i].Split(new string[] { " -> " }, StringSplitOptions.None).ToList());
            }
        }

        public static void CreateAirports()
        {
            for (int i = 0; i < information.Count; i++)
            {
                if (!ports.Any(p => p.AirportName == information[i][0]))
                {
                    ports.Add(new Airport(information[i][0]));
                }
            }

            foreach (var port in ports)
            {
                for (int i = 0; i < information.Count; i++)
                {
                    if (information[i][0] == port.AirportName)
                    {
                        port.AddDestination(ports.Where(
                            destination => destination.AirportName == information[i][1]).First());
                    }
                }
            }
        }

        public static void DisplayCityes()
        {
            foreach (var port in ports)
            {
                Console.WriteLine($"> {port.AirportName}");
            }

            Console.WriteLine("---------");
        }

        public static void DisplayRoute()
        {
            int counter = 1;
            foreach (var port in route)
            {
                Console.WriteLine($" {counter}.| {port.AirportName}");
                counter++;
            }
        }
    }
}
