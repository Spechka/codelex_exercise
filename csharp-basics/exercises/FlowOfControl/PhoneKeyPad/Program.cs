using System;
using System.Linq;

namespace PhoneKeyPad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text to convert to keypad digits:");
            string input = Console.ReadLine().ToLower();
            string output = "";
            Console.WriteLine("nested-if method");

            foreach (char letter in input)
            {
                if (char.IsLetter(letter))
                {
                    if ("abc".Contains(letter))
                    {
                        output += "2";
                    }
                    else if ("def".Contains(letter))
                    {
                        output += "3";
                    }
                    else if ("ghi".Contains(letter))
                    {
                        output += "4";
                    }
                    else if ("jkl".Contains(letter))
                    {
                        output += "5";
                    }
                    else if ("mno".Contains(letter))
                    {
                        output += "6";
                    }
                    else if ("pqrs".Contains(letter))
                    {
                        output += "7";
                    }
                    else if ("tuv".Contains(letter))
                    {
                        output += "8";
                    }
                    else if ("wxyz".Contains(letter))
                    {
                        output += "9";
                    }
                }
                else
                {
                    output += letter;
                }
            }

            Console.WriteLine(output);
            Console.WriteLine("Switch case default method");

            foreach (char letter in input)
            {
                switch (letter)
                {
                    case 'a': case 'b': case 'c':
                        Console.Write("2");
                        break;
                    case 'd': case 'e': case 'f':
                        Console.Write("3");
                        break;
                    case 'g': case 'h': case 'i':
                        Console.Write("4");
                        break;
                    case 'j': case 'k': case 'l':
                        Console.Write("5");
                        break;
                    case 'm': case 'n': case 'o':
                        Console.Write("6");
                        break;
                    case 'p': case 'q': case 'r': case 's':
                        Console.Write("7");
                        break;
                    case 't': case 'u': case 'v':
                        Console.Write("8");
                        break;
                    case 'w': case 'x': case 'y': case 'z':
                        Console.Write("9");
                        break;
                    default: 
                        Console.Write(letter);
                        break;
                }
            }
        }
    }
}
