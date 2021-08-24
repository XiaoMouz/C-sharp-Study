using System;

namespace _06_方法_函数_
{
    //方法要写在namespace内或者class内
    class Program
    {
        /// <summary>
        /// 用于计算两个整数之间的最大值，并且返回最大值
        /// </summary>
        /// <param name="n1">第一个整数</param>
        /// <param name="n2">第二个整数</param>
        /// <returns>返回最大值</returns>
        public static int GetMax(int n1,int n2)
        {
            return n1 > n2 ? n1 : n2;
                //return:1、在方法中返回要返回的值
                //       2、立即结束本次方法
        }
        static void Main(string[] args)
        {
            //方法是一种一堆代码进行重用机制，防止多余/低效率应用代码
            //[public] static 返回值类型 方法名称([参数列表])
            //{
            //      方法体
            //}
            //public 访问修饰符
            //static 表示静态
            //返回值类型 string int double.... 如果不需要返回值则写void即可
            //方法名 符合Pascal命名规范
            //参数列表 完成方法所必须要提供给这个方法的条件，如果没有参数，小括号也不能省略()

            //方法的调用:类名.方法名();
            //在某些情况下，类名是可以省略的，比如当你写的方法和Main函数在同一个类中时，可以省略类名

            //Q:计算两个整数之间的最大值  [调用方法]
            int max = Program.GetMax(1, 3);
            Console.WriteLine(max);
            Console.ReadKey();
        }
    }
}
