using System;

namespace ref练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //Q:使用方法交换两个int类型变量
            int a = 10;
            int b = 20;
            Console.WriteLine(a);
            Console.WriteLine(b);
            NumberSwitch(ref a, ref b);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadKey();

        }
        public static void NumberSwitch(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
