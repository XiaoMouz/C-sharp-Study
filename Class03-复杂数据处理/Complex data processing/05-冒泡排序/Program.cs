﻿using System;

namespace _05_冒泡排序
{
    class Program
    {
        static void Main(string[] args)
        {
            //冒泡排序：将一个数组中的元素按照从大到小/从小到大的顺序进行排列
            int[] nums = { 1, 3, 5, 6, 2, 7, 9, 4, 8, 0 };
            //将其改为升序排列
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length - 1 - i; j++)
                {
                    if(nums[j]>nums[j+1])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
            //简化↓      Sort做升序排列，Reverse对数组反转
            //Array.Sort(nums); //降序只需先Sort再Reverse

        }
    }
}
