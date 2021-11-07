using System;

namespace _01_游戏头
{
    class Program
    {
        //使用静态字段模拟全局变量来初始化地图
        public static int[] Maps = new int[100];

        static void Main(string[] args)
        {
            GameMenu();
        }


        /// <summary>
        /// 游戏LOGO
        /// </summary>
        public static void GameMenu()
        {
            //Console.BackgroundColor = ConsoleColor.Gray; <这玩意太丑了，不想用
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("----------------------");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----------------------");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("----------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("--Flight Chess  v1.0--");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("----------------------");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("----------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("----------------------");
        }
        
        public static void M1()
        {

        }
    }
}
