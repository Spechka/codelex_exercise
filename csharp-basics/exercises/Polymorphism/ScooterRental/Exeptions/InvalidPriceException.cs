using System;

namespace ScooterRental.Exceptions
{
    public class InvalidPriceException : Exception
    {
        public InvalidPriceException(decimal price) :
            base($"Given scooter price: {price} can't be 0 or less!") { }
    }
}
