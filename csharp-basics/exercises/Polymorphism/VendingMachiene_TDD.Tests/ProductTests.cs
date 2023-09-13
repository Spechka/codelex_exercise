using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendingMachiene_TDD;
using VendingMachiene_TDD;

namespace VendingMachiene_TDD.Tests
{
    [TestClass]
    public class ProductTests
    {
        [TestMethod]
        public void Product_CreateProduct_ProductCreated()
        {
            var money = new Money(5, 10);
            var product = new Product(5, money, "Milk");

            product.Name.Should().Be("Milk");
            product.Available.Should().Be(5);
            product.Price.Should().Be(money);
        }
    }
}
