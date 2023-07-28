using System;

namespace Exercise_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] employees = { "Edgars", "Līva", "Sandris" };
            double[] salaryPerHour = { 7.50, 8.20, 10.00 };
            double[] hoursWorked = { 35, 47, 73 };

            Console.WriteLine("| Employee   | Pay this month | Hours Worked     |");
            Console.WriteLine("+------------+----------------+------------------+");

            for (int i = 0; i < employees.Length; i++)
            {
                try
                {
                    double totalPay = CalculateTotalPay(salaryPerHour[i], hoursWorked[i]);
                    Console.WriteLine($"| {employees[i],-10} | {totalPay,14:F2} | {hoursWorked[i],12:F2}     |");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"| {employees[i],-10} | Error: {ex.Message,-25}|");
                }
            }

            Console.WriteLine("+------------+----------------+------------------+");
            Console.ReadKey();
        }

        static double CalculateTotalPay(double pay, double hours)
        {
            if (pay < 8)
            {
                throw new Exception("This employee is underpaid!");
            }
            else
            {
                double result = pay * hours;
                return result;
            }
        }
    }
}
