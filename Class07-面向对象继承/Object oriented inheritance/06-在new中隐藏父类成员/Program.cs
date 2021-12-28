using System;

namespace _06_在new中隐藏父类成员
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("131", 12, 'm', 1);
            s.SayHello();//只有子类的sayhello
        }
    }
}
