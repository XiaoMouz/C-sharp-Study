using System;

namespace _04_数组
{
    class Program
    {
        static void Main(string[] args)
        {
            ////一次性存储多个同类型的变量即采用数组
            ///* 数组类型[] 数字名称=new 数组类型[数字长度];
            // * 数组长度一旦固定不可再次改变
            // * int[] nums=new int[10];
            // */
            int[] nums = new int[10];
            ////访问其中一个数据并且写入（第七个元素）
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    nums[i] = i;
            //    Console.WriteLine(nums[i]);
            //}
            string[] string_Group = new string[10];
            
            bool[] bool_Group = new bool[10];

            int[] nums_Two = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            
            int[] nums_Three = new int[3] { 1, 2, 3 }; //不推荐
            int[] nums_Four = new int[] { 1, 2, 3, 4 };//不推荐

        }
    }
}
