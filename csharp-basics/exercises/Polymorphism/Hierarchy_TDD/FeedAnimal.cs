using Hierarchy_TDD.FoodTypes;

namespace Hierarchy_TDD
{
    public static class FeedAnimal
    {
        public static void Feed(Animal animal, string[] chosenFood)
        {
            if (chosenFood?[0].ToLower() == "meat")
            {
                animal.Eat(new Meat(chosenFood[1]));
            }
            else
            {
                animal.Eat(new Vegetable(chosenFood?[1]));
            }
        }
    }
}