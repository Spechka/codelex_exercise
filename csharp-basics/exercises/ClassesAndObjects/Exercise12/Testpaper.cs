using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    internal class Testpaper : ITestpaper
    {
        public string Subject { get; set; }
        public string[] MarkScheme { get; set; }
        public string PassMark { get; set; }

        public Testpaper(string subject, string[] markScheme, string passMark)
        {
            Subject = subject;
            MarkScheme = markScheme;
            PassMark = passMark;
        }
    }
}
