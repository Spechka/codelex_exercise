using System;

namespace Exercise_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to rock, paper, scissors!");

            string[] computersMoveSet = { "rock", "paper", "scissors" };
            Random rnd = new Random();
            bool winner = true;

            while (winner)
            {
                Console.WriteLine("Input rock, paper, or scissors: ");
                string input = Console.ReadLine().ToLower();

                if (input == "rock" || input == "paper" || input == "scissors")
                {
                    int randomNumber = rnd.Next(3);
                    string computersMove = computersMoveSet[randomNumber];
                    Console.WriteLine($"I pick: {computersMove}");

                    if (input == computersMove)
                    {
                        Console.WriteLine("It's a draw! Let's keep trying our best!");
                    }
                    else if (input == "rock" && computersMove == "scissors" || input == "paper" && computersMove == "rock" || input == "scissors" && computersMove == "paper")
                    {
                        Console.WriteLine($"{input} beats {computersMove}, I was defeated!");
                        winner = false;
                    }
                    else
                    {
                        Console.WriteLine($"{computersMove} beats {input}, I win!");
                        winner = false;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid move! Please choose rock, paper, or scissors.");
                }
            }
        }
    }
}
