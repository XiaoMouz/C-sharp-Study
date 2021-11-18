using System;

namespace _07_类型转换
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne;
            //TryParse就是方法，方法可以自己写一个调用（好像？）
            //↓bool用于接收返回值  ↓---参数---↓
            bool b = int.TryParse("8894abc",out numberOne);
            Console.WriteLine(b);
            Console.WriteLine(numberOne);

            //方法/函数的用处：帮助Dev做某事
        }
    }
}
