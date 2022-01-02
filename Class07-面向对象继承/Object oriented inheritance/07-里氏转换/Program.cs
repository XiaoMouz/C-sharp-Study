using System;

namespace _07_里氏转换
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Note Updated
            Student s = new Student("name",12,'m',1);
            Person p = s; //若父类装的是子类对象，那么可以说这个父类强转为子类对象，如右侧代码赋值
            //甚至可以使用以下代码达到上面的效果
            //Person p = new Student();

            //父类强转子类
            Person pp = new Student("name2", 13, 'w', 2);//新建父类对象
            Student ss = (Student)p;//将父类强转

            //is
            //if (p is Teacher)
            //{ //Teacher在类视图中与Student同等级，因此转换应失败
            //    Teacher t = (Teacher)p;
            //}
            //else
            //{
            //    Console.WriteLine("失败");
            //}

            //as
            Teacher t = p as Teacher;//由于失败，因此t的值为none
 
        }
    }
}
