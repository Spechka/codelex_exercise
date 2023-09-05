namespace DaysNames;
class Program
{
    public enum DayOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    static void Main(string[] args)
    {
        DateTime dt = new DateTime();

        var dayNames = Enumerable.Range(0, 7)
            .Select(i => dt.AddDays(i))
            .Select(date => (date.DayOfWeek, Enum.GetName(typeof(DayOfWeek), date.DayOfWeek)));

        foreach (var (dayOfWeek, dayName) in dayNames)
        {
            Console.WriteLine("{0}: {1}", dayOfWeek, dayName);
        }
    }
}
