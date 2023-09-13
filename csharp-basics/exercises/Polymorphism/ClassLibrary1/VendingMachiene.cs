using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachiene_TDD;

namespace VendingMachiene_TDD
{
    public class VendingMachine : IVendingMachine
    {
        private string _manufacturer;
        private bool _hasProducts;
        private Money _amountOfMoney;
        private Product[] _products;

        public VendingMachine(string manufacturer)
        {
            _manufacturer = manufacturer;
            _hasProducts = false;

            _amountOfMoney = new Money();
            _amountOfMoney.Euros = 0;
            _amountOfMoney.Cents = 0;

            Products = new Product[100];
        }

        public bool AddProduct(string name, Money price, int count)
        {
            var isAdded = false;
            for (int i = 0; i < _products.Length; i++)
            {
                if (_products[i].Name == null)
                {
                    _products[i].Name = name;
                    _products[i].Price = price;
                    _products[i].Available = count;
                    isAdded = true;
                    _hasProducts = true;
                    break;
                }
            }

            return isAdded;
        }

        public void DisplayProducts()
        {
            var counter = 1;
            foreach (var product in _products)
            {
                if (product.Name != null)
                {
                    Console.WriteLine($">> {counter}");
                    Console.WriteLine($"Name: {product.Name}");
                    Console.WriteLine($"Price: ${product.Price.Euros}.{product.Price.Cents}");
                    Console.WriteLine($"Amount: {product.Available}");
                    Console.WriteLine("-------------------------");
                    counter++;
                }
            }
        }

        public void Buy(string productNumber)
        {
            var index = int.Parse(productNumber) - 1;
            var product = _products[index];

            if (product.Name == null)
            {
                Console.WriteLine("No product at that possition!");
                return;
            }

            if (CountCoins(product.Price) > CountCoins(_amountOfMoney))
            {
                Console.WriteLine("Not enough money!!");
                return;
            }

            _amountOfMoney.Euros = CountCoins(_amountOfMoney) - CountCoins(product.Price) / 100;
            _amountOfMoney.Cents = CountCoins(_amountOfMoney) - CountCoins(product.Price) % 100;
            ReturnMoney();
            _products[index].Available--;
        }

        public int CountCoins(Money money)
        {
            return money.Euros * 100 + money.Cents;
        }

        public Money InsertCoin(Money amount)
        {
            if (IsCoinValid(amount))
            {
                _amountOfMoney.Euros += amount.Euros;
                _amountOfMoney.Cents += amount.Cents;

                if (_amountOfMoney.Cents >= 100)
                {
                    _amountOfMoney.Cents -= 100;
                    _amountOfMoney.Euros++;
                }
            }
            else
            {
                Console.WriteLine("Inserted coin is invalid!");
            }

            return Amount;
        }

        public Money ReturnMoney()
        {
            var amount = _amountOfMoney;
            _amountOfMoney.Euros = 0;
            _amountOfMoney.Cents = 0;

            return amount;
        }

        public bool UpdateProduct(int productNumber, string name, Money? price, int amount)
        {
            if (_products[productNumber].Name != null)
            {
                _products[productNumber].Name = name;
                _products[productNumber].Price = (Money)price;
                _products[productNumber].Available = amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsCoinValid(Money coin)
        {
            return coin.Euros == 2 && coin.Cents == 0 || 
                coin.Euros == 1 && coin.Cents == 0 ||
                coin.Euros == 0 && coin.Cents == 50 ||
                coin.Euros == 0 && coin.Cents == 20 ||
                coin.Euros == 0 && coin.Cents == 10;
        }

        public string Manufacturer => _manufacturer;

        public bool HasProducts => _hasProducts;

        public Money Amount => _amountOfMoney;

        public Product[] Products { get => _products; set { _products = value; } }
    }
}
