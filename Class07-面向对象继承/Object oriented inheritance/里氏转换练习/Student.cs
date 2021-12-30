using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 里氏转换练习
{
    internal class Student:Person
    {
        public void StudentSayHello()
        {
            Console.WriteLine("I'm a Student");
        }
    }
}
