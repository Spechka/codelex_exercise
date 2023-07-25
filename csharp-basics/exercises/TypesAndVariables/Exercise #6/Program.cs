using System;

namespace Exercise__6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a serie of single digit numbers.");
            string userInput = Console.ReadLine();
            char[] allNumbers = userInput.ToCharArray();
            int sum = 0;
            
            foreach (char number in allNumbers)
            {
                sum += int.Parse(number.ToString());
            }
            Console.WriteLine(sum);
        }
    }
}
