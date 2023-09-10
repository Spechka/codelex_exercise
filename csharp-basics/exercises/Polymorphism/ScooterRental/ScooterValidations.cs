using ScooterRental.Exceptions;
using System.Collections.Generic;
using System.Linq;

namespace ScooterRental.ScooterValidation
{
    public static class ScooterValidations
    {
        public static void IsIdValid(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new InvalidIdException();
            }
        }

        public static void IsScooterInInventory(Scooter scooter, string id)
        {
            if (scooter == null)
            {
                throw new ScooterDoesntExistException(id);
            }
        }

        public static void IsScooterRented(Scooter scooter, string id)
        {
            if (!scooter.IsRented)
            {
                throw new ScooterIsNotRented(id);
            }
        }
    }
}
