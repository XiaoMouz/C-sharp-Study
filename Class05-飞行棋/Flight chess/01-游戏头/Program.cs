﻿using System;

namespace _01_游戏头
{
    class Program
    {
        //使用静态int数组模拟全局变量来初始化地图
        public static int[] Maps = new int[100];
        //使用静态int数组来存储玩家a和玩家b的位置
        public static int[] PlayersGPS = new int[2];
        static void Main(string[] args)
        {
            GameMenu();
            InitializationMap();
            DrawMap();

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
                Maps[landMine[i]] = 2;
            }

            int[] pause = { 9, 23, 57, 60, 80 };
            for (int i = 0; i < pause.Length; i++)
            {
                Maps[pause[i]] = 3;
            }

            int[] tunnel = { 14, 42, 65, 85, 90 };
            for (int i = 0; i < tunnel.Length; i++)
            {
                Maps[tunnel[i]] = 4;
            }

        }

        public static void DrawMap()
        {
            #region 第一横行
            for (int i = 0; i < 30; i++)
            {
                //当a和b坐标相同并且都位于地图上时则绘制括号
                if ((PlayersGPS[0] == PlayersGPS[1])&&PlayersGPS[1]==i)
                {
                    Console.Write("<>");
                }
                else if (PlayersGPS[0] == i){
                    //打印玩家A位置
                    Console.Write("Ａ");
                }else if (PlayersGPS[1] == i)
                {
                    //打印玩家B的位置
                    Console.Write("Ｂ");
                }
                else
                {
                    //打印各个位置的符号
                    switch (Maps[i])
                    {
                        case 0:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("□");
                            break;
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("●");
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("☆");
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.Write("▲");
                            break;
                        case 4:
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.Write("卍");
                            break;
                    }
                }
            }
            #endregion

            #region 第一竖行
        }
    }
}
