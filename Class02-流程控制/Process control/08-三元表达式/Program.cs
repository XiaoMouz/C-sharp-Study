using System;

namespace _08_三元表达式
{
    class Program
    {
        static void Main(string[] args)
        {
            //对比数字大小
            Console.WriteLine("请输入第一个数字");
            int numOne = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入第二个数字");
            int numTwo = int.Parse(Console.ReadLine());
            int max = numOne > numTwo ? numOne : numTwo;
            Console.WriteLine(max);
        }
    }
}
