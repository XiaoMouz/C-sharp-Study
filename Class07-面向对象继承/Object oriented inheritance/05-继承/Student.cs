using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_继承
{
    internal class Student
    {
        private string _name;
        public string Name{
            get { return _name; }
            set { _name = value; }
        }

        private int _age;
        public int Age { 
            get { return _age; } 
            set { _age = value; } 
        }

        private char _gender;
        public char Gender{
            get { return _gender; }
            set { _gender = value; }
        }

        private int _id;
        public int Id{
            get { return _id; }
            set { _id = value; }
        }

        public void CH(){
            Console.WriteLine("CH");
        }

        public void Get(int id){
            Console.WriteLine(id);
        }
    }
}
