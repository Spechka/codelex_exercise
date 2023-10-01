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
    public class ScooterServiceTest
    {
        private IScooterService _scooterService;
        private List<Scooter> _inventory;
        private Scooter _scooter;

        [TestInitialize]
        public void Setup()
        {
            _inventory = new List<Scooter>();
            _scooter = new Scooter("0", 0.2m);
            _scooterService = new ScooterService(_inventory);
        }

        // AddScooter method
        [TestMethod]
        public void AddScooter_AddValidScooter_ScooterAdded()
        {
            _scooterService.AddScooter("1", 0.3m);
            _inventory.Count.Should().Be(1);
        }

        [TestMethod]
        public void AddScooter_AddValidScooterTwice_ThrowsDuplicateScooterException()
        {
            _scooterService.AddScooter("1", 0.3m);

            Action act = () =>
                _scooterService.AddScooter("1", 0.3m);

            act.Should().Throw<DuplicateScooterException>().WithMessage("Scooter with id: 1 already exists!");
        }

        [TestMethod]
        public void AddScooter_AddScooterWithInvalidPrice_ThrowsInvalidPriceException()
        {
            Action act = () =>
                _scooterService.AddScooter("1", -0.3m);

            act.Should().Throw<InvalidPriceException>().WithMessage("Given scooter price: -0.3 can't be 0 or less!");
        }

        [TestMethod]
        public void AddScooter_AddScooterWithNullOrEmptyId_ThrowsInvalidIdException()
        {
            Action act = () =>
                _scooterService.AddScooter("", 0.3m);

            act.Should().Throw<InvalidIdException>().WithMessage("Scooter can't have null or empty Id!");
        }

        // RemoveScooter method
        [TestMethod]
        public void RemoveScooter_ScooterExists_CorrectScooterIsRemoved()
        {
            _inventory.Add(_scooter);

            _scooterService.RemoveScooter("0");

            _inventory.Count.Should().Be(0);
        }

        [TestMethod]
        public void RemoveScooter_ScooterDoesntExist_ThrowScooterDoesntExistException()
        {
            Action act = () => _scooterService.RemoveScooter("1");

            act.Should().Throw<ScooterDoesntExistException>().WithMessage("Chosen scooter with id: 1 doesn't exist!");
        }

        [TestMethod]
        public void RemoveScooter_RemoveScooterWithNullOrEmptyId_ThrowsInvalidIdException()
        {
            Action act = () =>
                _scooterService.RemoveScooter("");

            act.Should().Throw<InvalidIdException>().WithMessage("Scooter can't have null or empty Id!");
        }

        // GetScooterList method
        [TestMethod]
        public void GetScooters_GetScooterList_ReturnEmptyScooterList()
        {
            _scooterService.GetScooters().Should().BeEquivalentTo(_inventory);
        }

        [TestMethod]
        public void GetScooters_GetScooterListWith2Scooters_ReturnScooterListWith2Scooters()
        {
            _inventory.Add(new Scooter("1", 0.2m));
            _inventory.Add(new Scooter("2", 0.3m));

            _scooterService.GetScooters().Should().BeEquivalentTo(_inventory);
        }

        [TestMethod]
        public void GetScooters_GetScooterList_ReturnAListThatsNotAReferenceToInventory()
        {
            _inventory.Add(new Scooter("1", 0.2m));

            IList<Scooter> list = _scooterService.GetScooters();
            list.Add(new Scooter("2", 0.3m));

            _scooterService.GetScooters().Count.Should().Be(1);
        }

        // GetScooterById method
        [TestMethod]
        public void GetScooterById_GetExistingScooterById_ReturnScooterWithTheProperId()
        {
            Scooter scooter = new Scooter("1", 0.2m);
            _inventory.Add(scooter);

            _scooterService.GetScooterById("1").Should().BeSameAs(scooter);
        }

        [TestMethod]
        public void GetScooterById_ScooterDoesntExist_ThrowScooterDoesntExistException()
        {
            Action act = () => _scooterService.GetScooterById("1");

            act.Should().Throw<ScooterDoesntExistException>().WithMessage("Chosen scooter with id: 1 doesn't exist!");
        }
    }
}