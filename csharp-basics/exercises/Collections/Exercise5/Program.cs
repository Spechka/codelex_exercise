using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            int number = int.Parse(Console.ReadLine());

            bool isHappy = IsHappyNumber(number);

            if (isHappy)
            {
                Console.WriteLine($"{number} is a happy number!");
            }
            else
            {
                Console.WriteLine($"{number} is not a happy number.");
            }
        }

        static bool IsHappyNumber(int n)
        {
            HashSet<int> seenNumbers = new HashSet<int>();

            while (n != 1 && !seenNumbers.Contains(n))
            {
                seenNumbers.Add(n);
                n = SumOfSquaredDigits(n);
            }

            return n == 1;
        }

        static int SumOfSquaredDigits(int num)
        {
            return num.ToString().Select(digit => int.Parse(digit.ToString())).Select(d => d * d).Sum();
        }
    }
}
