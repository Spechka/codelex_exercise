using System;

namespace Exercise_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[10];

            Random random = new Random();
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = random.Next(1, 101);
            }

            int[] array2 = new int[array1.Length];
            Array.Copy(array1, array2, array1.Length);

            array1[array1.Length - 1] = -7;

            Console.WriteLine("Array 1: " + string.Join(" ", array1));
            Console.WriteLine("Array 2: " + string.Join(" ", array2));

            Console.ReadKey();
        }
    }
}
