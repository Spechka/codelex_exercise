using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class BankAccount
    {
        private string _name;
        private double _balance;

        public BankAccount(string name, double balance)
        {
            _name = name;
            _balance = balance;
        }

        public string ShowUserNameAndBalance()
        {
            string balanceFormat = (_balance >= 0) ? $"${_balance:F2}" : $"-${Math.Abs(_balance):F2}";
            return $"{_name}, {balanceFormat}";
        }
    }
}
