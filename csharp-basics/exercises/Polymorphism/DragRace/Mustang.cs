using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace
{
    internal class Mustang : ICars
    {
        private int _currentSpeed = 0;

        public void SpeedUp()
        {
            _currentSpeed += 11;
        }

        public void SlowDown()
        {
            _currentSpeed -= 5;
        }

        public string ShowCurrentSpeed()
        {
            return _currentSpeed.ToString();
        }

        public void StartEngine()
        {
            Console.WriteLine("Mustang started the engine - Rrrrrrr.....");
        }
    }
}
