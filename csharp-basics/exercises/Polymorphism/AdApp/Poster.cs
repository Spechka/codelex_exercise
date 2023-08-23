using System;
using System.Collections.Generic;
using System.Text;

namespace AdApp
{
    public class Poster : Advert
    {
        private double _dimensions;
        private int _numOfCopies;
        private double _costPerCopy;

        public Poster(double fixedCost, double variableCost, double dimensions, int numOfCopies, double costPerCopy)
            : base(fixedCost, variableCost, AdvertType.Poster)
        {
            _dimensions = dimensions;
            _numOfCopies = numOfCopies;
            _costPerCopy = costPerCopy;
        }

        public override double CalculateCost()
        {
            return base.CalculateCost() + (_numOfCopies * _costPerCopy);
        }
    }
}
