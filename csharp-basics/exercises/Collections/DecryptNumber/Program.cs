using System;
using System.Collections.Generic;
using System.Linq;

namespace DecryptNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cryptedNumbers = new List<string>
            {
                "())(",
                "*$(#&",
                "!!!!!!!!!!",
                "$*^&@!",
                "!)(^&(#@",
                "!)(#&%(*@#%"
            };

            var keyboardMapping = new Dictionary<char, char>
            {
                {'!', '1'}, {'@', '2'}, {'#', '3'}, {'$', '4'},
                {'%', '5'}, {'^', '6'}, {'&', '7'}, {'*', '8'},
                {'(', '9'}, {')', '0'}
            };

            var decryptedNumbers = cryptedNumbers.Select(crypted => new string(crypted
                .Select(c => keyboardMapping[c]).ToArray()));

            foreach (var decrypted in decryptedNumbers)
            {
                Console.WriteLine(decrypted);
            }
        }
    }
}
