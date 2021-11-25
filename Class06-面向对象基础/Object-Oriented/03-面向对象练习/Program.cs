using System;

namespace _03_面向对象练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student ZhangSan=new Student();
            ZhangSan.Name = "张三";
            ZhangSan.Age = 13;
            ZhangSan.Gender = '男';
            ZhangSan.Math = 121;
            ZhangSan.Chinese = 100;
            ZhangSan.English = 100;

            Student XiaoLan=new Student();
            XiaoLan.Name = "小蓝";
            XiaoLan.Age = 13;
            XiaoLan.Gender = '中';
            XiaoLan.Math = 100;
            XiaoLan.Chinese = 100;
            XiaoLan.English = 100;

            ZhangSan.SayHello();
            XiaoLan.Score();
        }
    }
}
