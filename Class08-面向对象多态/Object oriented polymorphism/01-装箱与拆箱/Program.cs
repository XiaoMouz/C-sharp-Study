using System;
using System.Collections;

namespace _01_装箱与拆箱
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //装箱
            int x1 = 1;
            object y1 = x1;

            //拆箱
            int x2 = (int)y1;
        
            //举例
            ArrayList list = new ArrayList();
            //这个循环发生了114514次装箱操作
            for (int i = 0; i < 114514; i++)
            {
                list.Add(i);
            }
        }
    }
}
