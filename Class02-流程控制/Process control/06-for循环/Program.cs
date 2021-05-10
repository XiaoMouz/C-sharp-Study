using System;

namespace _06_for循环
{
    class Program
    {
        static void Main(string[] args)
        {
            //输入for然后按下两次tab
            //输入forr然后按下两次tab便是i-- for循环
            //在控制台打印10次Hello,world
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Hello,world");
            //}
            //for循环一般用于已知循环次数的循环 条件仅能为数字
            //while循环一般用于未知循环次数的循环 只需bool条件为true
            //for循环循环条件为固定顺序
            //int i=0只执行一次
            //i<10会执行多次来判断
            //当循环体结束会执行i++

            //求1-100的整数和
            int sum = 0;
            for (int i = 0; i <= 100; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
