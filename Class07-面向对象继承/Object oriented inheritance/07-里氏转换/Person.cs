using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_里氏转换
{
    internal class Person
    {

        //使用此类作父类给各个职业类继承
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _age;
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        private char _gender;
        public char Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public void CH()
        {
            Console.WriteLine("CH");
        }

        public void SayHello()
        {
            Console.WriteLine("{0}是{1}岁的{3}生", Name, Age, Gender);
        }

        public Person(string name, int age, char gender)
        {
            _name = name;
            _age = age;
            _gender = gender;
        }
        public Person()
        {

        }
    }
}
