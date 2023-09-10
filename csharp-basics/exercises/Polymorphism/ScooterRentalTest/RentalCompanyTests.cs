using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScooterRental.Exceptions;
using ScooterRental.Interfaces;

namespace ScooterRental.Tests
{
    [TestClass]
    public class RentalCompanyTests
    {
        private RentalCompany _rentalCompany;
        private List<Scooter> _inventory;
        private Scooter _scooter;

        [TestInitialize]
        public void Setup()
        {
            _inventory = new List<Scooter>()
            {
                new Scooter("1", 0.2m),
                new Scooter("2", 0.5m),
                new Scooter("3", 1.1m),
            };

            IScooterService service = new ScooterService(_inventory);
            _scooter = new Scooter("4", 0.2m)
            {
                IsRented = true,
                ScooterRentStartDate = DateTime.Now.AddMinutes(-1)
            };
            _inventory.Add(_scooter);

            var rentedScooter1 = new Scooter("a", 0.2m);
            var rentedScooter2 = new Scooter("b", 0.5m);
            var rentedScooter3 = new Scooter("c", 1.0m);

            var rentHistory = new List<RentLogEntry>()
            {
                new RentLogEntry(rentedScooter1, DateTime.UtcNow, 0.8m),
                new RentLogEntry(rentedScooter2, DateTime.UtcNow, 1.5m),
                new RentLogEntry(rentedScooter3, DateTime.UtcNow.AddYears(-1), 2.0m),
            };

            _rentalCompany = new RentalCompany("Traktoors", service, rentHistory);
        }

        // Get Name
        [TestMethod]
        public void RentalCompany_ReadName_ReturnName()
        {
            _rentalCompany.Name.Should().Be("Traktoors");
        }

        // StartRent method
        [TestMethod]
        public void RentalCompany_StartRent_ScooterIsRentedShouldBeTrue()
        {
            _rentalCompany.StartRent(_scooter.Id);

            _scooter.IsRented.Should().BeTrue();
        }

        // EndRent method
        [TestMethod]
        public void RentalCompany_EndRent_ScooterIsRentedShouldBeFalseAndReturnPrice()
        {
            _rentalCompany.EndRent(_scooter.Id).Should().Be(0.2m);
            _scooter.IsRented.Should().BeFalse();
        }

        [TestMethod]
        public void RentalCompany_EndRentOnAnUnrentedScooter_ThrowScooterIsNotRentedException()
        {
            Action act = () => _rentalCompany.EndRent("1");

            act.Should().Throw<ScooterIsNotRented>().WithMessage("Chosen scooter with id: 1 Is not rented!");
        }

        // CalculateIncome
        [TestMethod]
        public void CalculateIncome_IncomeForCurrentYear_ReturnIncomeForCurrentYear()
        {
            _rentalCompany.CalculateIncome(2023, false).Should().Be(2.3m);
        }

        [TestMethod]
        public void CalculateIncome_IncomeForCurrentYearAndUnfinishedRent_ReturnIncomeForCurrentYearAndUnfinishedRent()
        {
            _rentalCompany.CalculateIncome(2023, true).Should().Be(2.5m);
        }

        [TestMethod]
        public void CalculateIncome_IncomeForLastYear_ReturnIncomeForScootersRentedLastYear()
        {
            _rentalCompany.CalculateIncome(2022, false).Should().Be(2.0m);
        }
    }
}
