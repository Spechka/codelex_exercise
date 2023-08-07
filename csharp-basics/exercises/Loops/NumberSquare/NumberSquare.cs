using System;

namespace NumberSquare
{
    internal class NumberSquare
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Min?: ");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Max?: ");
            int max = int.Parse(Console.ReadLine());

            string numberString = "";

            for (int i = min; i <= max; i++)
            {
                numberString += i.ToString();
            }

            for (int i = min; i <= max; i++)
            {
                Console.WriteLine(numberString);
                numberString = numberString.Substring(1, numberString.Length - 1) + numberString.Substring(0, 1);
            }
        }
    }
}
