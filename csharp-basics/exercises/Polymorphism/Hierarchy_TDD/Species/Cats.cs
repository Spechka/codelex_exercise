using Hierarchy_TDD.FoodTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy_TDD.Species
{
    public class Cat : Feline
    {
        private string _livingRegion;
        private string _breed;
        private int _foodEaten;

        public Cat(string animalType, string animalName, string weight, string livingRegion, string breed) : base
            (animalType, animalName, weight)
        {
            _livingRegion = livingRegion;
            _breed = breed;
            _foodEaten = 0;
        }

        public override void Eat(Food food)
        {
            _foodEaten += food.FoodQuantity;
        }

        public override void MakeSound()
        {
            Console.WriteLine("> Purrrrrr......");
        }

        public override string ToString()
        {
            return $"{AnimalType} |[ {Name}, {Breed}, {Weight}kg, {LivingRegion} ]| Ate : {FoodEaten}";
        }

        public override string AnimalType => _animalType;

        public override string Name => _animalName;

        public override double Weight => _weight;

        public override string LivingRegion => _livingRegion;

        public override int FoodEaten => _foodEaten;

        public string Breed => _breed;
    }
}
