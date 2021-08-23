using System;

namespace _03_结构
{
    //结构应用范围与枚举一致、命名空间内、类内，可读取范围也与枚举一致
    class Program
    {
        public struct Person
        {
            public string _name;//字段，字段命名必须加下划线
            public int _age;
            public Gender _gender;
            public int _grade;
        }
        
        public enum Gender
        {
            男,
            女
        }
        static void Main(string[] args)
        {
            //结构用于一次性声明多个不同类型的变量
            /* [public] struct 结构名
             * {
             *       成员;
             *       成员;
             * }
             */

            Person zsPerson;
            zsPerson._name = "张三";
            zsPerson._age = 21;
            zsPerson._gender = Gender.男;
            zsPerson._grade = 3;

            Person lsPerson;
            lsPerson._name = "李四";
            lsPerson._age = 22;
            lsPerson._gender = Gender.女;
            lsPerson._grade = 4;
        }
    }
}
