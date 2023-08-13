using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    internal class SavingsAccount
    {
        public double Balance;
        public double AnualInterest;
        public double AccountAge;
        public double TotalWithdrawal = 0;
        public double TotalDeposit = 0;
        public double TotalInterest = 0;

        public SavingsAccount(double startingBalance)
        {
            Balance = startingBalance;
        }

        public void Withdrawal(double withdrawal)
        {
            Balance -= withdrawal;
            TotalWithdrawal += withdrawal;
        }

        public void AddingDeposit(double amount)
        {
            Balance += amount;
            TotalDeposit += amount;
        }

        public void MonthlyInterest()
        {
            var meth = (AnualInterest / 12) * Balance;
            Balance += meth;
            TotalInterest += meth;
        }
    }
}
