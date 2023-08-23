using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Firm
{
    public class Commission : Hourly
    {
        private double _totalSales;
        private double _commissionRate;

        public Commission(string eName, string eAddress, string ePhone, string socSecNumber, double rate, double commissionRate) : base(eName, eAddress, ePhone, socSecNumber, rate)
        {
            _totalSales = 0;
            _commissionRate = commissionRate;
        }

        public void AddSales (double totalSales)
        {
            _totalSales += totalSales;
        }

        public override double Pay()
        {
            var basePay = base.Pay();
            var salary = basePay + _totalSales * _commissionRate;
            _totalSales = 0;

            return salary;
        }

        public override string ToString()
        {
            var baseResult = base.ToString();
            baseResult += $"{Environment.NewLine} TotalSales: {_totalSales}";

            return baseResult;
        }
    }
}
