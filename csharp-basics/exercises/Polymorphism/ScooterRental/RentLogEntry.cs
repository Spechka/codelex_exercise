using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScooterRental
{
    public class RentLogEntry
    {
        public RentLogEntry(Scooter scooter)
        {
            Scooter = new Scooter(scooter.Id, scooter.PricePerMinute);
            RentStartTime = DateTime.Now;
        }

        public Scooter Scooter { get; }

        public DateTime RentEndTime { get; set; }

        public decimal FinalRentCost { get; set; }

        public DateTime RentStartTime { get; set; }
    }
}