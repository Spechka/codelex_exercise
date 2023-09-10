using System;

namespace VendingMachiene_TDD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var vendingMachine = new VendingMachine("Bandai Namco");
            var money = new MoneyObj.Money();

            money.Euros = 3;
            money.Cents = 50;
            vendingMachine.AddProduct("Chips", money, 10);

            money.Euros = 1;
            money.Cents = 20;
            vendingMachine.AddProduct("PackOfGum", money, 10);

            vendingMachine.DisplayProducts();

            money.Euros = 2;
            money.Cents = 0;
            vendingMachine.InsertCoin(money);
            vendingMachine.InsertCoin(money);
            vendingMachine.InsertCoin(money);

            vendingMachine.Buy("2");
            vendingMachine.DisplayProducts();

            Console.ReadKey();
        }
    }
}
