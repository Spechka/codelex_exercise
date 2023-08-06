using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercise2
{
    class Program
    {       
        private static void Main(string[] args)
        {
            Console.WriteLine("Please enter a min number");
            int minNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a max number");
            int maxNumber = int.Parse(Console.ReadLine());

            int[] myArray = new int[maxNumber - minNumber + 1];

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = minNumber + i;
            }

            var sum = 0;

            foreach (int num in myArray)
            {
                sum += num;
            }

            Console.WriteLine("The sum is " + sum);
            Console.ReadKey();
        }
    }
}
