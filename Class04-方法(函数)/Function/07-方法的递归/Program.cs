using System;

namespace _07_方法的递归
{
    class Program
    {
        public static int i = 0;
        static void Main(string[] args)
        {
            //方法自己调用自己
            TellWho();
            Console.WriteLine(i);
        }


        public static void TellWho()
        {
            //倘若在方法内声明变量用于判断则会导致变量被重置为0，因此需要使用局部静态变量(?)
            //int i = 0;
            Console.WriteLine("Hello,World");
            Console.WriteLine(":)");
            if (i >= 0)
            {
                return;
            }
            TellWho();
            //在每次递归时，return并没有执行，在满足i >= 0这个条件后才会执行递归
        }
    }
}
