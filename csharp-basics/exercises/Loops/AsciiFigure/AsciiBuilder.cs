using System;

namespace AsciiFigure
{
    public class AsciiBuilder
    {
        private const int Rows = 6;
        public static void Print()
        {
            for (int i = 0; i < Rows; i++)
            {
                Console.WriteLine(new String('/', (Rows - i) * 4) + new String('*', i * 8) + new String('\\', (Rows - i) * 4));
            }
        }
    }
}
