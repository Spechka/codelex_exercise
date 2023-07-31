using System;

namespace TenBillion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input an integer number less than ten billion: ");
            var input = Console.ReadLine();
            var converted = long.Parse(input);

            if (converted < 0)
            {
                converted = Math.Abs(converted);
                input.Substring(1);
            }

            if (converted < 10000000000)
            {
                int numberOfDigits = input.Length;
                Console.WriteLine($"The number has {numberOfDigits} digits.");
            }
            else
            {
                Console.WriteLine("The number is not less than ten billion");
            }
        }
    }
}
