namespace AdApp
{
    public class Hoarding: Advert
    {
        private int NumberOfDays;
        private bool IsPrimeLocation;

        public Hoarding(double fixedCost, double variableCost, int numberOfDays, bool isPrimeLocation)
            : base(fixedCost, variableCost, AdvertType.Hoarding)
        {
            NumberOfDays = numberOfDays;
            IsPrimeLocation = isPrimeLocation;
        }

        public override double CalculateCost() 
        {
            double totalCost = base.CalculateCost() * NumberOfDays;
            if(IsPrimeLocation)
            {
                totalCost += totalCost * 0.5;
            }

            return totalCost;
        }
    }
}