using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Odometer
    {
        private int _currentMileage;
        private FuelGauge _fuelGauge;

        public Odometer(FuelGauge fuelGauge)
        {
            _currentMileage = 0;
            _fuelGauge = fuelGauge;
        }

        public int ReportMileage()
        {
            return _currentMileage;
        }

        public void DroveKm()
        {
            if (_currentMileage < 999999)
            {
                _currentMileage++;
            }
            else
            {
                _currentMileage = 0;
            }

            if (_currentMileage % 10 == 0)
            {
                _fuelGauge.FuelWasted();
            }
        }
    }
}
