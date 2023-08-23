using System;
using System.Collections.Generic;
using System.Text;

namespace Persons
{
    internal class Employee : Homosapiens
    {
        public string JobTitle { get; set; }

        public Employee (string jobTitle, string firstName, string lastName, string address, int id) : base(firstName, lastName, address, id)
        {
            JobTitle = jobTitle;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Job title: {JobTitle}");
        }
    }
}
