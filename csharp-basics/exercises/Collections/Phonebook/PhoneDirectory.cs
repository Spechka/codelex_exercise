using System;
using System.Collections.Generic;

namespace PhoneBook
{
    public class PhoneDirectory
    {
        private SortedDictionary<string, string> _data;
        private int _dataCount;

         public PhoneDirectory(PhoneEntry entry) 
         {
            _data.Add(entry.name, entry.number);
            _dataCount = 1;
         }

        private int Find(string name) {
            int counter = 1;

            foreach (var entry in _data)
            {
                if (entry.Key == name)
                {
                    return counter;
                }

                counter++;
            }

            return -1;
        }

        public string GetNumber(string name) 
        {
            string number;
            var position = Find(name);
            if (position == -1) 
            {
                return null;
            } 
            else 
            {
                _data.TryGetValue(name, out number);
                return number;
            }
        }

        public void PutNumber(string name, string number) 
        {
            if (name == null || number == null) 
            {
                throw new Exception("name and number cannot be null");
            }

            var i = Find(name);
            if (_data.ContainsKey(name))
            {
                _data[name] = number;
            }
            else
            {
                _data.Add(name, number);
            }
        }
    }
}