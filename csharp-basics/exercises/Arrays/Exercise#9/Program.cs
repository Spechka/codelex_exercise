using System;

namespace Exercise_9
{
    internal class Program
    {
        static string CapitalizeFirstLetter(string name)
        {
            return char.ToUpper(name[0]) + name.Substring(1).ToLower();
        }
        static string[] CapMe(string[] names)
        {
            string[] capitalizedNames = new string[names.Length];
            for (int i = 0; i < names.Length; i++)
            {
                capitalizedNames[i] = CapitalizeFirstLetter(names[i]);
            }
            return capitalizedNames;
        }
        static void Main()
        {
            string[] names1 = { "mavis", "senaida", "letty" };
            string[] names2 = { "samuel", "MABELLE", "letitia", "meridith" };
            string[] names3 = { "Slyvia", "Kristal", "Sharilyn", "Calista" };

            string[] capitalizedNames1 = CapMe(names1);
            string[] capitalizedNames2 = CapMe(names2);
            string[] capitalizedNames3 = CapMe(names3);

            Console.WriteLine(string.Join(", ", capitalizedNames1));
            Console.WriteLine(string.Join(", ", capitalizedNames2));
            Console.WriteLine(string.Join(", ", capitalizedNames3));
        }
    }
}
