using System;

namespace Exercise_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a simple Calculator");
            Console.WriteLine("Enter the first number:");
            double firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the operator (+, -, *, or /):");
            char op = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            double secondNum = int.Parse(Console.ReadLine());
            double result = 0;

            switch (op)
            {
                case '+':
                    result = firstNum + secondNum;
                    break;
                case '-':
                    result = firstNum - secondNum;
                    break;
                case '*':
                    result = firstNum * secondNum;
                    break;
                case '/':
                    if (secondNum != 0)
                    {
                        result = firstNum / secondNum;
                    }
                    else
                    {
                        Console.WriteLine("You cannot divide by zero!");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Please enter a valid operator (+, -, *, or /).");
                    return;
            }

            Console.WriteLine($"Result: {result}");
        }
    }
}
