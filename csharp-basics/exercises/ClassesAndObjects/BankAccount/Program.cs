using System;
using System.Linq;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount benben = new BankAccount("Benson", 17.5);
            string result = benben.ShowUserNameAndBalance();
            Console.WriteLine(result);
        }
    }
}
