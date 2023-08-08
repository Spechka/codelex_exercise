using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FuelConsumptionCalculator
{
    internal class Car
    {
        public double StartKilometers;
        public double EndKilometers;
        public double Liters;

        public Car(double startOdo)
        {
            StartKilometers = startOdo;
        }

        public void FillUp(double mileage, double liters)
        {
            EndKilometers = mileage;
            Liters += liters;
        }

        public double CalculateConsumption()
        {
            double distance = EndKilometers - StartKilometers;
            double consumption = Liters / distance;
            return consumption;
        }

        public bool IsGasHog()
        {
            if (CalculateConsumption() > 15.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsEconomyCar()
        {
            if (CalculateConsumption() < 5.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
