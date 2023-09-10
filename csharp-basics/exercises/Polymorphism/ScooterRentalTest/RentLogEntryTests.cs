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
            var time = DateTime.UtcNow;
            var log = new RentLogEntry(scooter, time, 0.2m);

            log.Scooter.Should().BeEquivalentTo(scooter);
            log.RentEndTime.Should().Be(time);
            log.Cost.Should().Be(0.2m);
        }
    }
}