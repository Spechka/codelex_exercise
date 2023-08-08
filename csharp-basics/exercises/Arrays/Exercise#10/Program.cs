using System;

namespace Exercise_10
{
    internal class Program
    {
        static int[] CountPosSumNeg(int[] numbers)
        {
            int positiveCount = 0;
            int negativeSum = 0;

            foreach (int number in numbers)
            {
                if (number > 0)
                    positiveCount++;
                else if (number < 0)
                    negativeSum += number;
            }

            return new int[] { positiveCount, negativeSum };
        }

        static void Main()
        {
            int[] numbers1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15 };
            int[] numbers2 = { 92, 6, 73, -77, 81, -90, 99, 8, -85, 34 };
            int[] numbers3 = { 91, -4, 80, -73, -28 };
            int[] numbers4 = { };

            int[] result1 = CountPosSumNeg(numbers1);
            int[] result2 = CountPosSumNeg(numbers2);
            int[] result3 = CountPosSumNeg(numbers3);
            int[] result4 = CountPosSumNeg(numbers4);

            Console.WriteLine(string.Join(", ", result1));
            Console.WriteLine(string.Join(", ", result2));
            Console.WriteLine(string.Join(", ", result3));
            Console.WriteLine(string.Join(", ", result4));
        }
    }
}
