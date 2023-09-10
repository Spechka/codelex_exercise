﻿using System;

namespace ScooterRental
{
    public class Scooter
    {
        public Scooter(string id, decimal pricePerMinute)
        {
            Id = id;
            PricePerMinute = pricePerMinute;
            IsRented = false;
        }

        public string Id { get; }

        public decimal PricePerMinute { get; }

        public bool IsRented { get; set; }

        public DateTime ScooterRentStartDate { get; set; }
    }
}
