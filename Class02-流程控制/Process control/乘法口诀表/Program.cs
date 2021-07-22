using System;

namespace 乘法口诀表
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <= 9; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("{0}*{1}={2}\t", i, j, i * j);
            //    }
            //    Console.WriteLine();
            //}
            //+
            Console.WriteLine("plz input a num(only 1,only int)");
            int input = 0;
            try
            {
                input = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("你他妈是不是看不懂英文啊，老子让你输入一位整数，滚蛋!");
            }
            for (int i = 0; i <= input; i++)
            {
                Console.WriteLine("{0}+{1}={2}", i, input - i, input);
            }
        }
    }
}
