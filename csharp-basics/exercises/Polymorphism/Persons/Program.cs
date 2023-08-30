using System;

namespace Persons
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Peteris", "Krumins", "Sewer,  Puskina-Kalatuskina 2 - 4", 23, 2.1);
            Employee employee = new Employee("Sewer explorer", "Big", "Boss", "Mars, That-One-Rock-We-Saw 3 - 2", 67);

            student.Display();
            Console.WriteLine();
            employee.Display();
        }
    }
}