using System;

namespace DragRace
{
    public class Audi : ICars
    {
        private int _currentSpeed = 0;

        public void SpeedUp() 
        {
            _currentSpeed += 7;
        }

        public void SlowDown() 
        {
            _currentSpeed -= 2;
        }

        public string ShowCurrentSpeed() 
        {
            return _currentSpeed.ToString();
        }

        public void StartEngine() 
        {
            Console.WriteLine("Audi started the engine - Rrrrrrr.....");
        }
    }
}