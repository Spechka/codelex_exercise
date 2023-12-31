﻿using System;

namespace EnergyDrinks
{
    class Program
    {
        private const int NumberedSurveyed = 12467;
        private const double PurchasedEnergyDrinks = 0.14;
        private const double PreferCitrusDrinks = 0.64;

        static void Main(string[] args)
        {
            double energyDrinkers = CalculateEnergyDrinkers(NumberedSurveyed);
            double preferCitrus = CalculatePreferCitrus(NumberedSurveyed);

            Console.WriteLine("Total number of people surveyed: " + NumberedSurveyed);
            Console.WriteLine("Approximately " + energyDrinkers + " bought at least one energy drink.");
            Console.WriteLine(preferCitrus + " of those prefer citrus flavored energy drinks.");
        }

        static double CalculateEnergyDrinkers(int numberSurveyed)
        {
            return numberSurveyed * PurchasedEnergyDrinks;
        }

        static double CalculatePreferCitrus(int numberSurveyed)
        {
            return numberSurveyed * PurchasedEnergyDrinks * PreferCitrusDrinks;
        }
    }
}
