using System;
using System.Collections.Generic;
using System.Linq;
using ScooterRental.Interfaces;
using ScooterRental.Exceptions;
using ScooterRental.ScooterValidation;

namespace ScooterRental
{
    public class RentalCompany : IRentalCompany
    {
        private readonly IScooterService _scooterService;
        private readonly List<RentLogEntry> _rentLogs;

        public string Name { get; }

        public RentalCompany(string name, IScooterService scooterService, List<RentLogEntry> rentHistory)
        {
            Name = name;
            _scooterService = scooterService;
            _rentLogs = rentHistory;
        }

        public decimal CalculateIncome(int? year, bool includeNotCompletedRentals)
        {
            decimal totalIncome = 0;

            if (includeNotCompletedRentals && year == DateTime.Now.Year || year == null)
            {
                var scootersWithUnfinishedRent = _scooterService
                    .GetScooters()
                    .Where(s => s.IsRented == true);

                foreach (var scooter in scootersWithUnfinishedRent)
                {
                    totalIncome += CalculateCost(scooter);
                }
            }

            foreach (var log in _rentLogs)
            {
                if (year == null || year == log.RentEndTime.Year)
                {
                    totalIncome += log.Cost;
                }
            }

            return totalIncome;
        }

        public decimal EndRent(string id)
        {
            var scooter = _scooterService.GetScooterById(id);

            ScooterValidations.IsScooterInInventory(scooter, id);
            ScooterValidations.IsScooterRented(scooter, id);

            scooter.IsRented = false;
            var cost = CalculateCost(scooter);

            _rentLogs.Add(new RentLogEntry(scooter, DateTime.Now, cost));

            return cost;
        }

        public void StartRent(string id)
        {
            var scooter = _scooterService.GetScooterById(id);

            ScooterValidations.IsScooterInInventory(scooter, id);

            scooter.ScooterRentStartDate = DateTime.Now.AddMinutes(-10);
            scooter.IsRented = true;
        }

        private decimal CalculateCost(Scooter scooter)
        {
            var rentTimeInMinutes = (int)DateTime.Now.Subtract(scooter.ScooterRentStartDate).TotalMinutes;
            var price = scooter.PricePerMinute * rentTimeInMinutes;

            return Math.Round(price, 2);
        }
    }
}
