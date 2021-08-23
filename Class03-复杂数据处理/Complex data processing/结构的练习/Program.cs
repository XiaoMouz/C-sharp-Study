using System;

namespace 结构的练习
{
    public struct MyColor
    {
        public int _red;
        public int _blue;
        public int _green;
    }

    public enum Gender
    {
        男,
        女
    }

    public struct Person
    {
        public string _name;
        public int _age;
        public Gender _gender;
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region 颜色
            //定义MyColor结构，设定int类型的红蓝绿
            //再声明一个MyColor类型的变量，并对成员赋值，使MyColor可以表示成红色
            //MyColor mc;
            //mc._red = 255;
            //mc._blue = 0;
            //mc._green = 0;
            #endregion


            //定义一个结构类型Person，有三个成员（姓名、年龄、性别），性别使用枚举
            //声明其变量，分别表示 张三/男/18 李四/女/16

            Person 张三;
            张三._name = "张三";
            张三._age = 18;
            张三._gender = Gender.男;

            Person 李四;
            李四._name = "李四";
            李四._age = 16;
            李四._gender = Gender.女;

            Console.WriteLine("我叫{0},{1}岁，性别{2}", 张三._name, 张三._age, 张三._gender);
            Console.WriteLine("我叫{0},{1}岁，性别{2}", 李四._name, 李四._age, 李四._gender);
        }
    }
}
