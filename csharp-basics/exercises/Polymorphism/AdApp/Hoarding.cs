namespace AdApp
{
    public class Hoarding: Advert
    {
        private int _numberOfDays;
        private bool _isPrimeLocation;

        public Hoarding(double fixedCost, double variableCost, int numberOfDays, bool isPrimeLocation)
            : base(fixedCost, variableCost, AdvertType.Hoarding)
        {
            _numberOfDays = numberOfDays;
            _isPrimeLocation = isPrimeLocation;
        }

        public override double CalculateCost() 
        {
            double totalCost = base.CalculateCost() * _numberOfDays;
            if(_isPrimeLocation)
            {
                totalCost += totalCost * 0.5;
            }

            return totalCost;
        }
    }
}