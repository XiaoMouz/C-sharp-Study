using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_里氏转换
{
    internal class Student : Person //继承Person
    {
        public Student(string name, int age, char gender, int id) : base(name, age, gender)
        {
            Id = id;
        }
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public void Get()
        {
            Console.WriteLine(Id);
        }

        public void StudentSayHello()
        {
            Console.WriteLine("{0}是学生", this.Name);
        }
    }
}
