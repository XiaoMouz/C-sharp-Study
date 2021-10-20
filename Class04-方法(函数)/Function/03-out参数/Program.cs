using System;

namespace _03_out参数
{
    class Program
    {
        static void Main(string[] args)
        {
            ////写一个方法求数组中的最大值、最小值、总和、平均值
            int[] nums = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            ////将要返回的4个值放到数组中返回
            //int[] res = GetMaxMinSumAvg(nums);
            //Console.WriteLine("最大值是{0}，最小值是{1}，总和是{2}，平均值是{3}", res[0], res[1], res[2], res[3]);
            int max, min, sum;
            double avg;
            TestOut(nums, out max, out min, out sum, out avg);
            Console.WriteLine("最大值是{0}，最小值是{1}，总和是{2}，平均值是{3}", max, min, sum, avg);
        }
        /// <summary>
        /// 求出最大值、最小值、总和、平均值
        /// </summary>
        /// <param name="nums">需要计算的数组</param>
        /// <returns>返回4位数组，最大值[0]，最小值[1]，总和为[2]，平均值为[3]</returns>
        public static int[] GetMaxMinSumAvg(int[] nums)
        {
            int[] res = new int[4];
            //设res[0存最大值、res[1]存最小值、res[2]存总和、res[3]存平均值
            res[0] = nums[0];
            res[1] = nums[0];
            res[2] = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (res[0]<nums[i])
                {
                    res[0] = nums[i];
                }
                if (res[1]>nums[i])
                {
                    res[1] = nums[i];
                }
                res[2] += nums[i];
            }
            res[3] = res[2] / nums.Length;
            return res;
        }


        /// <summary>
        /// 计算一个数组的最大值、最小值、总和、平均值
        /// </summary>
        /// <param name="nums">待求数组</param>
        /// <param name="max">返回的最大值</param>
        /// <param name="min">返回的最小值</param>
        /// <param name="sum">返回的总和</param>
        /// <param name="avg">返回的平均值</param>
        public static void TestOut(int[] nums, out int max, out int min, out int sum, out double avg)
        {
            //out参数要求在方法内部必须为其赋值
            max = nums[0];
            min = nums[1];
            sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (max < nums[i])
                {
                    max = nums[i];
                }
                if (min > nums[i])
                {
                    min = nums[i];
                }
                sum += nums[i];
            }
            avg = sum / nums.Length;
        }
    }
}
