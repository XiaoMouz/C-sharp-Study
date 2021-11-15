using System;

namespace _01_基础的面向对象项目
{
    //类的语法：[public] class <class name>
    //{
    //  字段;
    //  属性;
    //  方法;
    //}
    
    //类不占内存，对象占用内存
    internal class Program
    {
        static void Main(string[] args)
        {
            string s;//string事系统提供类

            //创建Person类的对象
            Person aNewPerson = new Person();//自定义类
            aNewPerson._name = "小A";
            aNewPerson._age = 13;
            aNewPerson._gender = '男';

            //调用类的方法
            aNewPerson.CHLSS();
        }
    }
}
