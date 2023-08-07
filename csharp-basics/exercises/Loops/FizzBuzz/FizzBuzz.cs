using System;

namespace FizzBuzz
{
    internal class FizzBuzz
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int line = 20;

            for (int i = 1; i <= numbers; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write("FizzBuzz ");
                }
                else if (i % 3 == 0)
                {
                    Console.Write("Fizz ");
                }
                else if (i % 5 == 0)
                {
                    Console.Write("Buzz ");
                }
                else
                {
                    Console.Write($"{i} ");
                }

                if (i % line == 0 || i == numbers)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
