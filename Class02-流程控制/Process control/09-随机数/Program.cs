using System;

namespace _09_随机数
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 9; i++)
            //{
            //    //产生随机数
            //    //1.创建一个能够产生随机数的对象
            //    Random r = new Random();
            //    //2.让产生随机数的对象调用方法来产生随机数
            //    int rNum = r.Next(1, 100);
            //    Console.WriteLine(rNum);
            //}

            //    输入名字随机显示这个人上辈子是干啥的
            //    设定随机数对象
            Random r = new Random();
            //进入问询循环
            while (true)
            {
                int rNum = r.Next(1, 7);
                //象征性输入名字
                Console.WriteLine("输入名字");
                string name = Console.ReadLine();
                //快速判断
                switch (rNum)
                {
                    case 1:
                        Console.WriteLine("{0}是0", name);
                        break;
                    case 2:
                        Console.WriteLine("{0}是1", name);
                        break;
                    case 3:
                        Console.WriteLine("{0}是mtf", name);
                        break;
                    case 4:
                        Console.WriteLine("{0}是桂林西瓜霜", name);
                        break;
                    case 5:
                        Console.WriteLine("{0}是红脖子", name);
                        break;
                    case 6:
                        Console.WriteLine("{0}你寄吧谁啊", name);
                        break;
                }
            }
        }
    }
}
