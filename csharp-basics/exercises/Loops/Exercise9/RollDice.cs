using System;

namespace Exercise9
{
    internal class RollDice
    {
        public static void PlayGame()
        {
            Console.WriteLine("Desired sum: ");
            int input = int.Parse(Console.ReadLine());
            int desiredSum = 0;
            Random random = new Random();

            while (desiredSum != input)
            {
                int first = random.Next(1, 7);
                int second = random.Next(1, 7);
                desiredSum = first + second;
                Console.WriteLine($"You rolled: {first} and {second} = {desiredSum}");
            }
        }
    }
}
