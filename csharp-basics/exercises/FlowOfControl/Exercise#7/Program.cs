using System;

namespace Exercise_7
{
    internal class Program
    {
        const string Rock = "rock";
        const string Paper = "paper";
        const string Scissors = "scissors";
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to rock, paper, scissors!");

            string[] moveSet = { Rock, Paper, Scissors };
            Random rnd = new Random();
            bool winner = true;

            while (winner)
            {
                Console.WriteLine("Input rock, paper, or scissors: ");
                string input = Console.ReadLine().ToLower();

                if (input == Rock || input == Paper || input == Scissors)
                {
                    int randomNumber = rnd.Next(3);
                    string computersMove = moveSet[randomNumber];
                    Console.WriteLine($"I pick: {computersMove}");

                    if (input == computersMove)
                    {
                        Console.WriteLine("It's a draw! Let's keep trying our best!");
                    }
                    else if ((input == Rock && computersMove == Scissors) || (input == Paper && computersMove == Rock) || (input == Scissors && computersMove == Paper))
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
