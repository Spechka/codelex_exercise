using System;

namespace ScooterRental.Exceptions
{
    public class InvalidIdException : Exception
    {
        public InvalidIdException() :
            base("Scooter can't have null or empty Id!") { }
    }
}
