using System;

namespace csharp变量交换
{
    class Program
    {
        static void Main(string[] args)
        {
            //Way1:使用3个变量来进行变量交换

            /**
            int example1 = 10;
            int example2 = 15;

            Console.WriteLine("当前example1为{0}，example2为{1}，按下任意键继续运行", example1, example2);
            Console.ReadKey();

            int temp = example1; //缓存example1

            example1 = example2; //将example1改为example2
            example2 = temp; //将example2改为temp（也就是一开始的example1)

            Console.WriteLine("现在example1为{0}，example2为{1}，按下任意键结束运行", example1, example2);
            Console.ReadKey();
            **/

            //Way2:使用2个变量来进行变量交换

            int example1 = 15;
            int example2 = 19;

            Console.WriteLine("当前example1为{0}，example2为{1}，按下任意键继续运行", example1, example2);
            Console.ReadKey();

            example1 = example1 - example2; //example1为俩值的差
            example2 = example2 + example1; //example2将差去掉
            example1 = example2 - example1; //example1获得example2的值并且加上自己

            Console.WriteLine("现在example1为{0}，example2为{1}，按下任意键结束运行", example1, example2);
            Console.ReadKey();
        }
    }
}
