using System;

namespace Account
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Initial state");
            Account myAccount = new Account();
            myAccount.CreateAccount("Peter", 100);

            Account mattsAccount = new Account();
            mattsAccount.CreateAccount("Matt", 0);

            Account marksAccount = new Account();
            marksAccount.CreateAccount("Mark", 0);

            myAccount.DisplayAccount();
            mattsAccount.DisplayAccount();
            marksAccount.DisplayAccount();

            Console.WriteLine("==========================\nAfter transfer transaction\n==========================");

            Transfer(myAccount, mattsAccount, 50);
            Transfer(mattsAccount, marksAccount, 25);

            myAccount.DisplayAccount();
            mattsAccount.DisplayAccount();
            marksAccount.DisplayAccount();
        }

        public static void Transfer(Account from, Account to, double howMuch)
        {
            from.Withdraws(howMuch);
            to.Deposit(howMuch);
        }
    }
}
