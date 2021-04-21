using System;

namespace _04_break
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 1;
            //while(i<=10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //    break;//直接跳出循环  
            //}
            //用户登录，admin/888888，若错误要求重新输入
            #region 回答
            //int i = 4;
            //while (i > 0)
            //{
            //    Console.WriteLine("请输入账号");
            //    string userName = Console.ReadLine();
            //    Console.WriteLine("请输入密码");
            //    string passWord = Console.ReadLine();
            //    if ((username == "admin") && (password == "888888"))
            //    {
            //        Console.WriteLine("密码正确，程序退出");
            //        break;
            //    }
            //    else
            //    {
            //        i--;
            //        Console.WriteLine("密码错误，您还有{0}次机会", i);
            //    }
            //}
            #endregion
            string userName = "";
            string passWord = "";
            while (userName!="admin"||passWord!="888888")
            {
                Console.WriteLine("请输入用户名");
                userName = Console.ReadLine();
                Console.WriteLine("请输入密码");
                passWord = Console.ReadLine();
            }
            Console.WriteLine("登录成功");
            Console.ReadKey();
        }
    }
}
