using System;

namespace _01_游戏头
{
    class Program
    {
        //使用静态int数组模拟全局变量来初始化地图
        public static int[] Maps = new int[100];
        //使用静态int数组来存储玩家a和玩家b的位置
        public static int[] PlayersGPS = new int[2];
        //使用静态字符串数组来存储玩家名称
        public static string[] PlayerNames = new string[2];
        static void Main(string[] args)
        {
            GameMenu();
            #region 输入玩家姓名
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("请输入玩家A姓名");
            PlayerNames[0] = Console.ReadLine();
            while (PlayerNames[0]=="")
            {
                Console.WriteLine("玩家名称不能为空");
                PlayerNames[0] = Console.ReadLine();
            }
            Console.WriteLine("输入玩家B的姓名");
            PlayerNames[1] = Console.ReadLine();
            while (PlayerNames[1]==""||PlayerNames[1]==PlayerNames[0])
            {
                if (PlayerNames[1] == "")
                {
                    Console.WriteLine("玩家B姓名不得为空");
                    PlayerNames[1] = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("玩家B姓名不得与A相同");
                    PlayerNames[1] = Console.ReadLine();
                }
            }
            #endregion
            //在游戏玩家输入成功后应当直接清屏重新打印游戏头
            Console.Clear();

            GameMenu();
            Console.WriteLine("{0}的士兵使用A表示，{1}的士兵使用B表示", PlayerNames[0], PlayerNames[1]);
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

        /// <summary>
        /// 绘制地图
        /// </summary>
        public static void DrawMap()
        {
            #region 第一横行
            for (int i = 0; i < 30; i++)
            {
                Console.Write(PrintfString(i));
            }
            #endregion
            //换行
            Console.WriteLine();

            #region 第一竖行
            for (int i = 30; i < 35; i++)
            {
                for (int j = 0; j <= 28; j++)
                {
                    Console.Write("  ");
                }
                Console.Write(PrintfString(i));
                Console.WriteLine();
            }
            #endregion

            #region 倒序横行
            for (int i = 64; i >= 35; i--)
            {
                Console.Write(PrintfString(i));
            }
            #endregion
            //换行
            Console.WriteLine();

            #region 倒序竖行
            for (int i = 65; i <= 69; i++)
            {
                Console.WriteLine(PrintfString(i));
            }
            #endregion

            #region 最后一行
            for (int i = 70; i <= 99; i++)
            {
                Console.Write(PrintfString(i));
            }
            #endregion
        }

        /// <summary>
        /// 对轮询到的数组下标值进行对比并将其打印
        /// </summary>
        private static string PrintfString(int i)
        {
            string s = "";
            //当a和b坐标相同并且都位于地图上时则绘制括号
            if ((PlayersGPS[0] == PlayersGPS[1]) && PlayersGPS[1] == i)
            {
                s = "<>";
            }
            else if (PlayersGPS[0] == i)
            {
                //打印玩家A位置
                s = "Ａ";
            }
            else if (PlayersGPS[1] == i)
            {
                //打印玩家B的位置
                s = "Ｂ";
            }
            else
            {
                //打印各个位置的符号
                switch (Maps[i])
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        s = "□";
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        s = "●";
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        s = "☆";
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        s = "▲";
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        s = "卍";
                        break;
                }
            }
            return s;
        }
    }
}
