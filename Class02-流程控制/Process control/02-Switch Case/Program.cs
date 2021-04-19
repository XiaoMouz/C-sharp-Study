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
            switch(level)
            {
                case "A":salary += 500;
                    break;
                case "B":salary += 200;
                    break;
                case "C":break;
                case "D":salary -= 200;
                    break;
                case "E":salary -= 500;
                    break;
                default:Console.WriteLine("error，crush");
                    past = false;
                    break;
            }
            if(past)
            {
                Console.Write("员工工资修改为{0}", salary);
            }
        }
    }
}
