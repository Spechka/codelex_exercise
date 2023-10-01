using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy_TDD
{
    public abstract class Mammal : Animal
    {
        public abstract string LivingRegion { get; }
        protected string _animalType;
        protected string _animalName;
        protected double _weight;

        public Mammal(string animalType, string animalName, string weight)
        {
            _animalType = animalType;
            _animalName = animalName;
            _weight = double.Parse(weight);
        }

        public override string ToString()
        {
            return $"{AnimalType} |[ {Name} , {Weight}kg, {LivingRegion} ]| Ate : {FoodEaten}";
        }
    }
}
