using System;

namespace _03_面向对象练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student ZhangSan=new Student("张三",'男',13);
            ZhangSan.Math = 121;
            ZhangSan.Chinese = 100;
            ZhangSan.English = 100;

            Student XiaoLan=new Student("小蓝",'男',14);
            XiaoLan.Math = 100;
            XiaoLan.Chinese = 100;
            XiaoLan.English = 100;

            ZhangSan.SayHello();
            XiaoLan.Score();
        }
    }
}
