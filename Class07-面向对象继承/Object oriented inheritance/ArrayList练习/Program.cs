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
            int sum=0;
            for (int i = 0; i < 10; i++)
            {
                temp = rNum.Next(0,13456789);
                if (numList.Contains(temp))
                {
                    i--;
                    continue;
                }
                else
                {
                    numList.Add(temp);
                }
            }

            for (int i = 0; i < numList.Count; i++)
            {
                sum+=(int)numList[i];
            }
            Console.WriteLine(sum);
            Console.WriteLine(sum/numList.Count);
        }
    }
}
