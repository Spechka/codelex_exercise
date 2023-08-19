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

        var dayNames = Enumerable.Range(0, 7).Select(daysToAdd => dt.AddDays(daysToAdd)).Select(date => new { Day = (DayOfWeek)date.DayOfWeek, Name = date.DayOfWeek.ToString() });

        foreach (var day in dayNames)
        {
            Console.WriteLine("Day: {0}, Name: {1}", day.Day, day.Name);
        }
    }
}
