using System;

namespace Exercise_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckNumberType(132)); // Output: H
            Console.WriteLine(CheckNumberType(133)); // Output: M
            Console.WriteLine(CheckNumberType(17));  // Output: Neither
        }

        static string CheckNumberType(int number)
        {
            int sumOfDigits = CalculateDigitSum(number);
            if (sumOfDigits == 0)
            {
                return "Neither";
            }

            if (number % sumOfDigits == 0)
            {
                if (IsPrime(number / sumOfDigits))
                {
                    return "M";
                }
                else
                {
                    return "H";
                }
            }

            return "Neither";
        }

        static int CalculateDigitSum(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }

        static bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
