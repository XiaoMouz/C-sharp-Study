﻿using System;

namespace _03_while循环
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

            //int i = 0;
            //while (i < 1000)
            //{
            //    i++;
            //    Console.WriteLine("Hello World!第{0}次", i);
            //}
            //Console.ReadKey();

            //求1-100所有偶数的和(while)
            //int i = 1;
            //int sum = 0;
            //while (i <= 100)
            //{
            //    if (i % 2 == 0)//判断为偶数
            //    {
            //        sum += i;
            //    }
            //    i++;
            //}

            //do-while循环(do-while)
            int i = 0;
            int sum = 0;
            do
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
                i++;
            } while (i < 100);
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
