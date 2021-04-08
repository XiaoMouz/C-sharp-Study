using System;

namespace _01_异常处理
{
    class Program
    {
        static void Main(string[] args)
        {
            //通过try-catch来处理异常
            bool ans = true;
            int number = 0;
            Console.WriteLine("输入数字");
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch//如果try内代码报异常则执行catch
            {
                Console.WriteLine("error,your input not number");
                ans = false;
            }
            if(ans)//判断是否正常录入了number
            {
                Console.WriteLine(number * 2);
            }

        }
    }
}
