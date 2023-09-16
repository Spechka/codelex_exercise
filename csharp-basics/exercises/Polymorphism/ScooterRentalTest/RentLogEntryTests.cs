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
    public class RentLogEntryTests
    {
        [TestMethod]
        public void RentLogEntry_CreateLog_ReturnLogInformation()
        {
            var scooter = new Scooter("1", 0.2m);
            var rentStartTime = DateTime.Now.AddMinutes(-16);
            var rentEndTime = DateTime.Now;

            var log = new RentLogEntry(scooter)
            {
                RentStartTime = rentStartTime,
                RentEndTime = rentEndTime,
                FinalRentCost = 16m
            };

            log.Scooter.Should().BeEquivalentTo(scooter);
            log.RentStartTime.Should().Be(rentStartTime);
            log.RentEndTime.Should().Be(rentEndTime);
            log.FinalRentCost.Should().Be(16m);
        }
    }
}