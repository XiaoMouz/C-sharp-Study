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
            InitializationMap();

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
        
        //其它解法，保留
        //public static void MapPrintf()
        //{
        //    int[] market = { 4, 6, 11, 56 };
        //    for (int i = 0; i < Maps.Length; i++)
        //    {
        //            if (Maps[i]==market[i])
        //            {
        //                Console.ForegroundColor = ConsoleColor.Red;
        //                Console.Write("A");
        //            }
        //            else
        //            {
        //                Console.ForegroundColor = ConsoleColor.Gray;
        //                Console.Write("-");
        //            }
        //    }
        //}

        /// <summary>
        /// 地图初始化，将地图打上标记
        /// </summary>
        public static void InitializationMap()
        {
            int[] luckyturn = { 6, 17, 48, 53, 88 };
            for (int i = 0; i < luckyturn.Length; i++)
            {
                Maps[luckyturn[i]] = 1;
            }

            int[] landMine = { 4, 10, 31, 66, 72, 91 };
            for (int i = 0; i < landMine.Length; i++)
            {
                Maps[landMine[i]] = 1;
            }

            int[] pause = { 9, 23, 57, 60, 80 };
            for (int i = 0; i < pause.Length; i++)
            {
                Maps[pause[i]] = 1;
            }

            int[] tunnel = { 14, 42, 65, 85, 90 };
            for (int i = 0; i < tunnel.Length; i++)
            {
                Maps[tunnel[i]] = 1;
            }

        }


    }
}
