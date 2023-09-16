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
        private Scooter _scooter;

        [TestInitialize]
        public void Setup()
        {
            _scooter = new Scooter("1", 0.2m) { IsRented = true };
            var scooter2 = new Scooter("2", 0.5m);
            var scooter3 = new Scooter("3", 1.1m);

            var rentLog1 = new RentLogEntry(_scooter) { RentStartTime = DateTime.Now.AddDays(-2) };
            var rentLog2 = new RentLogEntry(scooter2)
            {
                RentStartTime = DateTime.Now.AddYears(-1).AddDays(-1).AddMinutes(-70),
                RentEndTime = DateTime.Now.AddYears(-1).AddMinutes(-10),
                FinalRentCost = 86m
            };
            var rentLog3 = new RentLogEntry(scooter3)
            {
                RentStartTime = DateTime.Now.AddMinutes(-70),
                RentEndTime = DateTime.Now.AddMinutes(-10),
                FinalRentCost = 66m
            };

            var _inventory = new List<Scooter>() { _scooter, scooter2, scooter3 };
            var rentHistory = new List<RentLogEntry>() { rentLog1, rentLog2, rentLog3 };

            IScooterService service = new ScooterService(_inventory);

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
            _rentalCompany.EndRent(_scooter.Id).Should().Be(40);
            _scooter.IsRented.Should().BeFalse();
        }

        [TestMethod]
        public void RentalCompany_EndRentOnAnUnrentedScooter_ThrowScooterIsNotRentedException()
        {
            Action act = () => _rentalCompany.EndRent("3");

            act.Should().Throw<ScooterIsNotRented>().WithMessage("Chosen scooter with id: 3 Is not rented!");
        }

        // CalculateIncome
        [TestMethod]
        public void CalculateIncome_IncomeForCurrentYear_ReturnIncomeForCurrentYear()
        {
            _rentalCompany.CalculateIncome(2023, false).Should().Be(66m);
        }

        [TestMethod]
        public void CalculateIncome_IncomeForCurrentYearAndUnfinishedRent_ReturnIncomeForCurrentYearAndUnfinishedRent()
        {
            _rentalCompany.CalculateIncome(2023, true).Should().Be(106m);
        }

        [TestMethod]
        public void CalculateIncome_IncomeForLastYear_ReturnIncomeForScootersRentedLastYear()
        {
            _rentalCompany.CalculateIncome(2022, false).Should().Be(86m);
        }
    }
}
