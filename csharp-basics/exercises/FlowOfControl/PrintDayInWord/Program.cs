using System;
using System.Linq.Expressions;

namespace PrintDayInWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a day number (0-6): ");
            int dayNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Nested-if method");

            if(dayNumber >= 0 && dayNumber <= 6)
            {
                if(dayNumber == 0)
                {
                    Console.WriteLine("Sunday");
                }
                else if(dayNumber == 1)
                {
                    Console.WriteLine("Monday");
                }
                else if (dayNumber == 2)
                {
                    Console.WriteLine("Tuesday");
                }
                else if(dayNumber == 3)
                {
                    Console.WriteLine("Wednesday");
                }
                else if(dayNumber == 4)
                {
                    Console.WriteLine("Thursday");
                }
                else if(dayNumber == 5)
                {
                    Console.WriteLine("Friday");
                }
                else if(dayNumber == 6)
                {
                    Console.WriteLine("Saturday");
                }
            }
            else
            {
                Console.WriteLine("You can only input numbers from 0 to 6!");
            }

            Console.WriteLine("Switch case default method");

            switch (dayNumber)
            {
                case 0:
                    Console.WriteLine("Sunday");
                    break;
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("You can only input numbers from 0 to 6!");
                    break;
            }
        }
    }
}
