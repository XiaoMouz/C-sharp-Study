using System;

//常量 枚举 结构 数组
namespace _01_复习
{
    //创建枚举
    public enum Gender
    {
        男,
        女
    }

    //创建结构
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
            //设定常量
            const int number = 10;

            //枚举的调用
            Gender gender = Gender.男;

            //结构的调用
            Person 张三person;
            张三person._name = "张三";
            张三person._age = 21;
            张三person._gender = Gender.男;

            //数组 可以一次性存储多个相同类型变量 长度不可改变
            int[] nums = new int[10];
            Console.WriteLine(nums[2]);//访问数组内数据
        }
    }
}
