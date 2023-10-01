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
                    totalIncome += log.FinalRentCost;
                }
            }

            return totalIncome;
        }

        public decimal EndRent(string id)
        {
            var scooter = _scooterService.GetScooterById(id);
            var rentLog = _rentLogs.Find(log => log.Scooter.Id == scooter.Id);

            ScooterValidations.IsScooterInInventory(scooter, id);
            ScooterValidations.IsScooterRented(scooter, id);

            scooter.IsRented = false;
            rentLog.FinalRentCost = CalculateCost(scooter);
            rentLog.RentEndTime = DateTime.Now;

            return rentLog.FinalRentCost;
        }

        public void StartRent(string id)
        {
            var scooter = _scooterService.GetScooterById(id);

            ScooterValidations.IsScooterInInventory(scooter, id);

            _rentLogs.Add(new RentLogEntry(scooter));
            scooter.IsRented = true;
        }

        private decimal CalculateCost(Scooter scooter)
        {
            var minutesInDay = 1440;
            var rentLog = _rentLogs.Find(log => log.Scooter.Id == scooter.Id);

            var minutesInLastDay = (int)DateTime.Now.Subtract(rentLog.RentStartTime).TotalMinutes % minutesInDay;
            var totalFullDays = (int)DateTime.Now.Subtract(rentLog.RentStartTime).TotalDays;

            var priceForMinutesInLastDay = minutesInLastDay * scooter.PricePerMinute;
            var pricePerONEDay = minutesInDay * scooter.PricePerMinute;

            priceForMinutesInLastDay = priceForMinutesInLastDay > 20 ? 20 : priceForMinutesInLastDay;
            pricePerONEDay = pricePerONEDay > 20 ? 20 : pricePerONEDay;

            var priceForDays = totalFullDays * pricePerONEDay;
            var finalRentCost = priceForDays + priceForMinutesInLastDay;

            return finalRentCost;
        }
    }
}
