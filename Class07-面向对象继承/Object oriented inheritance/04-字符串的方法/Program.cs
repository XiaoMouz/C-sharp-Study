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
            //string date=Console.ReadLine();
            string date = "2021-01-16";
            char[] del = { '-' };
            string[] sdata = date.Split(del, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("{0}年{1}月{2}日",sdata[0],sdata[1],sdata[2]);

            //nums.contains/replace 配对与替换
            string textChat = "国家主席";
            if (textChat.Contains("主席")){
                textChat = textChat.Replace("主席", "**");
            }
            Console.WriteLine(textChat);

            //nums.Substring 截取字符串
            textChat = "你是个傻逼";
            textChat = textChat.Substring(3);
            Console.WriteLine(textChat);
            textChat = textChat.Substring(0, 1);
            Console.WriteLine(textChat);

            //nums.Startwith/nums.Endwith 字符串的开始/结束
            string api = "api.version=v1";
            if (api.StartsWith("api")){
                Console.WriteLine("api Get");
            }
            else{
                Console.WriteLine("not api");
            }

            if (api.EndsWith("v1"))
            {
                Console.WriteLine("api version is v1");
            }
            else{
                Console.WriteLine("api version not is v1");
            }

            //int IndexOf(char/string) 找到字符串开始的下标[详细参考note]
            int index = 0;
            index = api.IndexOf("v1");
            Console.WriteLine(index);

            //int LastIndexOf(char/string)
        }
    }
}
