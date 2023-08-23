using System;

namespace DragRace
{
    public class Tesla : ICars
    {
        private int _currentSpeed = 0;

        public void SpeedUp() 
        {
            _currentSpeed += 5;
        }

        public void SlowDown() 
        {
            _currentSpeed -= 3;
        }

        public string ShowCurrentSpeed() 
        {
            return _currentSpeed.ToString();
        }

        public void StartEngine() 
        {
            Console.WriteLine("Tesla started the engine -- silence ---");
        }
    }
}