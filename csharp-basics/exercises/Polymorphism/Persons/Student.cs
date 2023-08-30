using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Persons
{
    internal class Student : Homosapiens
    {
        public double GPA { get; set; }

        public Student(string firstName, string lastName, string address, int id, double gpa) : base
            (firstName, lastName, address, id)
        {
            GPA = gpa;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"GPA: {GPA}");
        }
    }
}
