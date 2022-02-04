using System;
using System.Collections.Generic;
using System.Linq;

namespace _14_List集合
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //创建泛型集合对象
            List<int> aw = new List<int>();
            aw.Add(1);
            int[] nums = aw.ToArray();
            List<int> bw = nums.ToList();
            aw.AddRange(nums);
        }
    }
}
