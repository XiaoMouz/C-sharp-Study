using System;
using System.Collections.Generic;
using System.Collections;

namespace 集合小题目
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 将一个数组的奇数放到一个集合中，偶数放到另一个集合，而后合并为一个集合，奇数显示在左，偶数显示在右
            //初始化变量
            //int[] nums = new int[100];
            //int sys = 0;
            //int _catch= 0;
            //List<int> odd = new List<int>();
            //List<int> even = new List<int>();
            //List<int> sum  = new List<int>();
            //
            ////简简单单赋个值
            //for (int i = 1; i < 101; i++)
            //{
            //    nums[i - 1] = i;
            //}
            //
            ////判断奇偶
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i]/2==nums[i/2])
            //    {
            //        even.Add(nums[i]);
            //    }
            //    else
            //    {
            //        odd.Add(nums[i]);
            //    }
            //}
            //
            ////将两个集合添加到总集合中
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if ((i + 1) % 2 == 0)
            //    {
            //        sum.Add(even[sys]);
            //        _catch++;
            //    }
            //    else
            //    {
            //        sum.Add(odd[sys]);
            //        _catch++;
            //    }

            //    if (_catch % 2 == 0)
            //    {
            //        sys++;
            //    }
            //}
            //
            ////打印
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine("{0}---{1}", sum[i], sum[++i]);
            //}
            #endregion

            #region 用户输入字符串，而后通过foreach将字符串赋值给一个字符数组
            ////初始化
            //string user_input = Console.ReadLine();
            //char[] chars_input = new char[user_input.Length];
            //
            ////一个计数器
            //int i = 0;
            //
            ////将字符逐个添加进char数组中
            //foreach (var item in user_input)
            //{
            //    chars_input[i] = item;
            //    i++;
            //}
            //
            ////打印核对
            //for (int c = 0; c < chars_input.Length; c++)
            //{
            //    Console.Write(chars_input[c]);
            //}
            #endregion

            #region 统计Welcome to china每个字符的出现次数，不计大小写
            //初始化
            string s = "Weclome to China";
            Dictionary<char,int> keyValuePairs = new Dictionary<char,int>();

            //进行判断和计数
            for (int i = 0; i < s.Length; i++)
            {
                //判断是否有空格
                if(s[i] == ' ')
                {
                    continue;
                }
                //判断是否存在该字符
                if (keyValuePairs.ContainsKey(s[i]))
                {
                    keyValuePairs[s[i]]++;//存在就++
                }
                else
                {
                    keyValuePairs.Add(s[i], 1);//不存在就添加
                }
            }
            //打印次数
            foreach (KeyValuePair<char,int> dude in keyValuePairs)
            {
                Console.WriteLine("字母{0}出现的次数{1}", dude.Key,dude.Value);
            }
            #endregion
        }
    }
}
