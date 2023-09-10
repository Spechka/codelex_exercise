namespace VendingMachiene_TDD
{
    public interface IVendingMachine
    {
        string Manufacturer { get; }

        public bool HasProducts { get; }

        public MoneyObj.Money Amount { get; }

        ProductObj.Product[] Products { get; set; }

        MoneyObj.Money InsertCoin(MoneyObj.Money amount);

        MoneyObj.Money ReturnMoney();

        bool AddProduct(string name, MoneyObj.Money price, int count);

        bool UpdateProduct(int productNumber, string name, MoneyObj.Money? price, int amount);
    }
}
