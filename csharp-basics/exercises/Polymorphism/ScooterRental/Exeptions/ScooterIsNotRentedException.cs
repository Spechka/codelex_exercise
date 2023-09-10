using System;

namespace ScooterRental.Exceptions
{
    public class ScooterIsNotRented : Exception
    {
        public ScooterIsNotRented(string id) :
            base($"Chosen scooter with id: {id} Is not rented!") { }
    }
}
