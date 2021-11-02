using System;

namespace 方法的总综合练习
{
    //综合练习题1
    class Program
    {
        static void Main(string[] args)
        {
            //提示用户输入两个数字，计算两个数字之间所有整数的总和
            //1用户只能输入数字
            //2计算和
            //3要求第一个数字必须比第二个数字小，否则重新输入[x]
            int sum;
            int minNum;
            int maxNum;
            Console.WriteLine("Input number");
            while (true)
            {
                if (ParseNum(Console.ReadLine(), Console.ReadLine(), out minNum, out maxNum)) //直接通过if内判断是否是正常字符
                {
                    if (minNum == maxNum) //判断是否是相同数字
                    {
                        Console.WriteLine("输入的数不能为{0}，{1}", minNum, maxNum);
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("输入字符不合法");
                    continue;
                }
            }
            if (minNum==0&&maxNum==0) //防止极小概率出现(为啥要改我内存)
            {
                Console.WriteLine("操你妈，立刻给我回报bug");
            }
            else
            {
                sum = GetSum(minNum, maxNum);
                Console.WriteLine("您输入的最小数是{0}，最大数是{1}，两数间整数总和(包括两数)是{2}", minNum, maxNum, sum);
            }

        }
        /// <summary>
        /// 判断是否能够转换为整数，并且返回最大值与最小值(自动完成对比并排序)
        /// </summary>
        /// <param name="input_1">用户输入的第一个字符</param>
        /// <param name="input_2">用户输入的第二个字符</param>
        /// <param name="minNum">最小值</param>
        /// <param name="maxNum">最大值</param>
        /// <returns>是否成功转换</returns>
        public static bool ParseNum(string input_1,string input_2,out int minNum,out int maxNum)
        {
            minNum = 0;
            maxNum = 0;
            int switchTemp;
            try
            {
                minNum = Convert.ToInt32(input_1);
                maxNum = Convert.ToInt32(input_2);
                if(minNum>maxNum) //进行大小比对
                {
                    switchTemp = minNum;
                    minNum = maxNum;
                    maxNum = switchTemp;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// 用于计算两数之间所有整数的总和(计算中会包括最小数与最大数)
        /// </summary>
        /// <param name="minNum">最小数</param>
        /// <param name="maxNum">最大数</param>
        /// <returns>总和</returns>
        public static int GetSum(int minNum,int maxNum)
        {
            int sum = 0;
            for (int i = minNum; i <= maxNum; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
