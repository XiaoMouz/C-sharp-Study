using System;

namespace _07_if初学
{
    class Program
    {
        static void Main(string[] args)
        {
            //if
            #region 题目一:Disenable
            //Q：当输入者年龄大于30时反馈输入者你该结婚了
            //console.writeline("请输入你的年龄");
            //int age = convert.toint32(console.readline());
            //bool age_judge = age > 30;
            //if(age_judge) 
            //{
            //    console.writeline("你该结婚了");
            //}
            //if(age_judge == false)
            //{
            //    console.writeline("你继续上班吧");
            //}
            //END
            #endregion
            #region 题目二:Disenable
            ////如果输入者的中文成绩与音乐成绩符合如下任意条件则奖励100元
            ////语文>90且音乐>80 || 语文=100且音乐>70
            //Console.WriteLine("请输入语文成绩");
            //int chinese = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入音乐成绩");
            //int music = Convert.ToInt32(Console.ReadLine());
            //bool end = (chinese > 90 && music > 80) || (chinese == 100 && music > 70);  //谨记运算符!
            //if(end)
            //{
            //    Console.WriteLine("你获得了100元");
            //}
            //if (end==false)
            //{
            //    Console.WriteLine("你获得了一顿毒打");
            //}
            #endregion
            #region 题目三:Enable
            Console.WriteLine("请输入你的用户名");
            string username = Console.ReadLine();
            Console.WriteLine("请输入你的密码");
            string password = Console.ReadLine();
            bool allow = (username == "admin") && (password == "mypass");
            if (allow)
            {
                Console.WriteLine("登录成功");
            }
            if (allow == false)
            {
                Console.WriteLine("密码错误，程序退出");
            }
            #endregion
            //if-else

        }
    }
}
