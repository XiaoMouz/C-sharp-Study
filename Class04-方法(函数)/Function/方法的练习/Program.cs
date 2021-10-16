using System;

namespace 方法的练习
{
    class Program
    {
        //  Q1用
        /// <summary>
        /// 判断给定年份是否为闰年
        /// </summary>
        /// <param name="year">要判断的年份</param>
        /// <returns>是否是闰年</returns>
        public static bool IsLeapYear(int year)
        {
            bool b = (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
            return b;
        }
        //Q2用
        /// <summary>
        /// 将用户输入的值转换为数字，出错时会要求用户重新输入
        /// </summary>
        /// <param name="input">用户输入的值</param>
        /// <returns>数字</returns>
        public static int InputNumber(string input)
        {
            int number;
            while(true)
            {
                try
                {
                    number = Convert.ToInt32(input);
                    return number;
                }
                catch
                {
                    Console.WriteLine("请重新输入");
                    input = Console.ReadLine();
                }
            }
        }
        //Q3用
        /// <summary>
        /// 判断用户输入y还是n，限定小写，出错会要求重输
        /// </summary>
        /// <param name="input">获取到的用户输入</param>
        /// <returns>true或false</returns>
        public static bool Allow(string input)
        {
            while (true)
            {
                if(input == "y")
                {
                    return true;
                }
                else if(input=="n")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("有误，重输");
                    input = Console.ReadLine();
                }
            }
        }
        //Q4用
        /// <summary>
        /// 输入数组，得出总和
        /// </summary>
        /// <param name="nums">数组</param>
        /// <returns>总和</returns>
        public static int GetSum(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum;
        }

        static void Main(string[] args)
        {
            #region 写一个方法，判断年份是否为闰年
            //bool b = IsLeapYear(2000);
            //Console.WriteLine(b);
            #endregion
            #region 使用方法读取输入的整数并且打印出来[考虑非数字可能性]
            //Console.WriteLine("输入一个数字吧");
            //string input = Console.ReadLine();
            //InputNumber(input);
            #endregion
            #region 使用方法读取用户输入的值以判断是否通过
            Console.WriteLine("您若允许请输入y不允许请输入n");
            string input = Console.ReadLine();
            bool b = Allow(input);
            if(b)
            {
                Console.WriteLine("ok");
            }
            else
            {
                Console.WriteLine("nope");
            }
            #endregion

        }
    }
}
