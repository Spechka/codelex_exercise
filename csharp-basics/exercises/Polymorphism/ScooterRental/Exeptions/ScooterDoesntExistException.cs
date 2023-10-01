using System;

namespace ScooterRental.Exceptions
{
    public class ScooterDoesntExistException : Exception
    {
        public ScooterDoesntExistException(string id) :
            base($"Chosen scooter with id: {id} doesn't exist!") { }
    }
}
