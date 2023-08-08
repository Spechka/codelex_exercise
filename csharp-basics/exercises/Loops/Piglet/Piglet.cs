using System;

namespace Piglet
{
    internal class Piglet
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Pigglet! \n===================");
            int score = 0;
            bool isWin = false;
            Random rnd = new Random();

            while (true)
            {
                int roll = rnd.Next(1, 7);
                score += roll;

                if (roll == 1) break;

                Console.WriteLine($"You rolled ->{roll} , total score-> {score}");

                string input = GetUserInput();

                if (input == "n")
                {
                    isWin = true;
                    break;
                }
            }

            if (isWin)
            {
                Console.WriteLine($"Too bad, you were doing so well! :v \n Your score is {score}");
            }
            else
            {
                score = 0;
                Console.WriteLine($"Too bad, you lost. Your score now is {score}");
            }
        }

        public static string GetUserInput()
        {
            string input = "";
            Console.WriteLine("Wanna roll again? y/n");

            while (input != "y" && input != "n")
            {

                input = Console.ReadLine();

                if (input != "y" && input != "n")
                {
                    Console.WriteLine("Please type 'n' to stop or 'y' to continue");
                    continue;
                }
                else
                {
                    break;
                }
            }

            return input;
        }
    }
}
