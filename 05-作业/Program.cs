using System;

namespace _05_作业
{
    class Program
    {
        static void Main(string[] args)
        {
            //①计算第几天（46）是几周的第几天 ②计算107653s是几小时几分几秒 ③让用户输入秒数，计算几小时几分几秒
            //1
            int day = 46;
            int week = day / 7;
            int weekday = 46 - week * 7; // day % 7;也能达到同样效果
            Console.WriteLine("{0}天是第{1}周的第{2}天，按下任意键进入下一题", day, week, weekday);
            Console.ReadKey();

            ////2标准解法
            //int seconds = 107653;
            //int days = seconds / 86400;//求得天数
            //int secs = seconds % 86400;//求得求完天数后剩余秒数
            //int hours = secs / 3600;//求得小时数
            //secs = secs % 3600;//求得小时数后剩余秒数
            //int mins = secs % 60;//求得分钟数
            //secs = secs % 60;
            //Console.WriteLine("②{0}秒是{1}天{2}小时{3}分钟{4}秒", seconds, days, hours, mins, secs);
            //Console.ReadKey();


            ////3{bug error version}
            //string user_Input = Console.ReadLine();
            //int u_Sec = Convert.ToInt32(user_Input);
            //int u_Day = u_Sec / 86400;
            //int u_Secs = u_Sec % 86400;
            //int u_Hours = u_Secs % 3600;
            //u_Secs = u_Secs % 3600;
            //int u_Mins = u_Secs % 60;
            //u_Secs = u_Secs % 60;
            //int u_Min = u_Sec / 60;
            //int u_Hour = u_Sec / 3600;
            //int min_2 = u_Sec % 60;
            //int sec_2 = u_Sec % 3600 - min_2 * 60;
            //Console.WriteLine("{0}秒大约是{1}分钟、也大约是{2}小时，转换为{3}小时{4}分钟{5}秒", u_Sec, u_Min, u_Hour, u_Hours, min_2, sec_2);
            //Console.ReadKey();

            //3 {true version answer}

            string input = Console.ReadLine();
            int seconds = Convert.ToInt32(input);
            int days = seconds / 86400;//求得天数
            int secs = seconds % 86400;//求得求完天数后剩余秒数
            int hours = secs / 3600;//求得小时数
            secs = secs % 3600;//求得小时数后剩余秒数
            int mins = secs % 60;//求得分钟数
            secs = secs % 60;
            Console.WriteLine("②{0}秒是{1}天{2}小时{3}分钟{4}秒", seconds, days, hours, mins, secs);
            Console.ReadKey();
        }
    }
}
