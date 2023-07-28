using System;

namespace CozaLozaWoza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = 1;
            int finish = 110;
            int numbersPerLine = 11;

            for (int i = start; i <= finish; i++)
            {
                if (i % 3 == 0 && i % 5 == 0 && i % 7 == 0)
                {
                    Console.Write("CozaLozaWoza ");
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write("CozaLoza ");
                }
                else if (i % 3 == 0 && i % 7 == 0)
                {
                    Console.Write("CozaWoza ");
                }
                else if (i % 5 == 0)
                {
                    Console.Write("Loza ");
                }
                else if (i % 7 == 0)
                {
                    Console.Write("Woza ");
                }
                else if (i % 3 == 0)
                {
                    Console.Write("Coza ");
                }
                else
                {
                    Console.Write($"{i} ");
                }

                if (i % numbersPerLine == 0)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
