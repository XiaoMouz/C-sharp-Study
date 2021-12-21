using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_继承
{
    internal class Teacher
    {
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

        private double _salary;
        public double Salary{
            get { return _salary; }
            set { _salary = value; }
        }
      
        public void CH(){
            Console.WriteLine("CH");
        }

        public void Sent(){
            Console.WriteLine("G");
        }
    }
}
