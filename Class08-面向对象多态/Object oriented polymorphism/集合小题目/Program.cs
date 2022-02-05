using System;
using System.Collections.Generic;
using System.Collections;

namespace 集合小题目
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //将一个数组的奇数放到一个集合中，偶数放到另一个集合，而后合并为一个集合，奇数显示在左，偶数显示在右
            //初始化变量
            int[] nums = new int[100];
            int sys = 0;
            int _catch= 0;
            List<int> odd = new List<int>();
            List<int> even = new List<int>();
            List<int> sum  = new List<int>();
            //简简单单赋个值
            for (int i = 1; i < 101; i++)
            {
                nums[i - 1] = i;
            }
            //判断奇偶
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i]/2==nums[i/2])
                {
                    even.Add(nums[i]);
                }
                else
                {
                    odd.Add(nums[i]);
                }
            }
            //将两个集合添加到总集合中
            for (int i = 0; i < nums.Length; i++)
            {
                if ((i + 1) % 2 == 0)
                {
                    sum.Add(even[sys]);
                    _catch++;
                }
                else
                {
                    sum.Add(odd[sys]);
                    _catch++;
                }

                if (_catch % 2 == 0)
                {
                    sys++;
                }
            }
            //打印
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine("{0}---{1}", sum[i], sum[++i]);
            }
        }
    }
}
