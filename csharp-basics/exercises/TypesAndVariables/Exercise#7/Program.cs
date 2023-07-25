using System;

namespace Exercise_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text here and I'll display the number of uppercase letters: ");
            char[] userInput = Console.ReadLine().ToCharArray();
            int count = 0;

            foreach (char c in userInput)
            {
                if (char.IsUpper(c))
                {
                    count++;
                }
            }

            Console.WriteLine($"the number of uppercase letters is: {count}");
        }
    }
}
