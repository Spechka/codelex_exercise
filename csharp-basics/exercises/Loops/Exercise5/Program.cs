using System;

namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first word: ");
            string firstWord = Console.ReadLine();
            Console.WriteLine("Enter the second word: ");
            string secondWord = Console.ReadLine();
            int numberOfDots = 30 - firstWord.Length - secondWord.Length;
            Console.Write($"{firstWord}");

            for (int i = 1; i <= numberOfDots; i++)
            {
                Console.Write(".");
            }

            Console.Write($"{secondWord}");
        }
    }
}
