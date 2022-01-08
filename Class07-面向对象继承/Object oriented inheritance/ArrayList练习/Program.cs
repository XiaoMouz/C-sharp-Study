using System;
using System.Collections;

namespace ArrayList练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //创建集合，添加10个随机数，要求不重复，求出平均值与和
            ArrayList numList = new ArrayList();

            Random rNum = new Random();
            int temp = 0;
            for (int i = 0; i < numList.Count; i++)
            {
                temp = 0;
                temp = rNum.Next();
            }
        }
    }
}
