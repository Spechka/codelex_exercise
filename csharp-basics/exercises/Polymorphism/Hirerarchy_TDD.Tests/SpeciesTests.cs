using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hierarchy_TDD.Species;
using FluentAssertions;
using Hierarchy_TDD.FoodTypes;

namespace Hierarchy_TDD.Tests
{
    [TestClass]
    public class SpeciesTests
    {
        [TestMethod]
        public void Cat_PossessesNeededQualities()
        {
            Cat catTest = new Cat("Cat", "Kitty-Ket", "10000", "Africa", "MarkBush");
            catTest.AnimalType.Should().Be("Cat");
            catTest.Name.Should().Be("Kitty-Ket");
            catTest.Weight.Should().Be(10000);
            catTest.LivingRegion.Should().Be("Africa");
            catTest.Breed.Should().Be("MarkBush");
            catTest.Eat(new Meat("3"));
            catTest.FoodEaten.Should().Be(3);
            catTest.ToString().Should().Be("Cat |[ Kitty-Ket, MarkBush, 10000kg, Africa ]| Ate : 3");
        }

        [TestMethod]
        public void Mouse_PossessesNeededQualities()
        {
            Mouse mouseTest = new Mouse("Mouse", "Kitty-Ket", "10000", "Africa");
            mouseTest.AnimalType.Should().Be("Mouse");
            mouseTest.Name.Should().Be("Kitty-Ket");
            mouseTest.Weight.Should().Be(10000);
            mouseTest.LivingRegion.Should().Be("Africa");
            mouseTest.Eat(new Vegetable("3"));
            mouseTest.FoodEaten.Should().Be(3);
            mouseTest.ToString().Should().Be("Mouse |[ Kitty-Ket , 10000kg, Africa ]| Ate : 3");
        }

        [TestMethod]
        public void Tiger_PossessesNeededQualities()
        {
            Tiger catTest = new Tiger("Tiger", "Kitty-Ket", "10000", "Africa");
            catTest.AnimalType.Should().Be("Tiger");
            catTest.Name.Should().Be("Kitty-Ket");
            catTest.Weight.Should().Be(10000);
            catTest.LivingRegion.Should().Be("Africa");
            catTest.Eat(new Meat("3"));
            catTest.FoodEaten.Should().Be(3);
            catTest.ToString().Should().Be("Tiger |[ Kitty-Ket , 10000kg, Africa ]| Ate : 3");
        }

        [TestMethod]
        public void Zebra_PossessesNeededQualities()
        {
            Zebra catTest = new Zebra("Zebra", "Kitty-Ket", "10000", "Africa");
            catTest.AnimalType.Should().Be("Zebra");
            catTest.Name.Should().Be("Kitty-Ket");
            catTest.Weight.Should().Be(10000);
            catTest.LivingRegion.Should().Be("Africa");
            catTest.Eat(new Vegetable("3"));
            catTest.FoodEaten.Should().Be(3);
            catTest.ToString().Should().Be("Zebra |[ Kitty-Ket , 10000kg, Africa ]| Ate : 3");
        }
    }
}
