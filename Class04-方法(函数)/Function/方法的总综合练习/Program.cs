using System;

namespace 方法的总综合练习
{
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
                if (ParseNum(Console.ReadLine(), Console.ReadLine(), out minNum, out maxNum))
                {
                    if (minNum == maxNum)
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
            if (minNum==0&&maxNum==0)
            {
                Console.WriteLine("操你妈，立刻给我回报bug");
            }
            else
            {
                sum = GetSum(minNum, maxNum);
                Console.WriteLine("您输入的最小数是{0}，最大数是{1}，两数间整数总和(包括两数)是{2}", minNum, maxNum, sum);
            }

        }

        public static bool ParseNum(string input_1,string input_2,out int minNum,out int maxNum)
        {
            minNum = 0;
            maxNum = 0;
            int switchTemp;
            try
            {
                minNum = Convert.ToInt32(input_1);
                maxNum = Convert.ToInt32(input_2);
                if(minNum>maxNum)
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
