using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hierarchy_TDD.FoodTypes;
using FluentAssertions;

namespace Hierarchy_TDD.Tests
{
    [TestClass]
    public class FoodTypeTests
    {
        [TestMethod]
        public void FoodTypes_CreateAndReturnMeatQuantity()
        {
            Meat testMeat = new Meat("3");
            testMeat.FoodQuantity.Should().Be(3);
        }

        [TestMethod]
        public void FoodTypes_CreateAndReturnVegetableQuantity()
        {
            Vegetable testVegetable = new Vegetable("3");
            testVegetable.FoodQuantity.Should().Be(3);
        }
    }
}
