using System;
using System.Collections.Generic;
using System.Text;

namespace Persons
{
    internal class Homosapiens
    {
        private string _firstName;
        private string _lastName;
        private string _address;
        private int _id;

        public Homosapiens(string firstName, string lastName, string address, int id)
        {
            _firstName = firstName;
            _lastName = lastName;
            _address = address;
            _id = id;
        }

        public virtual void Display()
        {
            Console.WriteLine($"Full name: {_firstName} {_lastName}");
            Console.WriteLine($"Homosapien's ID: {_id}");
            Console.WriteLine($"Adress: {_address}");
        }
    }
}
