using System;

namespace Account
{
    class Account
    {
        public string UserName;
        public double Balance;

        public void CreateAccount(string account, double balance)
        {
            UserName = account;
            Balance = balance;
        }

        public void Deposit(double withdrawal)
        {
            Balance = Balance + withdrawal;
        }

        public void Withdraws(double withdrawal)
        {
            Balance = Balance - withdrawal;
        }

        public void DisplayAccount()
        {
            Console.WriteLine($"{UserName}, ${Balance}");
        }
    }
}
