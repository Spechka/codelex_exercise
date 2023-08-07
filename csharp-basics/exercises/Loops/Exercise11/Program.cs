using System;

namespace Exercise11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "Happy Birthday";
            Console.WriteLine(ReverseCase(word));
        }
        public static string ReverseCase(string word)
        {
            char[] arr = word.ToCharArray();
            string result = "";
            
            foreach (char c in arr)
            {
                if (char.IsUpper(c))
                {
                    result += char.ToLower(c);
                }
                else if (char.IsLower(c))
                {
                    result += char.ToUpper(c);
                }
                else 
                { 
                    result += c; 
                }
            }

            return result;
        }
    }
}
