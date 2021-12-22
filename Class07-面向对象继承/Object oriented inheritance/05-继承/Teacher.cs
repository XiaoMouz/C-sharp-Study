using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_继承
{
    internal class Teacher:Person
    {
        private double _salary;
        public double Salary{
            get { return _salary; }
            set { _salary = value; }
        }

        public void Sent(){
            Console.WriteLine("G");
        }
    }
}
