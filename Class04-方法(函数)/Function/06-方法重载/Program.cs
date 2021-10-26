using System;

namespace _06_方法重载
{
    class Program
    {
        static void Main(string[] args)
        {
            //方法的重载指的是方法的名称相同，参数类型不同
            int n1 = 10;
            int n2 = 20;
            m();//可以向其中填入int、double、string值，因为已经在方法中写明
            //方法重载的触发要求是：参数数量相同，参数类型不同 或者 参数数量不同，参数类型相同
            //触发要求见第一个m和第三个m或第一个m和第二个m
            //触发后即可让方法名字重复并且自动调用最佳参数
        }
        public static void m(int n1, int n2)
        {
            int res = n1 + n2;
        }
        public static double m(double d1, double d2)
        {
            return d1 + d2;
        }
        public static void m(int n1, int n2, int n3)
        {
            int res = n1 + n2 + n3;
        }
        public static string m(string s1, string s2)
        {
            string s = s1 + s2;
            return s;
        }
    }
}
