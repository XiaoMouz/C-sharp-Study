using System;

namespace _04_构造函数与析构函数
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //调用构造函数与对象方法
            Constructor student = new Constructor("ZS",'c',12);
            student.SayHello();

            //程序结束时析构函数才执行
            //帮助我们释放资源
        }
    }
}
