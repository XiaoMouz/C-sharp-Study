using System;

namespace _10_重写ToString
{
    //本次使用非常规写法，不将其它类分文件
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

    }

    internal class Person
    {
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
