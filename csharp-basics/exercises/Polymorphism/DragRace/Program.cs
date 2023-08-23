using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;

namespace DragRace
{
    class Program
    {
        private static void Main(string[] args)
        {
            List<ICars> cars = new List<ICars>();

            ICars bmw = new Bmw();
            ICars tesla = new Tesla();
            ICars audi = new Audi();
            IBoost lexus = new Lexus();
            IBoost zhigul = new Zhigul();
            ICars mustang = new Mustang();

            cars.Add(bmw);
            cars.Add(lexus);
            cars.Add(audi);
            cars.Add(tesla);
            cars.Add(mustang);
            cars.Add(zhigul);

            foreach (ICars car in cars)
            {
                int fastestSpeed = 0;
                string fastestCarName = "";
                car.StartEngine();

                for (int i = 0; i < 10;  i++)
                {    
                    car.SpeedUp();
                    Console.WriteLine($"Current speed: {car.ShowCurrentSpeed()}");

                    if (car is IBoost boost && i == 2)
                    {
                        boost.UseNitrousOxideEngine();
                    }

                    if (i%3 == 0)
                    {
                        Console.WriteLine($"A turn is coming, the car has to slowing down!");
                        car.SlowDown();
                    }

                    int currentSpeed = int.Parse(car.ShowCurrentSpeed());

                    if (currentSpeed > fastestSpeed)
                    {
                        fastestSpeed = currentSpeed;
                        fastestCarName = car.GetType().Name;
                    }
                }

                Console.WriteLine();
                Console.WriteLine($"Fastest car: {fastestCarName}, Speed: {fastestSpeed}");
                Console.WriteLine();
            }
        }
    }
}