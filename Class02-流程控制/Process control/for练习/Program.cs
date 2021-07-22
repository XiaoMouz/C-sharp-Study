using System;

namespace for练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //Q1:录入5个人年龄并且计算平均年龄，出现负数与大于100的数报错
            #region Q1 AW
            //int sum = 0;
            //bool b = true;
            //for(int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("请输入第{0}个人的年龄",i+1);
            //    try
            //    {
            //        int age = Convert.ToInt32(Console.ReadLine());
            //        if (0 <= age && age <= 100)
            //        {
            //            sum += age;
            //        }
            //        else
            //        {
            //            Console.WriteLine("error");
            //            b = false;
            //            break;
            //        }
            //    }
            //    catch
            //    {
            //        Console.WriteLine("error");
            //        b = false;
            //        break;
            //    }
            //}
            //if(b)
            //{
            //    Console.WriteLine("平均年龄是{0}", sum / 5);
            //}
            #endregion
            //Q2:使用while与break让用户一直输入用户密码，只要不是admin 12345就一直循环，若是就退出
            #region Q2 AW
            //string username = "admin";
            //string password = "12345";
            //while(true)
            //{
            //    Console.WriteLine("请输入用户名");
            //    string input_name = Console.ReadLine();
            //    Console.WriteLine("请输入密码");
            //    string input_pwd = Console.ReadLine();
            //    if (input_name == username && input_pwd == password)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("用户名或密码错误");ofoe
            //    }
            //}
            #endregion
            //?Q3:1-100之间的帧数相加，得到累加值大于20的当前数（eg:1+2+3+4+5+6=21 sum>=20 输出6)
            #region Q3 AW
            //int sum = 0;
            //for (int i = 0; i < 100; i++)
            //{
            //    sum += i;
            //    if (sum >= 20)
            //    {
            //        Console.WriteLine("加到{0}是，总和大于20", i);
            //        break;
            //    }
            //}
            #endregion
            //Q4：水仙花数
            #region
            //for (int i = 100; i <= 999; i++)
            //{
            //    int a = i / 100;
            //    int b = i % 100 / 10;
            //    int c = i % 10;
            //    if(a*a*a+b*b*b+c*c*c==i)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.ReadKey();
            #endregion
        }
    }
}
