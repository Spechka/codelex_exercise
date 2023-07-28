using System;

namespace Exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber + secondNumber == 15 || firstNumber - secondNumber == 15)
            {
                Console.WriteLine(true);
            }
            else if (firstNumber == 15 || secondNumber == 15)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
