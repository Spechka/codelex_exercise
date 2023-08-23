using System;
using System.Collections.Generic;
using System.Text;

namespace Persons
{
    internal class Homosapiens
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private string Address { get; set; }
        private int Id { get; set; }

        public Homosapiens(string firstName, string lastName, string address, int id)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Id = id;
        }

        public virtual void Display()
        {
            Console.WriteLine($"Full name: {FirstName} {LastName}");
            Console.WriteLine($"Homosapien's ID: {Id}");
            Console.WriteLine($"Adress: {Address}");
        }
    }
}
