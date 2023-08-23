using Hierarchy.FoodTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public abstract class Animal
    {
        public abstract string AnimalType { get; }

        public abstract string Name { get; }

        public abstract double Weight { get; }

        public abstract int FoodEaten { get; }

        public abstract void MakeSound();

        public abstract void Eat(Food food);
    }
}
