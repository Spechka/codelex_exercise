﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    internal interface IStudent
    {
        List<string> TestsTaken {  get; }

        void TakeTest(ITestpaper paper, string[] answers);
    }
}
