using System;

namespace MoreVariablesAndPrinting
{
    class Program
    {
        static void Main(string[] args)
        {
            
            

            string name = "Zed A. Shaw";
            int age = 35;
            double heightInInches = 74;  
            double heightInCentimeters = heightInInches * 2.54;
            double weightInPounds = 180;
            double weightInKilos = Math.Round(weightInPounds * 0.453592, 2);
            string eyes = "Blue";
            string teeth = "White";
            string hair = "Brown";

            Console.WriteLine("Let's talk about " + name + ".");
            Console.WriteLine("He's " + heightInCentimeters + " centimeters tall.");
            Console.WriteLine("He's " + weightInKilos + " kilos heavy.");
            Console.WriteLine("Actually, that's not too heavy.");
            Console.WriteLine("He's got " + eyes + " eyes and " + hair + " hair.");
            Console.WriteLine("His teeth are usually " + teeth + " depending on the coffee.");

            Console.WriteLine("If I add " + age + ", " + heightInCentimeters + ", and " + weightInKilos
                               + " I get " + (age + heightInCentimeters + weightInKilos) + ".");

            Console.ReadKey();
        }
    }
}