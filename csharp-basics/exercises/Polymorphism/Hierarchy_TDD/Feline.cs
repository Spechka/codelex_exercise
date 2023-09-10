using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy_TDD
{
    public abstract class Feline : Mammal
    {
        public Feline(string animalType, string animalName, string weight) : base 
            (animalType, animalName, weight)
        {

        }
    }
}
