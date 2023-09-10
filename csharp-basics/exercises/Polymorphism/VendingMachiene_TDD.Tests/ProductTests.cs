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
            var product = new ProductObj.Product();
            var money = new MoneyObj.Money();

            product.Name = "Milk";
            product.Available = 5;
            product.Price = money;

            product.Name.Should().Be("Milk");
            product.Available.Should().Be(5);
            product.Price.Should().Be(money);
        }
    }
}
