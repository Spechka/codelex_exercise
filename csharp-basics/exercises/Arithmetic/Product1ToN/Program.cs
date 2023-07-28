using System;

namespace Product1ToN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int product = 1;

            for (int i = 1; i <= 10; i++)
            {
                product *= i;
            }

            Console.WriteLine($"The product of integers from 1 to 10 is: {product}");
        }
    }
}
