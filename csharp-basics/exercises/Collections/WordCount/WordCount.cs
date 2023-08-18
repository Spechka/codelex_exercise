using System;
using System.IO;
using System.Linq;

namespace WordCount
{
    class WordCount
    {
        static void Main(string[] args)
        {
            string path = Environment.CurrentDirectory;
            string filePath = Path.GetFullPath(Path.Combine(path, @"..\..\..\"));
            StreamReader file = new StreamReader(filePath + "\\lear.txt");

            int lines = 0;
            int words = 0;
            int chars = 0;
            string line;

            while ((line = file.ReadLine()) != null)
            {
                string[] strings = line.Split(new char[] { ' ', '\'' }, StringSplitOptions.RemoveEmptyEntries);
                words += strings.Length;
                lines++;
                chars += line.Length;
            }

            Console.WriteLine("Lines = " + lines);
            Console.WriteLine("Words = " + words);
            Console.WriteLine("Chars = " + chars);
        }
    }
}
