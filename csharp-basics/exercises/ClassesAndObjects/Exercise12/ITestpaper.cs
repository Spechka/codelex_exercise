﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    internal interface ITestpaper
    {
        string Subject { get; }

        string[] MarkScheme { get; }

        string PassMark { get; }
    }
}
