using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class FuelGauge
    {
        public int CurrentFuel;

        public FuelGauge() 
        {
            CurrentFuel = 50;
        }

        public int ReportFuel()
        {
            return CurrentFuel;
        }

        public void FillUp()
        {
            CurrentFuel++;
        }

        public void FuelWasted()
        {
            if (CurrentFuel > 0)
            {
                CurrentFuel--;
            }
        }
    }
}
