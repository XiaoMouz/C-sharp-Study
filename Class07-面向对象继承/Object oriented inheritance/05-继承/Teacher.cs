using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_继承
{
    internal class Teacher:Person //继承Person
    {
        public Teacher(string name,int age,char gender,double salary) : base(name, age, gender)
        {
            this.Salary = salary;
        }

        private double _salary;
        public double Salary{
            get { return _salary; }
            set { _salary = value; }
        }

        public void Sent(){
            Console.WriteLine("已赋予工资{0}",Salary);
        }
    }
}
