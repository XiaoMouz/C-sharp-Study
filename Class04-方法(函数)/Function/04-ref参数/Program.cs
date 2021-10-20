using System;

namespace _04_ref参数
{
    class Program
    {
        static void Main(string[] args)
        {
            //ref类似指针
            //通过ref可以将变量直接送进方法中运行，在结束后将改变的结果带出方法，无需重新赋值接收
            #region 例子
            int cash = 1000;
            //如果使用方法Add，则不会发生变动，如果使用方法Drop则需要新建接收用变量
            Add(ref cash);
            Console.WriteLine(cash);
            #endregion
        }
        public static void Add(ref int cash)
        {
            cash += 500;
        }
        public static int Drop(int cash)
        {
            cash -= 500;
            return cash;
        }
    }
}
