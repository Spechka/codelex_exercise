﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MakeSounds
{
    internal class Radio : ISound
    {
        public void PlaySound()
        {
            Console.WriteLine("khh..hhh..khh..hhh");
        }
    }
}
