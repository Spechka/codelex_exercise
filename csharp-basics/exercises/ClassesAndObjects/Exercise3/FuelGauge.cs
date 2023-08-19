using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class FuelGauge
    {
        private int _currentFuel;

        public FuelGauge() 
        {
            _currentFuel = 50;
        }

        public int ReportFuel()
        {
            return _currentFuel;
        }

        public void FillUp()
        {
            _currentFuel++;
        }

        public void FuelWasted()
        {
            if (_currentFuel > 0)
            {
                _currentFuel--;
            }
        }
    }
}
