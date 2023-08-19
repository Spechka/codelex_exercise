using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13
{
    internal class Smoothie
    {
        private List<string> _ingredientList = new List<string>();
        private Hashtable _prices = new Hashtable(){
            {"Strawberries", 1.50},
            {"Banana", 0.50},
            {"Mango", 2.50},
            {"Blueberries", 1.00},
            {"Raspberries", 1.00},
            {"Apple", 1.75},
            {"Pineapple", 3.50},
        };

        public Smoothie(List<string> ingredients)
        {
            _ingredientList = ingredients;
        }

        public string GetName()
        {
            string name = "";

            _ingredientList.ForEach(ingredient =>
            {
                name += ingredient.Replace("ies", "y") + " ";
            });

            if (_ingredientList.Count > 1)
            {
                name += "Fusion";
            }
            else
            {
                name += "Smoothie";
            }

            return name;
        }

        public double GetCost()
        {
            double totalCost = 0;
            _ingredientList.ForEach(ingredient =>
            {
                totalCost += (double)_prices[ingredient];
            });

            return totalCost;
        }

        public double GetPrice()
        {
            var math = GetCost() * 1.5;
            return Math.Round(GetCost() + math, 2);
        }

        public string Ingredients => string.Join(",", _ingredientList);
    }
}
