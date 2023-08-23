using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy.FoodTypes
{
    internal class Meat : Food
    {
        private int _quantity;

        public Meat(string quantity)
        {
            _quantity = int.Parse(quantity);
        }

        public override int FoodQuantity => _quantity;
    }
}
