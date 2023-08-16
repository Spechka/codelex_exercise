using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    internal class Dog
    {
        private string _name;
        private string _sex;
        public Dog Mother;
        public Dog Father;

        public Dog(string name, string sex)
        {
            _name = name;
            _sex = sex;
        }

        public void SetParents(Dog mother, Dog father)
        {
            Mother = mother;
            Father = father;
        }

        public string FatherName()
        {
            return Father == null ? "Unknown" : Father._name;
        }

        public bool HasSameMother(Dog compareMom)
        {
            return Mother == compareMom.Mother;
        }
    }
}
