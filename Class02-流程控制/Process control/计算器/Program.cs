using System;

namespace 计算器
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个加法计算式（限定一个加号");
            string input = Console.ReadLine();
            int input_Length = input.Length;
            int add = input.IndexOf("+");
            
        }
    }
}
