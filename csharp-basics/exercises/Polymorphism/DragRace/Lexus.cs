using System;

namespace DragRace
{
    public class Lexus : IBoost
    {
        private int _currentSpeed = 0;

        public void SpeedUp() 
        {
            _currentSpeed += 9;
        }

        public void SlowDown() 
        {
            _currentSpeed -= 4;
        }

        public string ShowCurrentSpeed() 
        {
            return _currentSpeed.ToString();
        }

        public void UseNitrousOxideEngine() 
        {
            Console.WriteLine("Using Boost!");
            _currentSpeed += 15;
        }

        public void StartEngine() 
        {
            Console.WriteLine("Lexus started the engine - Rrrrrrr.....");
        }
    }
}