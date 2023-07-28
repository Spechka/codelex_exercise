using System;

namespace Exercise_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I'm thinking of a number between 1-100. Try to guess it. Or press 'n' to give up and see my number");
            Random rnd = new Random();
            int number = rnd.Next(100);

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "n")
                {
                    Console.WriteLine($"Too bad. I was thinking of {number}");
                    break;
                }
                else if (int.TryParse(input, out int num)) // nice way to check if input was a number and convert it to int and store it in a new output "num"
                {
                    if (num < number)
                    {
                        Console.WriteLine("Sorry, the number is too low, keep trying");
                    }
                    else if (num > number)
                    {
                        Console.WriteLine("Sorry, the number is too high, keep trying");
                    }
                    else
                    {
                        Console.WriteLine($"You guessed it, it's {number}! What were the odds?!?");
                        break;
                    }
                }
            }
        }
    }
}
