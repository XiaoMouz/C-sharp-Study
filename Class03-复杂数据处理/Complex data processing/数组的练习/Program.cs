using System;

namespace 数组的练习
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 从整数数组中取出最大整数、最小整数、总和、平均值
            int[] nums = { 3, 1, 5, 6, 9, 14, 9, 13, -10 };
            //存储用
            int max = nums[0];
            int min = nums[0];
            int sum = 0;
            //循环对比最大最小值
            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i]>max)
                {
                    max = nums[i];
                }
                if(nums[i]<min)
                {
                    min = nums[i];
                }
                sum += nums[i];
            }
            Console.WriteLine("最大值{0},最小值是{1}，总和是{2}，平均数是{3}", max, min, sum, sum / nums.Length);
            #endregion
        }
    }
}
