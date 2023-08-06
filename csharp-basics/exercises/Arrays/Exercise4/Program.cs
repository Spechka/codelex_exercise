using System;

namespace Exercise4
{
    class Program
    {
        private static void Main(string[] args)
        {
            int[] myArray =
            {
                1789, 2035, 1899, 1456, 2013,
                1458, 2458, 1254, 1472, 2365,
                1456, 2265, 1457, 2456
            };

            int searchValue = 1245;
            bool containsValue = false;

            foreach (int num in myArray)
            {
                if (num == searchValue)
                {
                    containsValue = true;
                    break;
                }
            }

            if (containsValue)
            {
                Console.WriteLine("The array contains the value: " + searchValue);
            }
            else
            {
                Console.WriteLine("The array does not contain the value: " + searchValue);
            }

            Console.ReadKey();
        }
    }
}
