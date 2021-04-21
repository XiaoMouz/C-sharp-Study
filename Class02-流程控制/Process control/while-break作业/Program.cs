using System;

namespace while_break作业
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Q1:输入人数，依次输入成绩，计算平均成绩和每个人总成绩
             * Q2:询问你是否会了，若会(y)则结束，若不会(n)则重复
             * Q3:06年有8w人，每年都会比上年增长25%，到哪一年会达到20w人
             * Q4: A输入用户名，用户名不得为空，否则一直循环，B输入用户名，B用户名不得为空并且不得与A重复,否则一直循环
             */
            #region Q1回答
            //int i = 1;
            //try
            //{
            //    Console.WriteLine("请输入你班有多少人");
            //    int count = Convert.ToInt32(Console.ReadLine());
            //    double class_sum = 0;
            //    double class_avg = 0;
            //    while (i <= count)
            //    {
            //        Console.WriteLine("请输入学生姓名");
            //        string name = Console.ReadLine();
            //        try
            //        {
            //            Console.WriteLine("请输入{0}的语文成绩", name);
            //            double chinese = Convert.ToInt32(Console.ReadLine());
            //            Console.WriteLine("请输入{0}的数学成绩", name);
            //            double math = Convert.ToInt32(Console.ReadLine());
            //            Console.WriteLine("请输入{0}的英语成绩", name);
            //            double english = Convert.ToInt32(Console.ReadLine());
            //            double sum = chinese + math + english;
            //            double avg = sum / 3;
            //            Console.WriteLine("{0}的总成绩为{1}，平均分为{2}", name, sum, avg);
            //            i++;
            //            class_sum += sum;
            //        }
            //        catch
            //        {
            //            Console.WriteLine("你输入的值有误");
            //        }
            //    }
            //    class_avg = class_sum / count;
            //    Console.WriteLine("你班有{0}人，总成绩为{1}，班平均分为{2}", count, class_sum, class_avg);
            //}
            //catch
            //{
            //    Console.WriteLine("您的输入有误");
            //}
            #endregion

            #region Q2回答
            //int i = 1;
            //while (i<=10)
            //{
            //    Console.WriteLine("第{0}遍，你有没有学会,回答y/n",i);
            //    string ans = Console.ReadLine();
            //    if (ans == "y" || ans == "yes")
            //    {
            //        Console.WriteLine("好，拜拜");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("好，老子再说一遍");
            //        i++;
            //    }
            //}
            #endregion

            #region Q3回答
            //double people = 80000;
            //int year = 2006;
            //while (people <= 200000)
            //{
            //    people *= 1.25;
            //    year++;
            //}
            //int human = Convert.ToInt32(people);
            //Console.WriteLine("{0}年时有{1}人", year, human);
            #endregion

            #region Q4回答
            //string userName_A = "";
            //string userName_B = "";
            //while (userName_B == ""||userName_B==userName_A)
            //{
            //    while (userName_A == "")
            //    {
            //        Console.WriteLine("请A输入用户名，用户名不得为空");
            //        userName_A = Console.ReadLine();
            //    }
            //    Console.WriteLine("请B输入用户名，用户名不得为空且不得与A重复");
            //    userName_B = Console.ReadLine();
            //} 
            #endregion

            /* do-while
             * Q1:要求用户一直输入姓名，或者输入q结束程序
             * Q2:要求输入数字，然后打印这个数字的二倍，输入q就退出程序
             * Q3:要求输入用户数字，而后输入q时打印刚才数字中的最大值
             */

            #region Q1回答
            //string name = "";
            //do
            //{
            //    Console.WriteLine("请输入name");
            //    name = Console.ReadLine();
            //} while (name != "q"); 
            #endregion

            #region Q2回答
            //int num;
            //string save;
            //do
            //{
            //    Console.WriteLine("请输入一个数字");
            //    save = Console.ReadLine();
            //    try
            //    {
            //        num = Convert.ToInt32(save);
            //        Console.WriteLine(num * 2);
            //    }
            //    catch
            //    {
            //        Console.WriteLine("正在识别是否为q，若为q则将退出程序");
            //    }
            //} while (save != "q"); 
            #endregion

            #region Q2答案
            //string input = "";
            //while (input != "q")
            //{
            //    Console.WriteLine("请输入一个数字");
            //    input = Console.ReadLine();
            //    if(input!="q")
            //    {
            //        try
            //        {
            //            int number = Convert.ToInt32(input);
            //            Console.WriteLine("其二倍为{0}", number * 2);
            //        }
            //        catch
            //        {
            //            Console.WriteLine("您输入的字符有误");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("拜拜");
            //    }
            //} 
            #endregion

            #region Q3回答
            double max = 0;
            string input = "q";
            do
            {
                Console.WriteLine("请输入正整数");
                input = Console.ReadLine();
                if (input != "q")
                {
                    try
                    {
                        int num = Convert.ToInt32(input);
                        if (num > max)
                        {
                            max = num;
                        }

                    }
                    catch
                    {
                        Console.WriteLine("您的输入有误");
                    }
                }
                else
                {
                    Console.WriteLine("最大数是{0}", max);
                }
            } while (input != "q");

            #endregion
        }
    }
}
