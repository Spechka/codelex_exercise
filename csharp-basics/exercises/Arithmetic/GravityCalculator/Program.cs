using System;

namespace GravityCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // finalPosition ===> X(T) = 0.5 * A(gravity)*T(fallingTime)^2 + Vi(initialVelocity)*T(fallingTime) + Xi(initialPosition)
            double gravity = -9.81;
            double initialVelocity = 0.0;
            double fallingTime = 10.0;
            double initialPosition = 0.0;

            double finalPosition = 0.5 * gravity * fallingTime * fallingTime + initialVelocity * fallingTime + initialPosition;

            Console.WriteLine($"The object's position after {fallingTime} seconds is {finalPosition:F1}m");
            Console.ReadKey();
        }
    }
}
