using System;

namespace Exercise7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How much money is in the account?: ");
            SavingsAccount savings = new SavingsAccount(double.Parse(Console.ReadLine()));

            Console.WriteLine("Enter the annual interest rate: ");
            savings.AnualInterest = double.Parse(Console.ReadLine());

            Console.WriteLine("How long has the account been opened?: ");
            savings.AccountAge = double.Parse(Console.ReadLine());

            for (int i = 1; i <= savings.AccountAge; i++)
            {
                Console.WriteLine($"Enter amount deposited for month: {i}:" );
                savings.AddingDeposit(double.Parse(Console.ReadLine()));

                Console.WriteLine($"Enter amount withdrawn for {i}: ");
                savings.Withdrawal(double.Parse(Console.ReadLine()));

                savings.MonthlyInterest();
            }

            Console.WriteLine($"Total deposited: {savings.TotalDeposit:F2}$");
            Console.WriteLine($"Total withdrawn: {savings.TotalWithdrawal:F2}$");
            Console.WriteLine($"Interest earned: {savings.TotalInterest:F2}$");
            Console.WriteLine($"Ending balance: {savings.Balance:F2}$");
        }
    }
}
