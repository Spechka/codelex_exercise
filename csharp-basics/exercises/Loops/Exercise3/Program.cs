using System;

namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which number position out of 20 random numbers you want to know?");
            int position = int.Parse(Console.ReadLine());

            if (position < 1 || position > 20)
            {
                Console.WriteLine("Invalid position. Please enter a number between 1 and 20.");
                return;
            }

            Random rnd = new Random();
            string numbers = "";

            for (int i = 1; i <= 20; i++)
            {
                numbers += rnd.Next(0, 101) + " ";
            }

            string[] numArray = numbers.Trim().Split(' ');
            int numberAtPosition = int.Parse(numArray[position - 1]);

            Console.WriteLine($"Number at position {position} is: {numberAtPosition}");
            Console.WriteLine($"Here are all the numbers: {numbers}");
        }
    }
}
