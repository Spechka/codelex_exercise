namespace AdApp
{
    public class NewspaperAd : Advert
    {
        private double _columnCm;

        public NewspaperAd(double fixedCost, double variableCost, double columnCm)
            : base(fixedCost, variableCost, AdvertType.Newspaper)
        {
            _columnCm = columnCm;
        }

        public override double CalculateCost()
        {
            return base.CalculateCost() * _columnCm;
        }
    }
}