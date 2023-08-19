using System;

namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FuelGauge fuelGauge = new FuelGauge();
            Odometer odometer = new Odometer(fuelGauge);

            for (int l = 0; l <= 2; l++)
            {
                for (int i = fuelGauge.ReportFuel(); i < 70; i++)
                {
                    fuelGauge.FillUp();
                    Console.WriteLine($"Filling up the gas tank | {fuelGauge.ReportFuel()}");
                }

                Console.WriteLine("==========================================================================================");

                while (fuelGauge.ReportFuel() > 0)
                {
                    odometer.DroveKm();
                    Console.WriteLine("Mileage: " + odometer.ReportMileage() + " km | Fuel: " + fuelGauge.ReportFuel() + " liters");
                }

                Console.WriteLine("==========================================================================================");
            }

            Console.WriteLine("The car has run out of fuel.");
        }
    }
}
