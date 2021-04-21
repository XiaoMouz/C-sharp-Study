using System;

namespace _03_循环结构while
{
    class Program
    {
        static void Main(string[] args)
        {
            /* while(循环条件) - 当条件=true时则循环，false时则跳出循环
             * {
             *  循环体; //执行完后会再判断一次循环条件
             * }
             */
            //打印100000次Hello world
            int i = 0;
            while (i < 1000)
            {
                i++;
                Console.WriteLine("Hello World!第{0}次", i);
            }
            Console.ReadKey();

        }
    }
}
