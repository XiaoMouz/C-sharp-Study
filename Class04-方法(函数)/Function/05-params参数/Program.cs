using System;

namespace _05_params参数
{
    class Program
    {
        static void Main(string[] args)
        {
            //params
            int[] s = { 99, 88, 77, 55 };
            Test("张三",s);//在使用parmas后可以选择直接输入数组变量名、int类型数字、int变量，若不使用parmas则必须输入数组才能运行
            Console.ReadKey();
        }
        public static void Test(string name, params int[] score)
            //params必须是形参列表中的最后一个，并且也只能有一个params在方法的形参列表中
        {
            int sum = 0;
            for (int i = 0; i < score.Length; i++)
            {
                sum += score[i];
            }
            Console.WriteLine("{0}这次考试的总成绩是{1}", name, sum);
        }
    }
}
