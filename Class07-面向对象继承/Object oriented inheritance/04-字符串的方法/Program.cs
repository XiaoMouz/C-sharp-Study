using System;
using System.Text;

namespace _04_字符串的方法
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //nums.Length 长度
            string value = "djiwai";
            Console.WriteLine("{0}",value.Length);

            //nums.ToUpper 转大写
            value = value.ToUpper();
            Console.WriteLine(value);
            //nums.ToLower 转小写
            value = value.ToLower();
            Console.WriteLine(value);

            //nums.Equals 对比
            if ( value.Equals("Djiwai",StringComparison.OrdinalIgnoreCase) ) //StringComparison.OrdinalIgnoreCase 是选择需要进行对比的类型
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }
            //nums.Split 分割
            value = "dkowkdo++==  @@ ADPAP";
            char[] redgo = { '+', '=', ' ', '@' };
            //string[] s = value.Split(redgo);Console.WriteLine(s);//这是将redgo中的字符全部分割掉，但会保留空字符
            string[] s = value.Split(redgo,StringSplitOptions.RemoveEmptyEntries);Console.WriteLine(s); //与上文注释一致的分割，然后通过RemoveEmptyEntries来清空空字符


            //练习：用户输入2008-01-16，将其显示为2008年1月16日
            string date=Console.ReadLine();
            char[] del = { '-' };
            string[] sdata = date.Split(del, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("{0}年{1}月{2}日",sdata[0],sdata[1],sdata[2]);

            //nums.replace 替换
        }
    }
}
