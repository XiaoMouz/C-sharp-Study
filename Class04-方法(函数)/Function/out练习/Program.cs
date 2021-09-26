using System;

namespace out练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //解决登录问题
            //1、判断登录是否成功
            //2、失败是错了用户名还是密码
            string username;
            string password;
            while (true)
            {
                Console.WriteLine("Please enter your username");
                username = Console.ReadLine();
                Console.WriteLine("Enter your password right now");
                password = Console.ReadLine();
                bool usernameJudge;
                bool login = LoginSystem(username, password, out usernameJudge);
                if (login)
                {
                    Console.WriteLine("Success,Waiting command");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    if (usernameJudge)
                    {
                        Console.WriteLine("password is wrong");
                    }
                    else
                    {
                        Console.WriteLine("username is wrong");
                    }
                }
            }            
        }

        /// <summary>
        /// 账户判断模块
        /// </summary>
        /// <param name="username">输入的用户名</param>
        /// <param name="password">输入的密码</param>
        /// <param name="usernameJudge">用户名对错判断</param>
        /// <returns>用户名密码是否正确</returns>
        public static bool LoginSystem(string username,string password,out bool usernameJudge)
        {
            if(username=="admin")
            {
                usernameJudge = true;
                if(password == "1233321")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                usernameJudge = false;
                return false;
            }
        }
    }
}
