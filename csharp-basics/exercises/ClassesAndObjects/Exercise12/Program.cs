using System;

namespace Exercise12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Testpaper mathTest = new Testpaper("Metal Gear Solid - philosophy", new string[] { "A", "B", "C", "D" }, "2");

            Student student1 = new Student();
            Console.WriteLine(string.Join("\n", student1.TestsTaken));

            string[] student1Answers = { "A", "D", "D", "A" };
            student1.TakeTest(mathTest, student1Answers);
            Console.WriteLine(string.Join("\n", student1.TestsTaken));

            Student student2 = new Student();
            string[] student2Answers = { "A", "B", "C", "D" };
            student2.TakeTest(mathTest, student2Answers);
            Console.WriteLine(string.Join("\n", student2.TestsTaken));
        }
    }
}
