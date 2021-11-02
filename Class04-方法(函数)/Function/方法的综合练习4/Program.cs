using System;

namespace 方法的综合练习4
{
    class Program
    {
        static void Main(string[] args)
        {
            //计算任意多个数间的最大值
            int max = GetMax(1, 3, 1, 14, 2, 56, 1, 41);
            Console.WriteLine(max);

            //通过冒泡排序将以下数组进行升序排序
            int[] group = { 1, 3, 5, 7, 9, 90, 2, 4, 6, 8, 10 };
            NumArray(group);
            for (int i = 0; i < group.Length; i++)
            {
                Console.WriteLine(group[i]);
            }

            //通过方法实现将字符串数组元素间添加分割符号|
            string[] s = { "djaio", "fdokof", "jiajfio", "sjio" };
            Console.WriteLine(ProcessString(s));

        }
        public static string ProcessString(string[] s)
        {
            string str = null;
            for (int i = 0; i < s.Length-1; i++)
            {
                str += s[i] + "|";
            }
            return str + s[s.Length - 1];
        }
        public static void NumArray(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length-1-i; j++)
                {
                    if(nums[j]>nums[j+1])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }
        }
        public static int GetMax(params int[] nums)
        {
            int max=0;
            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i]>max)
                {
                    max = nums[i];
                }
            }
            return max;
        }
    }
}
