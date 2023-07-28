using System;

namespace CheckOddEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Check if the number is odd or even: ");
            int userNumber = int.Parse(Console.ReadLine());

            if (userNumber % 2 == 0)
            {
                Console.WriteLine("The number is even!\nBye!");
            }
            else
            {
                Console.WriteLine("The number is odd\nBye!");
            }
        }
    }
}
