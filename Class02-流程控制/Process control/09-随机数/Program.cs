using System;

namespace _09_随机数
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 9; i++)
            {
                //产生随机数
                //1.创建一个能够产生随机数的对象
                Random r = new Random();
                //2.让产生随机数的对象调用方法来产生随机数
                int rNum = r.Next(1, 100);
                Console.WriteLine(rNum);
            }
        }
    }
}
