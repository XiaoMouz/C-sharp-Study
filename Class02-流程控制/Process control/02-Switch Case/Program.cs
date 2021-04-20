using System;

namespace _02_Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            //员工评级，若评价为A则+500元工资，若B则+200元工资，若C则不变，若D则-200，若E则-500，原工资为5000元
            double salary = 5000;
            Console.WriteLine("请输入评价");
            string level = Console.ReadLine();
            bool past = true;

            #region if写法
            //if (level == "A")
            //{
            //    salary += 500;
            //}
            //else if (level == "B")
            //{
            //    salary += 200;
            //}
            //else if (level == "C")
            //{
            //    salary += 0;
            //}
            //else if (level == "D")
            //{
            //    salary -= 200;
            //}
            //else if (level == "E")
            //{
            //    salary -= 500;
            //}
            //else
            //{
            //    Console.WriteLine("错误，程序退出");
            //    past = false;
            //}
            //if (past)
            //{
            //    Console.WriteLine("工资已修改为{0}", salary);
            //} 
            #endregion
            #region switch写法
            switch (level)
            {
                case "A":
                    salary += 500;
                    break;
                case "B":
                    salary += 200;
                    break;
                case "C": break;
                case "D":
                    salary -= 200;
                    break;
                case "E":
                    salary -= 500;
                    break;
                default:
                    Console.WriteLine("error，crush");
                    past = false;
                    break;
            }
            if (past)
            {
                Console.Write("员工工资修改为{0}", salary);
            }
            #endregion

            Console.WriteLine("按任意键next");
            Console.ReadLine();


            //评分，当分数≥90时=A，≥80时=B，≥70时=C，≥60时=D，＜60=E
            #region Q1回答
            Console.WriteLine("请输入分数");
            try
            {
                int score = Convert.ToInt32(Console.ReadLine());
                switch (score / 10) //将其转为单位数
                {
                    case 10:
                    case 9:
                        Console.WriteLine("A");
                        break;
                    case 8:
                        Console.WriteLine("B");
                        break;
                    case 7:
                        Console.WriteLine("C");
                        break;
                    case 6:
                        Console.WriteLine("D");
                        break;
                    default:
                        Console.WriteLine("E");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("错误");
            }
            #endregion

            Console.WriteLine("按任意键next");
            Console.ReadLine();


            //输入月份，显示天数（注意闰年）
            try
            {


                Console.WriteLine("请输入年份");
                int year = Convert.ToInt32(Console.ReadLine());
                try
                {


                    Console.WriteLine("请输入月份");
                    int month = Convert.ToInt32(Console.ReadLine());
                    if (month >= 1 && month <= 12)
                    {



                        #region Q2回答
                        //    switch (month)
                        //    {
                        //        case 1:
                        //        case 3:
                        //        case 5:
                        //        case 7:
                        //        case 8:
                        //        case 10:
                        //        case 12:
                        //            Console.WriteLine("本月有31天");
                        //            break;
                        //        case 4:
                        //        case 6:
                        //        case 9:
                        //        case 11:
                        //            Console.WriteLine("本月有30天");
                        //            break;
                        //        case 2: //判断年份
                        //            bool year_yes = false;
                        //            if (year % 400 == 0 || year % 4 == 0 && year % 100 != 0)
                        //            {
                        //                Console.WriteLine("已判定为闰年，2月份为29天");
                        //            }
                        //            else
                        //            {
                        //                Console.WriteLine("已判定非闰年，2月份为28天");
                        //            }
                        //            break;
                        //    }
                        //}
                        #endregion

                        #region Q2答案
                        int day = 0;
                        switch (month)
                        {
                            case 1:
                            case 3:
                            case 5:
                            case 7:
                            case 8:
                            case 10:
                            case 12:
                                day = 31;
                                break;
                            case 2:
                                if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
                                {
                                    day = 29;
                                }
                                else
                                {
                                    day = 28;
                                }
                                break;
                            default:
                                day = 30;
                                break;
                        }
                        Console.WriteLine("{0}年{1}月有{2}天", year, month, day);
                    }
                    else
                    {
                        Console.WriteLine("error:month input");
                    }
                }
                catch//月检查
                {
                    Console.WriteLine("error:month input");
                }
            }
            catch//年检查
            {
                Console.WriteLine("error:year input");
            }
            #endregion
        }
    }
}
