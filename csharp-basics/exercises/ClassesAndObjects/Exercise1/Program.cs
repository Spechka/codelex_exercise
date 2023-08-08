using System;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product firstProduct = new Product("Logitech mouse", 70.00, 14);
            Product secondProduct = new Product("iPhone 5s", 999.99, 3);
            Product thirdProduct = new Product("Epson EB-U05", 440.46, 1);

            firstProduct.PrintProduct();
            firstProduct.ChangeAmount(69);
            firstProduct.PrintProduct();

            secondProduct.PrintProduct();
            secondProduct.ChangePrice(32.02);
            secondProduct.PrintProduct();

            thirdProduct.PrintProduct();
        }
    }
}
