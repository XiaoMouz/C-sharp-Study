using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_序列化与反序列化
{
    [Serializable]
    internal class Person
    {
        private string _name;
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _gender;
        public string gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        private int _age;
        public int age
        {
            get { return _age; }
            set { _age = value; }
        }
    }
}
