using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 里氏转换练习
{
    internal class Teacher:Person
    {
        public void TeacherSayHello()
        {
            Console.WriteLine("I'm a Teacher");
            //ji
        }
    }
}
