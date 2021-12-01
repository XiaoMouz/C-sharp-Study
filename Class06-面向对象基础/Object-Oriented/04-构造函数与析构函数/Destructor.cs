using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_构造函数与析构函数
{
    internal class Destructor
    {
        //析构函数
        ~Destructor()
        {
            Console.WriteLine("我是析构函数");
        }
    }
}
