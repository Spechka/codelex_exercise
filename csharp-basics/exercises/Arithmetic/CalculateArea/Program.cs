using System;

namespace CalculateArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int userChoice = 0;

            while (userChoice != 4)
            {
                userChoice = GetMenu();
                switch (userChoice)
                {
                    case 1:
                        CalculateCircleArea();
                        break;
                    case 2:
                        CalculateRectangleArea();
                        break;
                    case 3:
                        CalculateTriangleArea();
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("\nPlease only choose from 1 - 4");
                        break;
                }
            }
        }

        public static int GetMenu()
        {
            int userChoice;

            Console.WriteLine("Geometry Calculator\n");
            Console.WriteLine("1. Calculate the Area of a Circle");
            Console.WriteLine("2. Calculate the Area of a Rectangle");
            Console.WriteLine("3. Calculate the Area of a Triangle");
            Console.WriteLine("4. Quit\n");
            Console.Write("Enter your choice (1-4): ");

            userChoice = int.Parse(Console.ReadKey().KeyChar.ToString());

            return userChoice;
        }

        public static void CalculateCircleArea()
        {
            Console.WriteLine("\nWhat is the circle's radius? ");
            decimal radius = decimal.Parse(Console.ReadLine());

            if (radius > 0)
            {
                Console.WriteLine("The circle's area is " + Geometry.AreaOfCircle(radius));
            }
            else
            {
                Console.WriteLine("Only positive numbers!");
            }
        }

        public static void CalculateRectangleArea()
        {
            decimal length = 0;
            decimal width = 0;

            Console.WriteLine("\nEnter length? ");
            length = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter width? ");
            width = decimal.Parse(Console.ReadLine());

            if (length > 0 && width > 0)
            {
                Console.WriteLine("The rectangle's area is " + Geometry.AreaOfRectangle(length, width));
            }
            else
            {
                Console.WriteLine("Only positive numbers!");
            }
        }

        public static void CalculateTriangleArea()
        {
            decimal ground = 0;
            decimal height = 0;

            Console.WriteLine("\nEnter length of the triangle's base? ");
            ground = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter triangle's height? ");
            height = decimal.Parse(Console.ReadLine());

            if (ground > 0 && height > 0)
            {
                Console.WriteLine("The triangle's area is " + Geometry.AreaOfTriangle(ground, height));
            }
            else
            {
                Console.WriteLine("Only positive numbers!");
            }
        }
    }
}
