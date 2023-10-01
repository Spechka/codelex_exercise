using System;
using System.Collections.Generic;
using System.Linq;
using ScooterRental.Exceptions;
using ScooterRental.Interfaces;
using ScooterRental.ScooterValidation;

namespace ScooterRental
{
    public class ScooterService : IScooterService
    {
        private readonly List<Scooter> _scooterList;

        public ScooterService(List<Scooter> inventory)
        {
            _scooterList = inventory;
        }

        public void AddScooter(string id, decimal pricePerMinute)
        {
            ScooterValidations.IsIdValid(id);

            if (pricePerMinute <= 0)
            {
                throw new InvalidPriceException(pricePerMinute);
            }

            if (_scooterList.Any(scooter => scooter.Id == id))
            {
                throw new DuplicateScooterException(id);
            }

            _scooterList.Add(new Scooter(id, pricePerMinute));
        }

        public void RemoveScooter(string id)
        {
            ScooterValidations.IsIdValid(id);

            var scooter = _scooterList.FirstOrDefault(scooter => scooter.Id == id);

            ScooterValidations.IsScooterInInventory(scooter, id);

            _scooterList.Remove(scooter);
        }

        public IList<Scooter> GetScooters()
        {
            return _scooterList.ToList();
        }

        public Scooter GetScooterById(string scooterId)
        {
            var scooter = _scooterList.FirstOrDefault(scooter => scooter.Id == scooterId);

            ScooterValidations.IsScooterInInventory(scooter, scooterId);

            return scooter;
        }
    }
}