using System;

namespace DragRace
{
    public class Bmw : ICars
    {
        private int _currentSpeed = 0;

        public void SpeedUp() 
        {
            _currentSpeed += 10;
        }

        public void SlowDown() 
        {
            _currentSpeed -=4;
        }

        public string ShowCurrentSpeed() 
        {
            return _currentSpeed.ToString();
        }

        public void StartEngine() 
        {
            Console.WriteLine("BMV started the engine - Rrrrrrr.....");
        }
    }
}