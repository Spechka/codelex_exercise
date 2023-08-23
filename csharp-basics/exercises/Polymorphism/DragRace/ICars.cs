using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace
{
    public interface ICars
    {
        void SpeedUp();

        void SlowDown();

        string ShowCurrentSpeed();

        void StartEngine();
    }
}
