using System;
using System.Text;

namespace _04_字符串的方法
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //nums.Length
            string value = "djiwai";
            Console.WriteLine("{0}",value.Length);
            //nums.ToUpper
            value = value.ToUpper();
            Console.WriteLine(value);
            //nums.ToLower
            value = value.ToLower();
            Console.WriteLine(value);
            //nums.Equals
            if (value.Equals("Djiwai",StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }
            //nums.Split
            value = "dkowkdo++==  @@ ADPAP";
            char[] redgo = { '+', '=', ' ', '@' };
            //string[] s = value.Split(redgo);Console.WriteLine(s);//这是将redgo中的字符全部分割掉，但会保留空字符
            string[] s = value.Split(redgo,StringSplitOptions.RemoveEmptyEntries);Console.WriteLine(s); //分割，但是通过RemoveEmptyEntries来清空空字符


            //练习：用户输入2008-01-16，将其显示为2008年1月16日
            string date=Console.ReadLine();
            char[] del = { '-' };
            string[] sdata = date.Split(del, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("{0}年{1}月{2}日",sdata[0],sdata[1],sdata[2]);
        }
    }
}
