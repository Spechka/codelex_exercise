using System;

namespace AdApp
{
    class Program
    {
        private static void Main(string[] args)
        {
            var c = new Campaign();
            c.AddAdvert(new Poster(300, 0, 24, 1000, 0.05));
            c.AddAdvert(new Hoarding(500, 7, 200, true));
            c.AddAdvert(new NewspaperAd(500, 0.1, 20));
            c.AddAdvert(new TVAd(50000, 1000, 60, true));
            Console.WriteLine(c);
        }
    }
}