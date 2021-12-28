using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_继承
{
    internal class Student:Person //继承Person
    {
        public Student(string name,int age,char gender,int id) : base(name, age, gender)
        {
            this.Id = id;
        }
        private int _id;
        public int Id{
            get { return _id; }
            set { _id = value; }
        }

        public void Get(){
            Console.WriteLine(this.Id);
        }
    }
}
