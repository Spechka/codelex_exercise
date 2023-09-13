namespace VendingMachiene_TDD
{
    public struct Product
    {
        ///<summary>Gets or sets the available amount of product.</summary>
        public int Available { get; set; }
        ///<summary>Gets or sets the product price.</summary>
        public Money Price { get; set; }
        ///<summary>Gets or sets the product name.</summary>
        public string Name { get; set; }

        public Product(int available, Money price, string name)
        {
            Available = available;
            Price = price;
            Name = name;
        }
    }
}
