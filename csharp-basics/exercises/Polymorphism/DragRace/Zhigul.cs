using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace
{
    internal class Zhigul : IBoost
    {
        private int _currentSpeed = 0;

        public void SpeedUp()
        {
            _currentSpeed += 100;
        }

        public void SlowDown()
        {
            _currentSpeed -= 10;
        }

        public string ShowCurrentSpeed()
        {
            return _currentSpeed.ToString();
        }

        public void UseNitrousOxideEngine()
        {
            Console.WriteLine("Using Boost!");
            _currentSpeed += 1000;
        }

        public void StartEngine()
        {
            Console.WriteLine("Zhigul started the engine --R--rr--rr--RRRRrrRRRRrrr");
        }
    }
}
