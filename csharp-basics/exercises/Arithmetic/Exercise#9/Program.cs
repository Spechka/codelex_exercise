using System;

namespace Exercise_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, this is a BMI calculator!");
            Console.WriteLine("Would you like to use, input '1' or '2': \n1. Pounds and inches\n2. Kilos and meters");
            int userInput = int.Parse(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    CalculatePoundsAndInchesBMI();
                    break;
                case 2:
                    CalculateKilosAndMetersBMI();
                    break;
                default:
                    Console.WriteLine("Please input '1' or '2'");
                    break;
            }
        }

        public static void CalculatePoundsAndInchesBMI()
        {
            Console.WriteLine("Please enter your weight in pounds: ");
            double weightInPounds = double.Parse(Console.ReadLine());

            Console.WriteLine("Now enter your height in inches: ");
            double heightInInches = double.Parse(Console.ReadLine());

            const double bodyMassIndexConstant = 703;
            double bodyMassIndex = (weightInPounds * bodyMassIndexConstant) / (heightInInches * heightInInches);

            DisplayBMIResults(bodyMassIndex);
        }

        public static void CalculateKilosAndMetersBMI()
        {
            Console.WriteLine("Please enter your weight in kilograms: ");
            double weightInKilos = double.Parse(Console.ReadLine());

            Console.WriteLine("Now enter your height in meters: ");
            double heightInMeters = double.Parse(Console.ReadLine());

            double bodyMassIndex = weightInKilos / (heightInMeters * heightInMeters);

            DisplayBMIResults(bodyMassIndex);
        }

        public static void DisplayBMIResults(double bodyMassIndex)
        {
            if (bodyMassIndex >= 18.5 && bodyMassIndex <= 25)
            {
                Console.WriteLine($"Your BMI is {bodyMassIndex:F2}\nYour weight is optimal");
            }
            else if (bodyMassIndex > 25)
            {
                Console.WriteLine($"Your BMI is {bodyMassIndex:F2}\nYou are overweight");
            }
            else if (bodyMassIndex < 18.5)
            {
                Console.WriteLine($"Your BMI is {bodyMassIndex:F2}\nYou are underweight");
            }
        }
    }
}
