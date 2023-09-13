using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendingMachiene_TDD;

namespace VendingMachiene_TDD.Tests
{
    [TestClass]
    public class MoneyTests
    {
        [TestMethod]
        public void Money_CreateMoney_MoneyCreated()
        {
            var money = new Money(10, 10);

            money.Euros.Should().Be(10);
            money.Cents.Should().Be(10);
        }
    }
}
