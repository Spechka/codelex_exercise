using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendingMachiene_TDD;

namespace VendingMachiene_TDD.Tests
{
    [TestClass]
    public class VendingMachineTests
    {
        private VendingMachine _vendingMachine;
        private Money _money;
        private Money _invalidMoney;
        private Product _testProduct;

        [TestInitialize]
        public void Setup()
        {
            _money = new Money(1, 0);

            _invalidMoney = new Money(10, 10);

            _testProduct = new Product(10, _money, "TestProduct1");

            _vendingMachine = new VendingMachine("Apple");
            _vendingMachine.AddProduct("TestProduct2", _money, 10);
            _vendingMachine.InsertCoin(_money);
        }

        [TestMethod]
        public void VendingMachine_AssignVariables_VariablesAssigned()
        {
            _vendingMachine.Manufacturer.Should().Be("Apple");
            _vendingMachine.Amount.Euros.Should().Be(1);
            _vendingMachine.Amount.Cents.Should().Be(0);
            _vendingMachine.HasProducts.Should().BeTrue();
        }

        [TestMethod]
        public void AddProduct_AddAProduct_ProductAdded()
        {
            _vendingMachine.AddProduct("milk", _money, 12);

            _vendingMachine.HasProducts.Should().BeTrue();
        }

        [TestMethod]
        public void Buy_BuyAProduct_ProductBought()
        {
            _vendingMachine.InsertCoin(_money);
            _vendingMachine.Buy("1");
            _vendingMachine.Products[0].Available.Should().Be(9);
        }

        [TestMethod]
        public void CountCoins_CountCoins_ShouldReturnCoins()
        {
            _vendingMachine.CountCoins(_money).Should().Be(100);
        }

        [TestMethod]
        public void InsertCoinsRemoveMoney_InsertAndRemoveMoney_MoneyShouldBeInsertedAndRemoved()
        {
            var moneyNew = new Money(2, 0);

            _vendingMachine.InsertCoin(_invalidMoney);
            _vendingMachine.InsertCoin(_money).Should().Be(moneyNew);
            _vendingMachine.ReturnMoney().Should().Be(moneyNew);
        }

        [TestMethod]
        public void UpdateProduct_ChangeProductsInformation_ProductInformationShouldBeChanged()
        {
            var moneyNew = new Money(10, 10);

            _vendingMachine.UpdateProduct(
                0,
                "1",
                moneyNew,
                10);

            _vendingMachine.Products[0].Name.Should().Be("1");
            _vendingMachine.Products[0].Price.Should().Be(moneyNew);
            _vendingMachine.Products[0].Available.Should().Be(10);
        }

        [TestMethod]
        public void IsCoinValid_InsertValidAndInvalidCoins_ShouldReturnTrueAndFalseAccordingly()
        {
            _vendingMachine.IsCoinValid(_money).Should().BeTrue();
            _vendingMachine.IsCoinValid(_invalidMoney).Should().BeFalse();
        }
    }
}
