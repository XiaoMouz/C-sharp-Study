using System;

namespace 方法的综合练习2
{
    //综合练习题2
    class Program
    {
        static void Main(string[] args)
        {
            //对比字符串数组，输出最长的字符串
            string[] list = { "1", "3", "121", "ywaiou", "pix" };
            string maxString = GetLongestString(list);
            Console.WriteLine(maxString);
        }

        /// <summary>
        /// 找到字符串数组中最长元素
        /// </summary>
        /// <param name="input">需要对比的数组</param>
        /// <returns>最长的元素</returns>
        public static string GetLongestString(string[] input)
        {
            string max = input[0];
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Length>max.Length)
                {
                    max = input[i];
                }
            }
            return max;
        }
    }
}
