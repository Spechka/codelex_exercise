using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CalculateArea
{
    public class Geometry
    {
        public static double AreaOfCircle(decimal radius)
        {
            return Math.Round(Math.PI * ((double)radius * (double)radius), 2);
        }

        public static double AreaOfRectangle(decimal length, decimal width)
        {

            return Math.Round((double)length * (double)width, 2);
        }

        public static double AreaOfTriangle(decimal ground, decimal h)
        {
            return (double)ground * (double)h * (double)0.5m;
        }
    }
}
