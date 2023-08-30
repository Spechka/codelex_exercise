using System;
using System.Collections.Generic;

namespace MakeSounds
{
    class Program
    {
        private static void Main(string[] args)
        {
            List<ISound> listOfSounds = new List<ISound>()
            {
                new Firework(),
                new Parrot(),
                new Radio()
            };

            string name = "";
            foreach (ISound sound in listOfSounds)
            {
                name = sound.GetType().Name;
                Console.WriteLine($"{name} :");
                sound.PlaySound();
                Console.WriteLine("===============");
            }
        }
    }
}