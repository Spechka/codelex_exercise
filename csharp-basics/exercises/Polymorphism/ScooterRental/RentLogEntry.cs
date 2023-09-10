using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScooterRental
{
    public class RentLogEntry
    {
        public RentLogEntry(Scooter scooter, DateTime rentEndTime, decimal cost)
        {
            Scooter = new Scooter(scooter.Id, scooter.PricePerMinute);
            RentEndTime = rentEndTime;
            Cost = cost;
        }

        public Scooter Scooter { get; }

        public DateTime RentEndTime { get; }

        public decimal Cost { get; }
    }
}