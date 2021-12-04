using System;
using System.Text;
using System.Diagnostics;

namespace _03_String_Builder_SB_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //String Builder是一个类，可以通过以下创建对象
            StringBuilder sb = new StringBuilder();

            string s = null;
            Stopwatch runningTime = new Stopwatch();//创建计时器，需要System.Diagnostics 
            runningTime.Start();//计时开始
            for (int i = 0; i < 100000; i++)
            {
                sb.Append(i);//利用SB进行增减
                //计时器：00:00:00.0035801

                //s += i;//连接、重新赋值
                //计时器：00:00:14.2638965
            }
            runningTime.Stop();//计时结束
            Console.WriteLine(runningTime.Elapsed);
            //Console.WriteLine(s);
            Console.WriteLine(sb.ToString());//转换为string后打印
        }
    }
}
