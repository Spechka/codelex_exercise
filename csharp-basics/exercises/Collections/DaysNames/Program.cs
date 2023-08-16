namespace DaysNames;
class Program
{
    static void Main(string[] args)
    {
        DateTime dt = new DateTime();

        for (int i = 0; i < 7; i++)
        {
            Console.WriteLine("{1}", dt.AddDays(i), dt.AddDays(i).DayOfWeek);
        }
    }
}
