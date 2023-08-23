namespace AdApp
{
    public enum AdvertType
    {
        Hoarding,
        Newspaper,
        TVCommercial,
        Poster
    }

    public class Advert
    {
        protected double FixedCost;

        protected double VariableCost;

        public AdvertType Type { get; set; }

        public Advert(double fixedCost, double variableCost, AdvertType type) 
        {
            FixedCost = fixedCost;
            VariableCost = variableCost;
            Type = type;
        }

        public virtual double CalculateCost() 
        {
            return FixedCost + VariableCost;
        }

        public override string ToString() 
        {
            return $"Type: {Type}, Fixed Cost: £{FixedCost}, Variable Cost: £{VariableCost}, Total Cost: £{CalculateCost()}";
        }
    }
}