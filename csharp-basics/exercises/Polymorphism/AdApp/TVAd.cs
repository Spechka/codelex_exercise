namespace AdApp
{
    public class TVAd: Advert
    {
        private double _airTimeSeconds;
        private bool _isPeakTime;

        public TVAd(double fixedCost, double variableCost, double airTimeSeconds, bool isPeakTime)
            : base(fixedCost, variableCost, AdvertType.TVCommercial)
        {
            _airTimeSeconds = airTimeSeconds;
            _isPeakTime = isPeakTime;
        }
        
        public override double CalculateCost() 
        {
            double airTimeCost = base.CalculateCost() * _airTimeSeconds;
            if(_isPeakTime)
            {
                airTimeCost *= 2;
            }

            return airTimeCost;
        }
    }
}