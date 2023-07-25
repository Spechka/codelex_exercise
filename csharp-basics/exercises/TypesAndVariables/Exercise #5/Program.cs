using System;

namespace Exercise__5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] teachers = { "Mr. Snake", "Mr. Kojima", "Mr. Holmes", "Mrs. Meryl", "Mr. Otacon" };
            string[] classes = { "Close Quarters Combat", "History", "Chemistry", "Sports", "Metal Gear Biology" };

            int teacherIndex = 0;
            int count = 1;

            Console.WriteLine("*---*----------------------------*-------------------*");
            Console.WriteLine("|No.|         School Class       |       Teacher     |");
            Console.WriteLine("|---|----------------------------|-------------------|");
            foreach (string schoolClass in classes)
            {
                string currentTeacher = teachers[teacherIndex];

                Console.WriteLine($"|{count,3}|{schoolClass,-28}|{currentTeacher,-19}|"); //We declare the width with the numbers. We count them from WriteLines above

                teacherIndex++; // Move to the next teacher

                count++;

            }
            Console.WriteLine("*---*----------------------------*-------------------*");
        }
    }
}
