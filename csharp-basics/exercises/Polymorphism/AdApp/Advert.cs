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

        private AdvertType _type;

        public Advert(double fixedCost, double variableCost, AdvertType type) 
        {
            FixedCost = fixedCost;
            VariableCost = variableCost;
            _type = type;
        }

        public virtual double CalculateCost() 
        {
            return FixedCost + VariableCost;
        }

        public override string ToString() 
        {
            return $"Type: {_type}, Fixed Cost: £{FixedCost}, Variable Cost: £{VariableCost}, Total Cost: £{CalculateCost()}";
        }
    }
}