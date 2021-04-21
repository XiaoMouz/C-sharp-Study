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
            double people = 80000;
            int year = 2006;
            while (people <= 200000)
            {
                people *= 1.25;
                year++;
            }
            int human = Convert.ToInt32(people);
            Console.WriteLine("{0}年时有{1}人", year, human);
            #endregion

            #region Q4回答
            string userName_A = "";
            string userName_B = "";
            while (userName_B == ""||userName_B==userName_A)
            {
                while (userName_A == "")
                {
                    Console.WriteLine("请A输入用户名，用户名不得为空");
                    userName_A = Console.ReadLine();
                }
                Console.WriteLine("请B输入用户名，用户名不得为空并且不得与A重复");
                userName_B = Console.ReadLine();
            } 
            #endregion
        }
    }
}
