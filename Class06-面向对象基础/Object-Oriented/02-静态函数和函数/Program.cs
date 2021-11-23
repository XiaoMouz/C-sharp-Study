using System;

namespace _02_静态函数和函数
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.M1(); //调用实例方法(非静态方法)前需要先创建对象，而后才能调用非静态方法
            
            //而静态方法可以直接调用，就像Console.WriteLine那样，但是p1.M2是不起作用的
            Person.M2();

            //Profile p2 = new Profile(); 无法使用，静态类无法被实例化
            //应当使用类名.成员调用
            Profile.age = 114;


            //
        }

    }
}
