using System;
using System.Drawing;
using System.Reflection;

namespace Exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(5, 2);
            Point p2 = new Point(-3, 6);
            SwapPoints(ref p1, ref p2);

            Console.WriteLine("Swapping:");
            Console.WriteLine("Point 1: " + p1);
            Console.WriteLine("Point 2: " + p2);
        }

        static void SwapPoints(ref Point p1, ref Point p2)
        {
            Point temp = p1;
            p1 = p2;
            p2 = temp;
        }
    }
}
