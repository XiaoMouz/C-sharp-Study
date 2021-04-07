using System;

namespace if作业
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 作业1
            //对比用户输入的3个数字，不考虑相等
            //Console.WriteLine("请输入数字");
            //int numberOne = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入数字");
            //int numberTwo = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入数字");
            //int numberThree = Convert.ToInt32(Console.ReadLine());

            //if(numberOne>numberTwo&&numberOne>numberThree)
            //{
            //    Console.WriteLine("numberOne");
            //}
            //else if(numberTwo>numberOne&&numberTwo>numberThree)
            //{
            //    Console.WriteLine("numberTwo");
            //}
            //else
            //{
            //    Console.WriteLine("numberThree");
            //}
            #endregion
            #region 作业2
            //判断密码正确与否（英数混合）
            //Console.WriteLine("密码为？");
            //string enterPassword = Console.ReadLine();
            //if (enterPassword == "pix123")
            //{
            //    Console.WriteLine("login success");
            //}
            //else
            //{
            //    Console.WriteLine("error:01-password error;you only have last one chance");
            //    enterPassword = Console.ReadLine();
            //    if (enterPassword == "pix123")
            //    {
            //        Console.WriteLine("login success");
            //    }
            //    else
            //    {
            //        Console.WriteLine("error:01-password error;exit programmer");
            //    }
            //}
            #endregion
            #region 作业3
            //Get User Enter
            //Console.WriteLine("Login System,Please Enter Your Username");
            //string username = Console.ReadLine();
            //Console.WriteLine("Please Enter Your Password");
            //string password = Console.ReadLine();

            ////Username=admin Password=abc123
            //if(username=="admin"&&password=="abc123")
            //{
            //    Console.WriteLine("Login success");
            //}
            //else if(username=="admin")
            //{
            //    Console.WriteLine("Password is wrong");
            //}
            //else if (password=="abc123") //通常的登录若用户名错误则不继续，所以可以略去这一段
            //{
            //    Console.WriteLine("username is wrong but your password is true");
            //}
            //else
            //{
            //    Console.WriteLine("Error 0x1:No User and Wrong Password");
            //}
            #endregion
            #region 作业4
            //年龄限制系统 若user的年龄大于18岁则直接显示，在18-10岁（含10岁不含18岁）之间则提示是否要查看（并获取输入是否），小于10岁则直接退出
            Console.WriteLine("请输入你的年龄以查看此内容");
            int age = Convert.ToInt32(Console.ReadLine());
            //my answer
            //if(age>18)
            //{
            //    Console.WriteLine("你看个鸡巴，老色批");
            //}
            //else if(age<18&&age>=10)
            //{
            //    Console.WriteLine("您确定要查看此内容？（确定请输入yes，取消请输入no");
            //    string choose = Console.ReadLine();
            //    if(choose=="yes")
            //    {
            //        Console.WriteLine("你看个鸡巴，老色批");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("您与本作品无缘");
            //}    
            
            //example answer
            if(age>18)
            {
                Console.WriteLine("你看个鸡巴，老色批");
            }
            else if(age<10)
            {
                Console.WriteLine("您与本作品无缘");
            }
            else
            {
                Console.WriteLine("您是否要看本作品?y/n");
                string choose = Console.ReadLine();
                if (choose == "y"||choose == "yes")
                {
                    Console.WriteLine("你看个鸡巴，老色批");
                }
                else
                {
                    Console.WriteLine("好！我即刻滚蛋");
                }    
            }
            #endregion
        }
    }
}
