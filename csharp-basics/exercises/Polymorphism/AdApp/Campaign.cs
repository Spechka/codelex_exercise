using System.Collections.Generic;
using System.Linq;

namespace AdApp
{
    public class Campaign
    {
        private List<Advert> _campaign;

        public Campaign() 
        {
            _campaign = new List<Advert>();
        }

        public void AddAdvert(Advert a) 
        {
            _campaign.Add(a);
        }

        public double GetTotalCost()
        {
            return _campaign.Sum(item => item.CalculateCost());
        }

        public override string ToString()
        {
            string advertDetails = string.Join("\n", _campaign.Select(advert => advert.ToString()));
            return $"Advert Campaign:\n{advertDetails}\nTotal Cost: £{GetTotalCost()}";
        }
    }
}