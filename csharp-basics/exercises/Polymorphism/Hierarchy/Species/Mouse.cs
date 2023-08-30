using Hierarchy.FoodTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy.Species
{
    internal class Mouse : Mammal
    {
        private string _livingRegion;
        private int _foodEaten;

        public Mouse(string animalType, string animalName, string weight, string livingRegion) : base 
            (animalType, animalName, weight)
        {
            _livingRegion = livingRegion;
            _foodEaten = 0;
        }

        public override void Eat(Food food)
        {
            if (food is Vegetable)
            {
                _foodEaten += food.FoodQuantity;
            }
            else
            {
                Console.WriteLine($"{AnimalType} are not eating that type of food!");
            }
        }

        public override void MakeSound()
        {
            Console.WriteLine("> *Mouse noizess*");
        }

        public override string AnimalType => _animalType;

        public override string Name => _animalName;

        public override double Weight => _weight;

        public override string LivingRegion => _livingRegion;

        public override int FoodEaten => _foodEaten;

    }
}
