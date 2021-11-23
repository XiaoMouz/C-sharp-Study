using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_静态函数和函数
{
    internal class Person
    {
        //在非静态（实例）类中，既可以有静态成员也可以有实例成员
        public void M1()
        {
            //这是一个非静态方法
            //实例方法既可以使用静态成员也可以使用实例成员
            _name = "0";
            Name = "45455";
            _age = 12;
            Age = 14;
        }

        public static void M2()
        {
            //这是一个静态方法
            //_age和Age无法使用
            //静态函数中只能访问静态成员，不可访问实例成员
            _name="1";
            Name="123";
        }


        //无论什么情况，调用静态资源都需要使用类名来调用
        private static string _name;
        public static string Name
        {
            get { return Person._name; }
            set { Person._name = value; }
        }

        //而实例资源不使用类名调用，一般通过 this./对象名 来调用
        private static int _age;
        public static int Age
        {
            get { return _age; }
            set { _age = value; }
        }
    }
}
