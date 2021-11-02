using System;

namespace 方法的综合练习3
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用一个方法判断用户输入是否是质数
            //使用一个方法判断用户输入是否是数字，若不是则要求重新输入
            int num;
            while (true) {
                Console.WriteLine("输入个数字");
                if (isNumOrNot(Console.ReadLine(), out num))
                {
                    if (isPrimeOrNot(num))
                    {
                        Console.WriteLine("是个质数");
                    }
                    else
                    {
                        Console.WriteLine("不是质数");
                    }
                }
                else
                {
                    Console.WriteLine("有误，重新输入");
                    continue;
                }
            }

        }
        /// <summary>
        /// 用于判断用户输入是否为数字，若是数字则转换为整数并输出
        /// </summary>
        /// <param name="input">用户输入</param>
        /// <param name="number">转换后整数</param>
        /// <returns>是否为数字</returns>
        public static bool isNumOrNot(string input,out int number)
        {
            while (true)
            {
                try
                {
                    number = Convert.ToInt32(input);
                    return true;
                }
                catch
                {
                    number = 0;
                    return false;
                }
            }
        }
        /// <summary>
        /// 用于判断传入整数是否是质数
        /// </summary>
        /// <param name="num">数字</param>
        /// <returns>判断结果</returns>
        public static bool isPrimeOrNot(int num)
        {
            if (num < 2)
            {
                return false;
            }
            else
            {
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
