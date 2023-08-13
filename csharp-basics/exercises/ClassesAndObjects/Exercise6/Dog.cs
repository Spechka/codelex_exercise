using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    internal class Dog
    {
        public string Name;
        public string Sex;
        public Dog Mother;
        public Dog Father;

        public Dog(string name, string sex)
        {
            Name = name;
            Sex = sex;
        }

        public void SetParents(Dog mother, Dog father)
        {
            Mother = mother;
            Father = father;
        }

        public string FatherName()
        {
            return Father == null ? "Unknown" : Father.Name;
        }

        public bool HasSameMother(Dog compareMom)
        {
            return Mother == compareMom.Mother;
        }
    }
}
