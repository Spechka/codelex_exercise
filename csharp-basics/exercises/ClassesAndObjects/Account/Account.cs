using System;

namespace Account
{
    class Account
    {
        private string _userName;
        private double _balance;

        public void CreateAccount(string account, double balance)
        {
            _userName = account;
            _balance = balance;
        }

        public void Deposit(double withdrawal)
        {
            _balance += withdrawal;
        }

        public void Withdraws(double withdrawal)
        {
            _balance = _balance - withdrawal;
        }

        public void DisplayAccount()
        {
            Console.WriteLine($"{_userName}, ${_balance}");
        }
    }
}
