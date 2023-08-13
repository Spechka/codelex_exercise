using System;
using System.Linq;

namespace BankAccount
{
    class Program
    {
        public static string Username { get; set; }

        public static double Balance { get; set; }

        static void Main(string[] args)
        {
            Username = "Benson";
            Balance = -17.2;
            Console.WriteLine(ShowUserNameAndBalance());
        }

        public static string ShowUserNameAndBalance()
        {
            if (Balance < 0)
            {
                return $"{Username}, -${Math.Abs(Balance):F2}";
            }

            return $"{Username}, ${Balance:F2}";
        }
    }
}
