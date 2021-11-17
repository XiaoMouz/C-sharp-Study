﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_基础的面向对象项目
{
    //在写好一个类之后，我们应该创建这个类的对象
    //在这个类创建对象的过程称作[类的实例化]
    public class Person
    {
        public string _name;//姓名
        public string Name//透过属性保护字段
        {
            //当输出属性时优先使用get方法
            get { return _name; }//控制取值
            //为属性赋值时优先使用set方法
            set { _name = value; }//控制赋值
        }

        public int _age;//年龄
        public char _gender;//性别

        public void CHLSS()//非静态方法
        {
            Console.WriteLine("{0}是一位{1}岁的{2}性，能够执行CHLSS这些活动",this._name,this._age,this._gender);//this表示这个类的对象
        }

        public static void CHALL()//静态方法
        {

        }

    }
}
