using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hierarchy_TDD.Species;

namespace Hierarchy_TDD.Tests
{
    [TestClass]
    public class FeedAnimalTests
    {
        [TestMethod]
        public void Feed_FeedZebra_ZebraFoodEatenShouldChange()
        {
            var zebra = new Zebra("Zebra", "testZebra", "100", "Savanna");
            FeedAnimal.Feed(zebra, new string[] { "Vegetable", "1" });

            zebra.FoodEaten.Should().Be(1);
        }
    }
}
