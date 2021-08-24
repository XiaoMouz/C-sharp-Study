using System;

namespace 数组的练习
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 从整数数组中取出最大整数、最小整数、总和、平均值
            //int[] nums = { 3, 1, 5, 6, 9, 14, 9, 13, -10 };
            ////存储用
            //int max = int.MinValue;//nums[0];
            //int min = int.MaxValue;//nums[0];
            //int sum = 0;
            ////循环对比最大最小值
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if(nums[i]>max)
            //    {
            //        max = nums[i];
            //    }
            //    if(nums[i]<min)
            //    {
            //        min = nums[i];
            //    }
            //    sum += nums[i];
            //}
            //Console.WriteLine("最大值{0},最小值是{1}，总和是{2}，平均数是{3}", max, min, sum, sum / nums.Length);
            #endregion
            #region 计算一个整数数组的所有元素的和
            //Random random = new Random();
            //int[] nums = new int[10];
            //int sum = 0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    nums[i] = random.Next(1, 114514);
            //    Console.WriteLine("给第{0}个数赋值了{1}这个数", i + 1, nums[i]);
            //}
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    sum += nums[i];  
            //}
            //Console.WriteLine("总和为" + sum);
            #endregion
            #region 打印string数组内的名字为xx|xx|xx
            //string[] names = { "张三", "李四", "王五", "老六" };
            //string name = null;
            ////Console.WriteLine("{0}|{1}|{2}|{3}", names[0], names[1], names[2], names[3]);
            ////通过一个循环，获得字符串中的所有元素并累加到一个字符串中，以|为分隔线
            //for (int i = 0; i < names.Length-1; i++)
            //{
            //    name += names[i] + "|";
            //}
            //Console.WriteLine(name + names[names.Length - 1]);
            #endregion
            #region 将一个整数数组做如下处理：若为正数将其+1，若为负数将其-1，若为0则不变
            //int[] nums = new int[30];
            //Random random = new Random();
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    nums[i] += random.Next(-114514, 114514);
            //    Console.WriteLine("第{0}个数获得了{1}",i+1,nums[i]);
            //}

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if(nums[i]>0)
            //    {
            //        nums[i]++;
            //    }
            //    else if(nums[i]<0)
            //    {
            //        nums[i]--;
            //    }
            //    Console.WriteLine("第{0}个数，被修改为了{1}", i + 1, nums[i]);
            //}
            #endregion
            #region 将字符串数组中的元素进行反转（即为将第i个和第length-i-1个进行交换
            string[] names = { "张三", "李四", "王五", "老六" };
            for (int i = 0; i < names.Length/2; i++)
            {
                string temp = names[i];
                names[i] = names[names.Length - i - 1];
                names[names.Length - i - 1] = temp;
            }
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]); 
            }
            #endregion
        }
    }
}
