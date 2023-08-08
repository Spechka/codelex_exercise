using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise1
{
    internal class Product
    {
        public string Name;
        public double PriceAtStart;
        public int AmountAtStart;

        public Product(string name, double priceAtStart, int amountAtStart) 
        {
            Name = name;
            PriceAtStart = priceAtStart;
            AmountAtStart = amountAtStart;
        }

        public void PrintProduct()
        {
            Console.WriteLine($"{Name}, price - {PriceAtStart:F2} EUR, amount - {AmountAtStart}");
        }

        public void ChangeAmount(int newAmount)
        {
            AmountAtStart = newAmount;
        }

        public void ChangePrice(double newPrice)
        {
            PriceAtStart = newPrice;
        }
    }
}
