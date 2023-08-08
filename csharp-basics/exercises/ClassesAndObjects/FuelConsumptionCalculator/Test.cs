using System;

namespace FuelConsumptionCalculator
{
    class Test
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("calculate the fuel consumption of Lambo");
            Console.WriteLine("Enter start kilometers:");
            double startOdo = double.Parse(Console.ReadLine());
            Car lambey = new Car(startOdo);

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter current odometer reading and how much liters you put into it at the gas station:");

                double mileage = double.Parse(Console.ReadLine());
                double liters = double.Parse(Console.ReadLine());
                lambey.FillUp(mileage, liters);

                Console.WriteLine($"The car consumed {lambey.CalculateConsumption()} liters per kilometer");
            }

            if (lambey.IsGasHog())
            {
                Console.WriteLine("This car is a waste of money");
            }
            else if (lambey.IsEconomyCar())
            {
                Console.WriteLine("This car is an economy car");
            }
            else
            {
                Console.WriteLine("This car is a waste of money, but it could be worse");
            }
        }
    }
}
